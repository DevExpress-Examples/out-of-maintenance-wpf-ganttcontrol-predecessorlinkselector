Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm.Gantt
Imports DevExpress.Xpf.Gantt

Public Class ProjectTaskViewModel
    Public Sub New()
        Selector = New PredecessorLinksSelector()
        Tasks = New ObservableCollection(Of GanttTask) From {
            New GanttTask() With {
                .Id = 0,
                .Name = "Add a new feature",
                .StartDate = DateTime.Now.AddDays(-1),
                .FinishDate = DateTime.Now.AddDays(6)
            },
            New GanttTask() With {
                .Id = 1,
                .ParentId = 0,
                .Name = "Write the code",
                .StartDate = DateTime.Now.AddDays(-1),
                .FinishDate = DateTime.Now.AddDays(2)
            },
            New GanttTask() With {
                .Id = 2,
                .ParentId = 0,
                .Name = "Write the docs",
                .StartDate = DateTime.Now.AddDays(2),
                .FinishDate = DateTime.Now.AddDays(5),
                .Tag = "1"
            },
            New GanttTask() With {
                .Id = 3,
                .ParentId = 0,
                .Name = "Test the new feature",
                .StartDate = DateTime.Now.AddDays(2),
                .FinishDate = DateTime.Now.AddDays(5),
                .Tag = "1"
            },
            New GanttTask() With {
                .Id = 4,
                .ParentId = 0,
                .Name = "Release the new feature",
                .StartDate = DateTime.Now.AddDays(5),
                .FinishDate = DateTime.Now.AddDays(5),
                .Tag = "2;3"
            }
        }
    End Sub

    Public Property Tasks As ObservableCollection(Of GanttTask)
    Public Property Selector As PredecessorLinksSelector
End Class


Public Class PredecessorLinksSelector
    Implements IPredecessorLinksSelector


    Public Function SelectLinks(ByVal item As Object) As IEnumerable Implements IPredecessorLinksSelector.SelectLinks
        Dim task = CType(item, GanttTask)

        If task.Tag Is Nothing Then
            Return Nothing
        End If

        Dim links As String() = (CStr(task.Tag)).Split(";"c)
        Dim selectedLinks As List(Of Object) = New List(Of Object)()

        For Each link In links
            selectedLinks.Add(New GanttPredecessorLink() With {
                .PredecessorTaskId = Convert.ToInt32(link),
                .LinkType = PredecessorLinkType.FinishToStart
            })
        Next

        Return selectedLinks
    End Function
End Class
