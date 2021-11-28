using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult> AddAdult([FromBody] Adult adult)
        {
            try
            {
                await adultsData.Add(adult);
                return Ok();
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
