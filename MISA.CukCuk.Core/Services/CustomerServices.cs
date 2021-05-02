using DocumentFormat.OpenXml.CustomProperties;
using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Enums;
using MISA.CukCuk.Core.Exceptions;
using MISA.CukCuk.Core.Interfaces.Repositories;
using MISA.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.CukCuk.Core.Services
{
    public class CustomerServices : DataAccessBaseServices<Customer>, ICustomerServices
    {
        ICustomerRepository _customerRepository;
        public CustomerServices(ICustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
    

        protected override void CustomValidate(Customer entity, HttpType http)
        {
            
            //base.Validate(entity); //Nhận mã từ base
            if (entity is Customer) //Ép kiểu
            {
                var customer = entity as Customer;
                
                //CustomerException.CheckValidEmail(customer.Email);

                //Kiểm tra xem customerCode đã tồn tại chưa (phía server) (duplicate)
                var isCustomerCodeExists = _customerRepository.CheckDuplicateCustomerCode(customer.CustomerCode, customer.CustomerId, http);
                if (isCustomerCodeExists == true)
                    {
                        throw new CustomerException(Properties.Resources.Customer_Code_Exists_msg);
                    }

                ////Kiểm tra email đã tồn tại chưa (phía server)
                //var isEmailExists = _customerRepository.CheckDuplicateEmail(customer.Email);
                //if (isEmailExists == true)
                //{
                //    throw new CustomerException("Email đã tồn tại trên hệ thống!.");
                //}

                ////Kiểm tra số điện thoại đã tồn tại chưa (phía server)
                //var isPhoneNumberExists = _customerRepository.CheckDuplicatePhoneNumber(customer.PhoneNumber);
                //if (isPhoneNumberExists == true)
                //{
                //    throw new CustomerException("Số điện thoại đã tồn tại trên hệ thống!.");
                //}






            }
        }
    }
}
