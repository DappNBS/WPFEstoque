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
 * │CreatTime	: 2019/3/7 17:20:35													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © NBS-Tech Team 2019.All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */
namespace UrusUI
{
    public class FMenuItem : MenuItem
    {



        static FMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FMenuItem), new FrameworkPropertyMetadata(typeof(FMenuItem)));
        }
    }
}
