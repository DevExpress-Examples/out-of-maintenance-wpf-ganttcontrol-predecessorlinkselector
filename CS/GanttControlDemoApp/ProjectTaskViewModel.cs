using DevExpress.Mvvm.Gantt;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GanttControlDemoApp {
    public class ProjectTaskViewModel {
        public ProjectTaskViewModel() {
            Selector = new PredecessorLinksSelector();
            Tasks = new ObservableCollection<GanttTask> {
                new GanttTask() {
                    Id = 0,
                    Name = "Add a new feature",
                    StartDate = DateTime.Now.AddDays(-1),
                    FinishDate = DateTime.Now.AddDays(6)//,
                },
                new GanttTask() {
                    Id = 1,
                    ParentId = 0,
                    Name = "Write the code",
                    StartDate = DateTime.Now.AddDays(-1),
                    FinishDate = DateTime.Now.AddDays(2)
                },
                new GanttTask() {
                    Id = 2,
                    ParentId = 0,
                    Name = "Write the docs",
                    StartDate = DateTime.Now.AddDays(2),
                    FinishDate = DateTime.Now.AddDays(5),
                    Tag = "1"
                },
                new GanttTask() {
                    Id = 3,
                    ParentId = 0,
                    Name = "Test the new feature",
                    StartDate = DateTime.Now.AddDays(2),
                    FinishDate = DateTime.Now.AddDays(5),
                    Tag = "1"
                },
                new GanttTask() {
                    Id = 4,
                    ParentId = 0,
                    Name = "Release the new feature",
                    StartDate = DateTime.Now.AddDays(5),
                    FinishDate = DateTime.Now.AddDays(5),
                    Tag = "2;3"
                }
            };
        }

        public ObservableCollection<GanttTask> Tasks { get; set; }
        public PredecessorLinksSelector Selector { get; set; }
    }
    public class PredecessorLinksSelector : DevExpress.Xpf.Gantt.IPredecessorLinksSelector {
        public IEnumerable SelectLinks(object item) {
            var task = (GanttTask)item;
            if (task.Tag == null) {
                return null;
            }
            string[] links = ((string)task.Tag).Split(';');
            List<object> selectedLinks = new List<object>();
            foreach (var link in links) {
                selectedLinks.Add(new GanttPredecessorLink() { PredecessorTaskId = Convert.ToInt32(link), LinkType = PredecessorLinkType.FinishToStart });
            }

            return selectedLinks;
        }
    }
}
