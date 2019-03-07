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
 * │CreatTime	: 2019/3/7 18:07:44													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © NBS-Tech Team 2019.All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */
namespace UrusUI
{
    public class FVButton : FButton
    {
        public static readonly DependencyProperty NormalBorderBrushProperty =
            DependencyProperty.Register("NormalBorderBrush", typeof(Brush), typeof(FVButton),
                new PropertyMetadata(FButton.SolidColor_Normal));

        public Brush NormalBorderBrush
        {
            get { return (Brush)GetValue(NormalBorderBrushProperty); }
            set { SetValue(NormalBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.Register("CheckedBorderBrush", typeof(Brush), typeof(FVButton),
                new PropertyMetadata(Brushes.Goldenrod));
        public Brush CheckedBorderBrush
        {
            get { return (Brush)GetValue(CheckedBorderBrushProperty); }
            set { SetValue(CheckedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderThicknessProperty =
            DependencyProperty.Register("CheckedBorderThickness", typeof(Thickness), typeof(FVButton),
                new PropertyMetadata(new Thickness(0, 0, 0, 2)));

        public Thickness CheckedBorderThickness
        {
            get { return (Thickness)GetValue(CheckedBorderThicknessProperty); }
            set { SetValue(CheckedBorderThicknessProperty, value); }
        }

        static FVButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FVButton), new FrameworkPropertyMetadata(typeof(FVButton)));
        }
    }
}
