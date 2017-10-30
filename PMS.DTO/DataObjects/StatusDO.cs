using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class StatusDO
    {
        public StatusDO()
        {
            IssueDOList = new List<IssueDO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public short Priority { get; set; }

        public List<IssueDO> IssueDOList { get; set; }
    }
}
