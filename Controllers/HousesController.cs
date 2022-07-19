using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using gldotnet.Models;
using gldotnet.Services;

namespace gldotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _hs;
        public HousesController(HousesService hs)
        {
            _hs = hs;
        }
        [HttpGet]
        public ActionResult<List<House>> Get()
        {
            try
            {
                List<House> houses = _hs.GetHouses();
                return Ok(houses);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpGet("{id}")]
        public ActionResult<House> Get(string id)
        {
            try
            {
                House house = _hs.GetHouses(id);
                return Ok(house);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public ActionResult<House> Create([FromBody] House houseData)
        {
            try
            {
                House newHouse = _hs.CreateHouse(houseData);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult<House> Edit(string id, [FromBody] House houseData)
        {
            try
            {
                House updated = _hs.UpdateHouse(id, houseData);
                return Ok(updated);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<House> Delete(string id)
        {
            try
            {
                House deleted = _hs.DeleteHouse(id);
                return Ok(deleted);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}