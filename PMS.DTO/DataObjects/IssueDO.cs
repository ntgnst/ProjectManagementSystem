using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class IssueDO
    {
        public IssueDO()
        {
            CommentDOList = new List<CommentDO>();
            FileDOList = new List<FileDO>();
            TaskSubTaskSubTaskDOList = new List<TaskSubTaskDO>();
            TaskSubTaskDOList = new List<TaskSubTaskDO>();
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

        public PriorityDO PriorityDO { get; set; }
        public ProjectDO ProjectDO { get; set; }
        public UserDO ReporterDO { get; set; }
        public StatusDO StatusDO { get; set; }
        public List<CommentDO> CommentDOList { get; set; }
        public List<FileDO> FileDOList { get; set; }
        public List<TaskSubTaskDO> TaskSubTaskSubTaskDOList { get; set; }
        public List<TaskSubTaskDO> TaskSubTaskDOList { get; set; }
    }
}
