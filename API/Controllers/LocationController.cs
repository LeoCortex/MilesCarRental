using Microsoft.AspNetCore.Mvc;
using Models.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {

        private readonly ILocationService _locationService;
        private readonly IConfiguration _config;


        public LocationController(ILocationService locationService, IConfiguration config)
        {
            _locationService = locationService;
            _config = config;
        }

        [HttpGet]
        [Route("GetByArea")]
        public async Task<IActionResult> GetByArea(int idArea)
        {
            try
            {
                var locations = await _locationService.GetByArea(idArea);
                return locations.Any() ? Ok(locations) : BadRequest("No locations found for area");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetBycity")]
        public async Task<IActionResult> GetByCity(int idCity)
        {
            try
            {
                var locations = await _locationService.GetByCity(idCity);
                return locations.Any() ? Ok(locations) : BadRequest("No locations found for area");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetByVehicle")]
        public async Task<IActionResult> GetByVehicle(int idVehicle)
        {
            try
            {
                var locations = await _locationService.GetByVehicle(idVehicle);
                return locations.Any() ? Ok(locations) : BadRequest("No locations found for Vehicle");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
