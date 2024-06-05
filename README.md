# Creating a Scatter Chart to Explore Ball Sizes and Weights Across Different Sports

# Description:

This article demonstrates how to use [Syncfusion's .NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) control to create a scatter chart to display the dimensions and weights of balls used in various sports. Balls vary significantly across sports, each having unique sizes and weights, which can be effectively visualized using this chart. This control is compatible with desktop platforms such as Windows and Mac, as well as mobile platforms like Android and iOS.

# Overview

[scatter chart](https://help.syncfusion.com/maui/cartesian-charts/scatter) is a data visualization that displays multiple circles in a two-dimensional plot.

# Customization

We can enhance the appearance of the series by providing the [Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_Fill), [PaletteBrushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes) , [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ScatterSeries.html#Syncfusion_Maui_Charts_ScatterSeries_Stroke), and [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_StrokeWidth) properties. 

### Display grid lines
The ShowMajorGridLines and ShowMinorGridLines properties control the visibility of the major and minor grid lines on the chart axis, respectively. When set to true, these properties display grid lines along the major and minor tick marks of the axis, providing visual reference points to help interpret the data plotted on the chart. When set to false, the grid lines are hidden. Adjusting these properties allows you to control the appearance of the grid lines based on your specific chart design and requirements

### Tooltip Customization

The TooltipTemplate property allows users to define a custom layout and content for the tooltip. It specifies a data template that determines how the tooltip appears and what information it displays.

![Scatter chart with customzised tooltip in MAUI Chart](https://github.com/SyncfusionExamples/Creating-a-Bubble-Chart-to-Explore-Ball-Sizes-and-Weights-Across-Different-Sports/assets/154403270/83200f1e-f499-41ab-bb49-320b2741be0a)



# Troubleshooting

### Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name and build the project.

For a step-by-step procedure, refer to the [different sports ball measurements blog]().
