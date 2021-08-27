<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572073/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T309141)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[CustomColorizer.cs](./CS/CustomColorizerSample/CustomColorizer.cs) (VB: [CustomColorizer.vb](./VB/CustomColorizerSample/CustomColorizer.vb))**
* [MainWindow.xaml](./CS/CustomColorizerSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomColorizerSample/MainWindow.xaml))
<!-- default file list end -->
# How to implement the custom Tree Map Colorizer


This example demonstrates how to implement the custom Tree Map colorizer.


<h3>Description</h3>

To implement the custom colorizer, inherit the&nbsp;<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfTreeMapTreeMapColorizerBasetopic">TreeMapColorizerBase</a>&nbsp;or its descendant class, and override the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfTreeMapTreeMapColorizerBase_GetItemColortopic">GetItemColor</a><strong>&nbsp;</strong>method.&nbsp;<br>Sent as parameters,&nbsp;<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfTreeMapTreeMapItemtopic">TreeMapItem</a>&nbsp;and&nbsp;<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfTreeMapTreeMapItemGroupInfotopic">TreeMapItemGroupInfo</a>&nbsp;objects contain all the required information to colorize items.

<br/>


