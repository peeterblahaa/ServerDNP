using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerDNP.Models;
using ServerDNP.Permistence;

namespace ServerDNP.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AdultsController : ControllerBase
    {
        private readonly IAdultData adultsData;
        public AdultsController(IAdultData adultData) => this.adultsData = adultData;

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults()
        {
            try
            {
                IList<Adult> adults = await adultsData.GetAdults();
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult)
        {
            try
            {
                Adult added = await adultsData.Add(adult);
                return Created($"/{added.Id}", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        

        [HttpDelete]
        [Route("{id:int}")]

        public async Task<ActionResult> DeleteAdult([FromRoute] int id)
        {
            try
            {
                await adultsData.DeleteAdult(id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
    }
}
