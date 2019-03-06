using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: UrusUI
 * │ 
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author	: lanbery
 * │CreatTime	: 2019/3/5 17:44:55													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © NBS-Tech Team 2019.All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */
namespace UrusUI
{
    public class FTabButton : Button
    {
        static FTabButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FTabButton), new FrameworkPropertyMetadata(typeof(FTabButton)));
        }

        #region 依赖属性
        /// <summary>
        /// Orientation 控制Tab icon 和 text 是否在一行
        /// </summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("TabOrientation", typeof(Orientation), typeof(FTabButton),
                new FrameworkPropertyMetadata(Orientation.Vertical,FrameworkPropertyMetadataOptions.AffectsRender));

        public Orientation TabOrientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty FIconProperty =
            DependencyProperty.Register("icon", typeof(string), typeof(FTabButton),
                new FrameworkPropertyMetadata("\ue604"));
        public string Icon
        {
            get { return (string)GetValue(FIconProperty); }
            set { SetValue(FIconProperty, value); }
        }

        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register("IconSize", typeof(int), typeof(FTabButton),
                new FrameworkPropertyMetadata(20, FrameworkPropertyMetadataOptions.AffectsRender));

        public int IconSize
        {
            get { return (int)GetValue(IconSizeProperty); }
            set { SetValue(IconSizeProperty, value); }
        }

        public static readonly DependencyProperty IconMarginProperty =
            DependencyProperty.Register("IconMargin", typeof(Thickness), typeof(FTabButton),
                new FrameworkPropertyMetadata(new Thickness(2)));
        public Thickness IconMargin
        {
            get { return (Thickness)GetValue(IconMarginProperty); }
            set { SetValue(IconMarginProperty, value); }
        }

        /// <summary>
        /// Tab 下边线
        /// </summary>
        public static readonly DependencyProperty BorderThinknessProperty =
            DependencyProperty.Register("TabThinkness", typeof(Thickness), typeof(FTabButton),
                new FrameworkPropertyMetadata(new Thickness(0, 0, 0, 1)));
        public Thickness TabThinkness
        {
            get { return (Thickness)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty BorderColorProperty =
            DependencyProperty.Register("BorderColorProperty", typeof(SolidColorBrush), typeof(FTabButton),
        new FrameworkPropertyMetadata(new Thickness(0, 0, 0, 1)));
        public Thickness ActivedThinkness
        {
            get { return (Thickness)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty TabBorderBrushProperty =
            DependencyProperty.Register("TabBorderColor", typeof(Brush), typeof(FTabButton),
                new FrameworkPropertyMetadata(Brushes.DarkGoldenrod));

        public Brush TabBorderColor {
            get { return (Brush)GetValue(TabBorderBrushProperty); }
            set { SetValue(TabBorderBrushProperty,value); }
        }

 

        #endregion
    }
}
