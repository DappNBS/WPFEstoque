using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;


/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: Urus.DemoWindow
 * │ 
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author	: lanbery
 * │CreatTime	: 2019/3/7 16:20:15													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © NBS-Tech Team 2019.All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */
namespace UrusUI
{
    public class FButton : Button
    {
        public static SolidColorBrush SolidColor_Normal = new SolidColorBrush(Color.FromArgb(128,74,74,74));
        public static SolidColorBrush SolidColor_Checked = new SolidColorBrush(Color.FromRgb(74, 74, 74));

        public static readonly DependencyProperty PressedBackgroundProperty =
            DependencyProperty.Register("PressedBackground", typeof(Brush), typeof(FButton), new PropertyMetadata(Brushes.DarkBlue));

        public Brush PressedBackground
        {
            get { return (Brush)GetValue(PressedBackgroundProperty); }
            set { SetValue(PressedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty PressedForegroundProperty =
            DependencyProperty.Register("PressedForeground", typeof(Brush), typeof(FButton), new PropertyMetadata(Brushes.White));

        /// <summary>
        /// 鼠标按下
        /// </summary>
        public Brush PressedForeground
        {
            get { return (Brush)GetValue(PressedForegroundProperty); }
            set { SetValue(PressedForegroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(FButton), new PropertyMetadata(Brushes.RosyBrown));

        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverForegroundProperty =
            DependencyProperty.Register("MouseOverForeground", typeof(Brush), typeof(FButton), new PropertyMetadata(Brushes.WhiteSmoke));

        public Brush MouseOverForeground
        {
            get { return (Brush)GetValue(MouseOverForegroundProperty); }
            set { SetValue(MouseOverForegroundProperty, value); }
        }

        public static readonly DependencyProperty FIconProperty =
            DependencyProperty.Register("FIcon", typeof(string), typeof(FButton), new PropertyMetadata("\ue604"));

        public string FIcon
        {
            get { return (string)GetValue(FIconProperty); }
            set { SetValue(FIconProperty, value); }
        }

        public static readonly DependencyProperty FIconSizeProperty =
            DependencyProperty.Register("FIconSize", typeof(int), typeof(FButton), new PropertyMetadata(20));

        public int FIconSize
        {
            get { return (int)GetValue(FIconSizeProperty); }
            set { SetValue(FIconSizeProperty, value); }
        }

        public static readonly DependencyProperty FIconMarginProperty =
            DependencyProperty.Register("FIconMargin", typeof(Thickness), typeof(FButton),
                new PropertyMetadata(new Thickness(0, 1, 3, 1)));

        public Thickness FIconMargin
        {
            get { return (Thickness)GetValue(FIconMarginProperty); }
            set { SetValue(FIconMarginProperty, value); }
        }

        public static readonly DependencyProperty AllowsAnimationProperty =
            DependencyProperty.Register("AllowsAnimation", typeof(bool), typeof(FButton), new PropertyMetadata(true));

        public bool AllowsAnimation
        {
            get { return (bool)GetValue(AllowsAnimationProperty); }
            set { SetValue(AllowsAnimationProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(FButton), new PropertyMetadata(new CornerRadius(2)));

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ContentDecorationsProperty =
            DependencyProperty.Register("ContentDecorations", typeof(TextDecorationCollection), typeof(FButton), new PropertyMetadata(null));

        public TextDecorationCollection ContentDecorations
        {
            get { return (TextDecorationCollection)GetValue(ContentDecorationsProperty); }
            set { SetValue(ContentDecorationsProperty, value); }
        }

        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof(bool), typeof(FButton),
                new PropertyMetadata(false));

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        static FButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FButton), new FrameworkPropertyMetadata(typeof(FButton)));
        }

    }
}
