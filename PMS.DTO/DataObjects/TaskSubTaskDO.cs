using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class TaskSubTaskDO
    {
        public int TaskId { get; set; }
        public int SubTaskId { get; set; }

        public IssueDO SubTaskDO { get; set; }
        public IssueDO TaskDO { get; set; }
    }
}
