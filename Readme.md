<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/190573811/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828683)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/GanttControlDemoApp/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/GanttControlDemoAppVB/MainWindow.xaml))
* [ProjectTaskViewModel.cs](./CS/GanttControlDemoApp/ProjectTaskViewModel.cs) (VB: [ProjectTaskViewModel.vb](./VB/GanttControlDemoAppVB/ProjectTaskViewModel.vb))
<!-- default file list end -->
# How to retrieve Gantt tasks' predecessor links using the PredecessorLinksSelector


This example demonstrates how to retrieve Gantt tasks' predecessor links using the **PredecessorLinksSelector**. 

In this example, each Gantt task stores links to its predecessors in the **GanttTask.Tag** property. The property value is a string that contains the predecessors task Id's separated by semicolon (`;`). 
The *PredecessorLinksSelector* exposes the `SelectLinks(object item)` method. This method's parameter is a processed Gantt task. The method gets the task's **Tag** property value, parses it, and returns a collection of the **GanttPredecessorLink** objects for each task.
