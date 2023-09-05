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
    public class ColorController : ControllerBase
    {
        private IColorService _ColorService;

        public ColorController(IColorService ColorService)
        {
            _ColorService = ColorService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _ColorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _ColorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(Color Color)
        {
            var result = _ColorService.Add(Color);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("Update")]
        public IActionResult Update(Color Color)
        {
            var result = _ColorService.Update(Color);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(Color Color)
        {
            var result = _ColorService.Delete(Color);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
