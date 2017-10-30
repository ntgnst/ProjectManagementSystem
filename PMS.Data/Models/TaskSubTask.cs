using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class TaskSubTask
    {
        public int TaskId { get; set; }
        public int SubTaskId { get; set; }

        public Issue SubTask { get; set; }
        public Issue Task { get; set; }
    }
}
