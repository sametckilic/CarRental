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
    public class GearTypeController : ControllerBase
    {
        private IGearTypeService _GearTypeService;

        public GearTypeController(IGearTypeService GearTypeService)
        {
            _GearTypeService = GearTypeService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _GearTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _GearTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
