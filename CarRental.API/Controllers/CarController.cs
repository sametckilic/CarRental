using CarRental.Business.Abstract;
using CarRental.Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService productService)
        {
            _carService = productService;
        }

        [HttpGet("GetAllDetails")]
        public IActionResult GetAllDetails() {
            var result = _carService.GetAllDetails();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);    
        }
    }
}
