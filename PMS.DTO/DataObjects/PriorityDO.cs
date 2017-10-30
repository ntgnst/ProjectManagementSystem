using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class PriorityDO
    {
        public PriorityDO()
        {
            IssueDOList = new List<IssueDO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public List<IssueDO> IssueDOList { get; set; }
    }
}
