using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : Controller
    {

        private readonly IAreaService _areaService;
        private readonly IConfiguration _config;


        public AreaController(IAreaService areaService, IConfiguration config)
        {
            _areaService = areaService;
            _config = config;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var locations = await _areaService.GetAll();
                return locations.Any() ? Ok(locations) : BadRequest("No areas found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int idArea)
        {
            try
            {
                var locations = await _areaService.GetById(idArea);
                return locations == null ? Ok(locations) : BadRequest("No areas found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
