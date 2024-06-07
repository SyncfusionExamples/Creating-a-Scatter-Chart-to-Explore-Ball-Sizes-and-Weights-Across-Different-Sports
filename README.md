# Creating a Scatter Chart to Explore Ball Sizes and Weights Across Different Sports

[scatter chart](https://help.syncfusion.com/maui/cartesian-charts/scatter) is a data visualization that displays multiple circles in a two-dimensional plot. In this scatter chart, we can use the [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ScatterSeries.html#Syncfusion_Maui_Charts_ScatterSeries_Stroke), [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_StrokeWidth), and [Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_Fill) properties to customize the appearance of the circles. These properties allow us to change the border color (Stroke), the thickness of the border (StrokeWidth), and the color inside the circles (Fill). This customization helps in making the data points more distinguishable and visually appealing.

## Display grid lines

The [ShowMajorGridLines](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ShowMajorGridLines) and [ShowMinorGridLines](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_ShowMinorGridLines) properties control the visibility of the major and minor grid lines on the chart axis, respectively. When set to true, these properties display grid lines along the major and minor tick marks of the axis, providing visual reference points to help interpret the data plotted on the chart. When set to false, the grid lines are hidden. Adjusting these properties allows you to control the appearance of the grid lines based on your specific chart design and requirements

## Tooltip Customization

The TooltipTemplate property allows users to define a custom layout and content for the tooltip. It specifies a data template that determines how the tooltip appears and what information it displays.

In this example, we will explore how to use [Syncfusion's .NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) control to create a scatter chart to display the dimensions and weights of balls used in various sports. Balls vary significantly across sports, each having unique sizes and weights, which can be effectively visualized using this chart.

![Scatter chart with customzised tooltip in MAUI Chart](https://github.com/SyncfusionExamples/Creating-a-Bubble-Chart-to-Explore-Ball-Sizes-and-Weights-Across-Different-Sports/assets/154403270/83200f1e-f499-41ab-bb49-320b2741be0a)



# Troubleshooting

### Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name and build the project.

For a step-by-step procedure, refer to the [different sports ball measurements blog]().