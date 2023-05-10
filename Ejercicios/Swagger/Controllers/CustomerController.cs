using AutoMapper;
using Data;
using Infraestructure.DTO.CustomerDTOs;
using Infraestructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Services.CustomerServices;

namespace Swagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private IMapper mapper;

        private readonly ICustomerService customerSV;

        public CustomerController(ILogger<CustomerController> logger, IMapper _mapper, ICustomerService _customerSV)
        {
            _logger = logger;
            mapper = _mapper;
            customerSV = _customerSV;
        }

        #region GET CUSTOMER
        [HttpGet("GetListCustomer")]
        [ProducesResponseType(typeof(List<CustomerMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListCustomerAsync()
        {
            var result = await customerSV.GetListAsync();
            var resultMap = mapper.Map<List<CustomerMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetCustomerById/{id}")]
        [ProducesResponseType(typeof(CustomerMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomerByIdAsync(
            Guid id)
        {
            var result = await customerSV.GetByIdAsync(id);
            var resultMap = mapper.Map<CustomerMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region ADD_EDIT CUSTOMER
        [HttpPost("AddEditCustomer")]
        [ProducesResponseType(typeof(CustomerMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddEditCustomerAsync(
            [FromBody] CustomerPostDTO customer)
        {
            var result = await customerSV.AddEditAsync(mapper.Map<Customer>(customer));
            var resultMap = mapper.Map<CustomerMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region DELETE CUSTOMER
        [HttpDelete("DeleteCustomerById/{id}")]
        [ProducesResponseType(typeof(CustomerMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteCustomerByIdAsync(
            Guid id)
        {
            var result = await customerSV.DeleteAsync(id);
            var resultMap = mapper.Map<CustomerMiniDTO>(result);

            return Ok(resultMap);
        } 
        #endregion
    }
}
