using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : Controller
    {
        private readonly IVehicleService _VehicleService;
        private readonly IConfiguration _config;


        public VehiclesController(IVehicleService vehicleService, IConfiguration config)
        {
            _VehicleService = vehicleService;
            _config = config;
        }

        [HttpGet]
        [Route("GetByArea")]
        public async Task<IActionResult> GetByArea(int idArea)
        {
            try
            {
                var Vehicles = await _VehicleService.GetByArea(idArea);
                return Vehicles.Any() ? Ok(Vehicles) : BadRequest("No Vehicles found for area");
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
                var Vehicles = await _VehicleService.GetByCity(idCity);
                return Vehicles.Any() ? Ok(Vehicles) : BadRequest("No Vehicles found for area");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetByLocation")]
        public async Task<IActionResult> GetByLocation(int idLocation)
        {
            try
            {
                var Vehicles = await _VehicleService.GetByLocation(idLocation);
                return Vehicles.Any() ? Ok(Vehicles) : BadRequest("No Vehicles found for Location");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
