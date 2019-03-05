using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;


/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: Urus.Tools
 * │ 
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author	: lanbery
 * │CreatTime	: 2019/3/4 23:05:17													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © NBS-Tech Team 2019.All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */
namespace UrusTools
{
   
    public class FButton : Button
    {
        static Color BLUE_COLOR = Color.FromArgb(255,91, 200, 255);
        static Color WITHE_COLOR = Color.FromArgb(255, 91, 200, 255);
        static Color BORDER_HILIGHT_COLOR = Color.FromRgb(230, 216, 145);
        static Color GRAY_BG_COLOR = Color.FromArgb(0, 252, 252, 252);
        static Color GOLD_FOREGROUND_COLOR = Color.FromArgb(0, 252, 146, 45);



        #region Pressed and hover Style
        public static readonly DependencyProperty PressedBackgroundProperty =
            DependencyProperty.Register("PressedBackground", typeof(Brush), typeof(FButton)
                , new PropertyMetadata(new SolidColorBrush(BLUE_COLOR)));
        public Brush PressedBackground
        {
            get { return (Brush)GetValue(PressedBackgroundProperty); }
            set { SetValue(PressedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty PressedForegroundProperty =
            DependencyProperty.Register("PressedForeground", typeof(Brush), typeof(FButton),
                new PropertyMetadata(new SolidColorBrush(WITHE_COLOR)));
        public Brush PressedForeground
        {
            get { return (Brush)GetValue(PressedForegroundProperty); }
            set { SetValue(PressedForegroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(FButton),
                new PropertyMetadata(new SolidColorBrush(GRAY_BG_COLOR)));

        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverForegroundProperty =
            DependencyProperty.Register("MouseOverForeground", typeof(Brush), typeof(FButton),
                new PropertyMetadata(new SolidColorBrush(GOLD_FOREGROUND_COLOR)));

        public Brush MouseOverForeground
        {
            get { return (Brush)GetValue(MouseOverForegroundProperty); }
            set { SetValue(MouseOverForegroundProperty, value); }
        }
        #endregion

        #region FIcon 
        public static readonly DependencyProperty FIconProperty =
            DependencyProperty.Register("FIcon", typeof(string), typeof(FButton),
                new PropertyMetadata("\ue604"));

        public string FIcon
        {
            get { return (string)GetValue(FIconProperty); }
            set { SetValue(FIconProperty, value); }
        }

        public static readonly DependencyProperty FIconSizeProperty =
            DependencyProperty.Register("FIconSize", typeof(int), typeof(FButton),
                new PropertyMetadata(20));

        public int FIconSize
        {
            get { return (int)GetValue(FIconSizeProperty); }
            set { SetValue(FIconSizeProperty, value); }
        }

        public static readonly DependencyProperty FIconMarginProperty =
            DependencyProperty.Register("FIconMargin", typeof(Thickness), typeof(FButton),
                new PropertyMetadata(new Thickness(0, 0, 0, 0)));

        public Thickness FIconMargin
        {
            get { return (Thickness)GetValue(FIconMarginProperty); }
            set { SetValue(FIconMarginProperty, value); }
        }

        public static readonly DependencyProperty AllowsAnimationProperty =
           DependencyProperty.Register("AllowsAnimation", typeof(bool), typeof(FButton), 
               new PropertyMetadata(true));

        public bool AllowsAnimation
        {
            get { return (bool)GetValue(AllowsAnimationProperty); }
            set { SetValue(AllowsAnimationProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(FButton), 
                new PropertyMetadata(new CornerRadius(2)));

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ContentDecorationsProperty =
            DependencyProperty.Register("ContentDecorations", typeof(TextDecorationCollection), typeof(FButton), 
                new PropertyMetadata(null));

        public TextDecorationCollection ContentDecorations
        {
            get { return (TextDecorationCollection)GetValue(ContentDecorationsProperty); }
            set { SetValue(ContentDecorationsProperty, value); }
        }

        public static readonly DependencyProperty FButtonOrientationProperty =
            DependencyProperty.Register("FBOrientation", typeof(string), typeof(FButton),
                new PropertyMetadata("Horizontal"));

        public string FBOrientation
        {
            get { return (string)GetValue(FButtonOrientationProperty); }
            set
            {
                SetValue(FButtonOrientationProperty, value);
            }
        }

        #endregion

        static FButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FButton), new FrameworkPropertyMetadata(typeof(FButton)));
        }
    }

    public enum FBOrientationType
    {
        Vertical,
        Horizontal
    }
}
