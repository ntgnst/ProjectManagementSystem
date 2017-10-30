using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class Issue
    {
        public Issue()
        {
            Comment = new HashSet<Comment>();
            File = new HashSet<File>();
            TaskSubTaskSubTask = new HashSet<TaskSubTask>();
            TaskSubTaskTask = new HashSet<TaskSubTask>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PriorityId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ReporterId { get; set; }
        public string FileString { get; set; }
        public int ProjectId { get; set; }
        public bool IsSubTask { get; set; }
        public DateTime? FinishedDate { get; set; }
        public DateTime? LastDate { get; set; }

        public Priority Priority { get; set; }
        public Project Project { get; set; }
        public User Reporter { get; set; }
        public Status Status { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<File> File { get; set; }
        public ICollection<TaskSubTask> TaskSubTaskSubTask { get; set; }
        public ICollection<TaskSubTask> TaskSubTaskTask { get; set; }
    }
}
