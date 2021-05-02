using MISA.CukCuk.Core.AttributeCustom;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.CukCuk.Core.Entities
{
    public class CustomerGroup
    {
        [RequiredField]
        public Guid CustomerGroupId { get; set; }
        [RequiredField]
        public string CustomerGroupName { get; set; }

        //public long? ParentId { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
    }
}
