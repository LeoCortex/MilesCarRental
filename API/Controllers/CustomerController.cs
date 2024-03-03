using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Repository.Domain.DTO;
using Models;
using Models.Services;
using DataAccess;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;
        private readonly IConfiguration _config;


        public CustomerController(ICustomerService CustomerService, IConfiguration config)
        {
            _customerService = CustomerService;
            _config = config;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var locations = await _customerService.GetAll();
                return locations.Any() ? Ok(locations) : BadRequest("No Customers found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int idCustomer)
        {
            try
            {
                var locations = await _customerService.GetById(idCustomer);
                return locations == null ? Ok(locations) : BadRequest("No Customers found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(CustomerDTO customer)
        {
            try
            {
                var locations = await _customerService.Add(customer);
                return Ok(locations) ?? throw new ApplicationException("Error creating Customer");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
