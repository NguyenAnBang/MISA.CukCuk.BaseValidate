using MISA.CukCuk.Core.AttributeCustom;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.CukCuk.Core.Entities
{
    public class CustomerGroup
    {
        /// <summary>
        /// Khóa chính nhóm khách hàng
        /// </summary>
        [RequiredField]
        public Guid CustomerGroupId { get; set; }
        /// <summary>
        /// Tên nhóm khách hàng
        /// </summary>
        [RequiredField]
        public string CustomerGroupName { get; set; }

        //public long? ParentId { get; set; }
        /// <summary>
        /// Mô tả
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Tạo bởi
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Ngày thay đổi
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Thay đổi bởi
        /// </summary>
        public string ModifiedBy { get; set; }
    }
}
