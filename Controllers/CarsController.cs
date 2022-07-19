using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using gldotnet.Models;
using gldotnet.Services;


namespace gldotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _cs;
        public CarsController(CarsService cs)
        {
            _cs = cs;
        }
        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            try
            {
                List<Car> cars = _cs.GetCars();
                return Ok(cars);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpGet("{id}")]
        public ActionResult<Car> Get(string id)
        {
            try
            {
                Car car = _cs.GetCar(id);
                return Ok(car);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public ActionResult<Car> Create([FromBody]Car carData)
        {
            try
            {
                Car created = _cs.CreateCar(carData);
                return Ok(carData);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult<Car> Edit(string id, [FromBody] Car carData)
        {
            try
            {
                Car updated = _cs.Update(carData);
                return Ok(updated);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Car> Delete(string id)
        {
            try
            {
                Car deleted = _cs.Delete(id);
                return Ok(deleted);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}