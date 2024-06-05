# Creating a Bubble Chart to Explore Ball Sizes and Weights Across Different Sports

# Description:

This article demonstrates how to use [Syncfusion's .NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) control to create a bubble chart to display the dimensions and weights of balls used in various sports. Balls vary significantly across sports, each having unique sizes and weights, which can be effectively visualized using this chart. This control is compatible with desktop platforms such as Windows and Mac, as well as mobile platforms like Android and iOS.

# Overview

[Bubble chart](https://help.syncfusion.com/maui/cartesian-charts/bubble) is a data visualization that displays multiple circles (bubbles) in a two-dimensional plot.

# Customization

We can enhance the appearance of the series by providing the [Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_Fill),[PaletteBrushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes) , [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html#Syncfusion_Maui_Charts_BubbleSeries_Stroke) and [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_StrokeWidth) properties. 

# Tooltip Customization

The TooltipTemplate property allows users to define a custom layout and content for the tooltip. It specifies a data template that determines how the tooltip appears and what information it displays.

![Bubble chart with customzised tooltip in MAUI Chart](../../../bubble.mp4)


# Troubleshooting

## Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name and build the project.

For a step-by-step procedure, refer to the [different sports ball measurements blog]().