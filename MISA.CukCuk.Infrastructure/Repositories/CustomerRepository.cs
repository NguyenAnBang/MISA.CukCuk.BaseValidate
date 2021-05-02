using Microsoft.Extensions.Configuration;
using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using Dapper;
using MySqlConnector;
using System.Data;
using MISA.CukCuk.Core.Enums;

namespace MISA.CukCuk.Infrastructure.Repositories
{
    public class CustomerRepository : DataAccessBaseRepository<Customer>, ICustomerRepository
    {
        /// <summary>
        /// Check trùng mã khách hàng
        /// </summary>
        /// <param name="customerCode"></param>
        /// <returns></returns>
        public bool CheckDuplicateCustomerCode(string customerCode, Guid customerId, HttpType http)
        {
            using (dbConnection = new MySqlConnection(connectionString))
            {
                var sqlCommand = "";
                DynamicParameters dynamicParameters = new DynamicParameters();
                if (http == HttpType.POST)
                {
                    sqlCommand = "Proc_CheckCustomerCodeExists";
                    dynamicParameters.Add("@m_CustomerCode", customerCode);
                }
                else
                {
                    //Check trùng mã khách hàng
                    sqlCommand = "Proc_H_CheckCustomerCodeExists";
                    dynamicParameters.Add("@customerCode", customerCode);
                    dynamicParameters.Add("@customerId", customerId);
                }
                var Exists = dbConnection.QueryFirstOrDefault<bool>(sqlCommand, param: dynamicParameters, commandType: CommandType.StoredProcedure);
                return Exists;
            }
        }
        /// <summary>
        /// Check trùng email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckDuplicateEmail(string email)
        {
            using (dbConnection = new MySqlConnection(connectionString))
            {
                //Check trùng email
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@m_Email", email);
                var Exists = dbConnection.QueryFirstOrDefault<bool>("Proc_CheckEmailExists", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                return Exists;
            }
        }
        /// <summary>
        /// Check trùng số điện thoại
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public bool CheckDuplicatePhoneNumber(string phoneNumber)
        {
            using (dbConnection = new MySqlConnection(connectionString))
            {
                //Check trùng số điện thoại
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@m_PhoneNumber", phoneNumber);
                var Exists = dbConnection.QueryFirstOrDefault<bool>("Proc_CheckPhoneNumberExists", param: dynamicParameters, commandType: CommandType.StoredProcedure);
                return Exists;
            }
        }


    }
}
