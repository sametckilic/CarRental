﻿using CarRental.Business.Abstract;
using CarRental.Business.BusinessAspect.Autofac;
using CarRental.Business.ValidationRules.FluentValidation;
using CarRental.Core.Aspects.Autofac.Validation;
using CarRental.Core.Utilities.Results;
using CarRental.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

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
        public IActionResult GetAllDetails()
        {
            var result = _carService.GetAllDetails();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetAllDetailsById")]
        public IActionResult GetAllDetailsById(int id)
        {
            var result = _carService.GetAllDetailsById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAllDetailsByBrandId")]
        public IActionResult GetAllDetailsByBrandId(int brandId)
        {
            var result = _carService.GetAllDetailsByBrandId(brandId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAllDetailsByColorId")]
        public IActionResult GetAllDetailsByColorId(int colorId)
        {
            var result = _carService.GetAllDetailsByColorId(colorId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetAllDetailsByFuelTypeId")]
        public IActionResult GetAllDetailsByFuelTypeId(int fuelTypeId)
        {
            var result = _carService.GetAllDetailsByBrandId(fuelTypeId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAllDetailsByGearTypeId")]
        public IActionResult GetAllDetailsByGearTypeId(int gearTypeId)
        {
            var result = _carService.GetAllDetailsByGearTypeId(gearTypeId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetByBrandId")]
        public IActionResult GetByBrandId(int brandId)
        {
            var result = _carService.GetAllByBrandId(brandId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("GetByColorId")]
        public IActionResult GetByColorId(int colorId)
        {
            var result = _carService.GetAllByColorId(colorId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("GetByFuelTypeId")]
        public IActionResult GetByFuelTypeId(int fuelTypeId)
        {
            var result = _carService.GetAllByFuelTypeId (fuelTypeId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("GetByGearTypeId")]
        public IActionResult GetByGearTypeId(int gearTypeId)
        {
            var result = _carService.GetAllByFuelTypeId(gearTypeId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("GetByDailyPrice")]
        public IActionResult GetByDailyPrice(decimal min = 0, decimal max = 999999)
        {
            var result = _carService.GetByDailyPrice(min, max);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetByMonthlyPrice")]
        public IActionResult GetByMonthlyPrice(decimal min = 0, decimal max = 999999)
        {
            var result = _carService.GetByMonthlyPrice(min, max);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        // POST REQUESTS


        [HttpPost("Add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        // UPDATE REQUESTS

        [HttpPut("Update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        // DELETE REQUSTS

        [HttpDelete("Delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
