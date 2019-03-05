using System;
using System.Windows;
using System.Windows.Controls;


/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: UrusUI
 * │ 
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author	: lanbery
 * │CreatTime	: 2019/3/5 16:17:10													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © NBS-Tech Team 2019.All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */
namespace UrusUI
{
    public class IconButton : Button
    {

        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton), new FrameworkPropertyMetadata(typeof(IconButton)));
        }

        #region 依赖属性
        /// <summary>
        /// 图标大小
        /// </summary>
        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register("IconSize", typeof(double), typeof(IconButton),
                new FrameworkPropertyMetadata(20.0, FrameworkPropertyMetadataOptions.AffectsRender));
        public double IconSize
        {
            get { return (double)GetValue(IconSizeProperty); }
            set { SetValue(IconSizeProperty, value); }
        }

        public static readonly DependencyProperty IconMarginProperty =
            DependencyProperty.Register("IconMargin", typeof(Thickness), typeof(IconButton),
                new FrameworkPropertyMetadata(new Thickness(0)));

        public Thickness IconMargin
        {
            get { return (Thickness)GetValue(IconMarginProperty); }
            set { SetValue(IconMarginProperty, value); }
        }

        public static readonly DependencyProperty NormalIconPathProperty =
            DependencyProperty.Register("NormalIcon", typeof(string), typeof(IconButton),
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender, IconSourceChanged));
        public string NormalIcon
        {
            get { return (string)GetValue(NormalIconPathProperty); }
            set { SetValue(NormalIconPathProperty, value); }
        }

        public static readonly DependencyProperty HoverIconPathProperty =
            DependencyProperty.Register("HoverIcon", typeof(string), typeof(IconButton),
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender, IconSourceChanged));

        public string HoverIcon
        {
            get { return (string)GetValue(HoverIconPathProperty); }
            set { SetValue(HoverIconPathProperty, value); }
        }

        public static readonly DependencyProperty PressIconProperty =
            DependencyProperty.Register("PressIcon", typeof(string), typeof(IconButton),
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender, IconSourceChanged));

        public string PressIcon
        {
            get { return (string)GetValue(PressIconProperty); }
            set { SetValue(PressIconProperty, value); }
        }

        public static readonly DependencyProperty DisableIconProperty =
            DependencyProperty.Register("DisableIcon", typeof(string), typeof(IconButton),
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender, IconSourceChanged));
        public string DisableIcon
        {
            get { return (string)GetValue(DisableIconProperty); }
            set { SetValue(DisableIconProperty, value); }
        }

        public static readonly DependencyProperty BorderVisibilityProperty =
            DependencyProperty.Register("BorderVisibility", typeof(Visibility), typeof(IconButton),
                new FrameworkPropertyMetadata(Visibility.Hidden, FrameworkPropertyMetadataOptions.AffectsRender));

        public Visibility BorderVisibility
        {
            get { return (Visibility)GetValue(BorderVisibilityProperty); }
            set { SetValue(BorderVisibilityProperty, value); }
        }



        #endregion

        /// <summary>
        /// Icon 源变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void IconSourceChanged(DependencyObject sender,DependencyPropertyChangedEventArgs e)
        {
            try
            {
                Application.GetRemoteStream(new Uri("pack://application:,,," + (string)e.NewValue));
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
        }
    }
}
