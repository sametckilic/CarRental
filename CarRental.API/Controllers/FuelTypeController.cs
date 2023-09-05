using CarRental.Business.Abstract;
using CarRental.Core.Utilities.Results;
using CarRental.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelTypeController : ControllerBase
    {
        private IFuelTypeService _FuelTypeService;

        public FuelTypeController(IFuelTypeService FuelTypeService)
        {
            _FuelTypeService = FuelTypeService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _FuelTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _FuelTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


    }
}
