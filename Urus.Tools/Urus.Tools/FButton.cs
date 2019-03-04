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
   
    public partial class FButton : Button
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



        #endregion
    }
}
