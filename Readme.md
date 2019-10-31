<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/GanttControlDemoApp/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/GanttControlDemoAppVB/MainWindow.xaml))
* [ProjectTaskViewModel.cs](./CS/GanttControlDemoApp/ProjectTaskViewModel.cs) (VB: [ProjectTaskViewModel.vb](./VB/GanttControlDemoAppVB/ProjectTaskViewModel.vb))
<!-- default file list end -->
# How to retrieve Gantt tasks' predecessor links using the PredecessorLinksSelector


This example demonstrates how to retrieve Gantt tasks' predecessor links using the **PredecessorLinksSelector**. 

In this example, each Gantt task stores links to its predecessors in the **GanttTask.Tag** property. The property value is a string that contains the predecessors task Id's separated by semicolon (`;`). 
The *PredecessorLinksSelector* exposes the `SelectLinks(object item)` method. This method's parameter is a processed Gantt task. The method gets the task's **Tag** property value, parses it, and returns a collection of the **GanttPredecessorLink** objects for each task.
