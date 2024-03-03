using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        private readonly IConfiguration _config;


        public CityController(ICityService CityService, IConfiguration config)
        {
            _cityService = CityService;
            _config = config;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var locations = await _cityService.GetAll();
                return locations.Any() ? Ok(locations) : BadRequest("No Citys found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int idCity)
        {
            try
            {
                var locations = await _cityService.GetById(idCity);
                return locations == null ? Ok(locations) : BadRequest("No Citys found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
