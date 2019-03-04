using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Urus.DemoWindow.Views;

namespace Urus.DemoWindow
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SetContentControl(new UserButton());
        }


        public void SetContentControl(object control)
        {
            if(control is Control)
            {
                this.rmainContainer.Children.Clear();
                this.rmainContainer.Children.Add(control as Control);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavLabel_Click(object sender,RoutedEventArgs e)
        {
            if (!(sender is MenuItem)) return;
            string arg = ((sender as MenuItem).CommandParameter).ToString();
            if (arg.Length == 0)return ;
            Control uc = null;
            switch (arg)
            {
                case "0":
                    uc = new UserButton();
               
                    break;
                case "1":
                    uc = new TestSimple();
                    break;
                default:
                    uc = new UserButton();
                    break;
            }
            SetContentControl(uc);
        }
    }
}
