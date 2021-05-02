using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Enums;
using MISA.CukCuk.Core.Interfaces.Repositories;
using MISA.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.CukCuk.Core.Services
{
    public class CustomerGroupServices : DataAccessBaseServices<CustomerGroup>, ICustomerGroupServices
    {
        ICustomerGroupRepository _customerGroupRepository;
        public CustomerGroupServices(ICustomerGroupRepository customerGroupRepository) : base(customerGroupRepository)
        {
            _customerGroupRepository = customerGroupRepository;
        }

        //protected override void Validate(CustomerGroup entity, HttpType http)
        //{
        //    base.Validate(entity, http);
        //}
        
    }
}
