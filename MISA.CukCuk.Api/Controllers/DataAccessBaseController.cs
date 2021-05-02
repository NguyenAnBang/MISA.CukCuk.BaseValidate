using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.CukCuk.Core.Interfaces.Repositories;
using MISA.CukCuk.Core.Interfaces.Services;
using MISA.CukCuk.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Api.Controllers
{
    [Route("api/v2/[controller]")]
    [ApiController]
    public class DataAccessBaseController<MISAEntity>  : ControllerBase where MISAEntity : class
    {
        IDataAccessBaseRepository<MISAEntity> _dataAccessBaseRepository;
        IDataAccessBaseServices<MISAEntity> _dataAccessBaseServices;

        public DataAccessBaseController(IDataAccessBaseRepository<MISAEntity> dataAccessBaseRepository, IDataAccessBaseServices<MISAEntity> dataAccessBaseServices)
        {
            _dataAccessBaseRepository = dataAccessBaseRepository;
            _dataAccessBaseServices = dataAccessBaseServices;
        }

        /// <summary>
        /// Lấy tất cả bản ghi từ database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = _dataAccessBaseServices.GetAll();
            if (entities.Count() > 0) return Ok(entities);
            else return NoContent();
        }

        /// <summary>
        /// Lấy bản ghi từ database theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{entityid}")]
        public IActionResult GetGetCustomerById(Guid entityid)
        {
            var entity = _dataAccessBaseServices.GetCustomerById(entityid);
            if (entity != null)
            {
                return Ok(entity);
            }
            else
            {
                return NoContent();
            }
        }
        /// <summary>
        /// Lấy bản ghi theo phân trang
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet("Paging")]

        public IActionResult GetPaging(int pageIndex, int pageSize)
        {
            var entities = _dataAccessBaseServices.GetPaging(pageIndex, pageSize);
            if (entities.Count() > 0)
            {
                return Ok(entities);
            }
            else
            {
                return NoContent();
            }
        }

        /// <summary>
        /// Insert 1 bản ghi vào database 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post([FromBody] MISAEntity entity)
        {
            var rowsAffect = _dataAccessBaseServices.Post(entity);

            if (rowsAffect > 0) return Ok();
            else return NoContent();
        }

        /// <summary>
        /// Update 1 bản ghi vào database (sau khi validate dữ liệu trong service)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] MISAEntity entity)
        {
            //customer.CustomerId = id;
            var properties = typeof(MISAEntity).GetProperties();
            var tableName = typeof(MISAEntity).Name;
            foreach (var item in properties)
            {
                if(item.Name == $"{tableName}id")
                {
                    item.SetValue(entity, id);
                }
            }
            var rowsAffect = _dataAccessBaseServices.Put(entity);
            if (rowsAffect > 0) return Ok(rowsAffect);
            else return NoContent();
        }

        /// <summary>
        /// Xóa 1 bản ghi trong database 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{entityid}")]
        public IActionResult Delete(Guid entityid)
        {
            var rowsAffect = _dataAccessBaseServices.Delete(entityid);
            if (rowsAffect > 0) return Ok(rowsAffect);
            else return NoContent();
        }
        // TODO: thêm base validate không quá 20 ký tự
        // TODO: Tìm hiểu Base check trùng mã khách hàng
    }

}

