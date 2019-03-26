using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Security.Principal;


/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: UrusTools.Utils
 * │ 
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author	: lanbery
 * │CreatTime	: 2019/3/26 16:07:51													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © NBS-Tech Team 2019.All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */
namespace UrusTools.Utils
{
    public class LocalInfoUtil
    {
        const string defConnDomain = "www.baidu.com";
        const string IPV4_REGX_EXPRESSION = @"0.0.0.0\s+0.0.0.0\s+(\d+.\d+.\d+.\d+)\s+(\d+.\d+.\d+.\d+)";
        // @"(?<= (\\b |\\D))(((\\d{1,2})|(1\\d{2})|(2[0-4]\\d)|(25[0-5]))\\.){3}((\\d{1,2})|(1\\d{2})|(2[0-4]\\d)|(25[0-5]))(?=(\\b|\\D))";

        private static bool isTracing = false;
        public static string GetLocalIPv4()
        {
            string result = RunApp("route", "print", isTracing);
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(result, IPV4_REGX_EXPRESSION);

            if (match.Success)
            {
                return match.Groups[2].Value;
            }
            else
            {
                try
                {
                    System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();
                    client.Connect(defConnDomain, 80);
                    Thread.Sleep(500);
                    string ip = ((System.Net.IPEndPoint)client.Client.LocalEndPoint).Address.ToString();
                    client.Close();
                    return ip;
                }
                catch(Exception e)
                {
                    //throw new Exception("not get IP.",e);
                    Console.WriteLine(e.Message,e.StackTrace);
                    return "ungeted IPv4";
                }
            }

        }

        public static string GetPrimaryDNS()
        {
            string result = RunApp("nslookup", "", isTracing);
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(result, @"\d+\.\d+\.\d+\.\d+");
            if (match.Success)
            {
                return match.Value;
            }
            else
            {
                throw new Exception("not get dns.");
            }
        }

        public static void setTracing(bool status)
        {
            isTracing = status;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="arg"></param>
        /// <param name="logged"></param>
        /// <returns></returns>
        public static string RunApp(string filename, string arg, bool logged)
        {
            try
            {
                if (logged)
                {
                    Trace.Write(filename + " " + arg);
                }
                Process proc = new Process();
                proc.StartInfo.FileName = filename;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.Arguments = arg;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(proc.StandardOutput.BaseStream, Encoding.Default))
                {
                    System.Threading.Thread.Sleep(100);

                    if (!proc.HasExited)
                    {
                        proc.Kill();
                    }
                    string txt = reader.ReadToEnd();
                    reader.Close();

                    if (logged) Trace.WriteLine(txt);
                    return txt;
                }
            }
            catch (Exception e)
            {
                if (logged) Trace.WriteLine(e);
                throw e;
            }
        }


        public static string GetLocalUsername()
        {
            try
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                return identity.Name;
            }
            catch
            {
                return "unknow";
            }
        }
    }
}
