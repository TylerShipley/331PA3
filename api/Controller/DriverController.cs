using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.DataAccess;
using Microsoft.AspNetCore.Cors;

namespace api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {

        // GET: api/Driver
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Drivers> Get()
        {
            DriverDataAccess da = new DriverDataAccess();
            List<Drivers> drivers = new List<Drivers>();
            drivers = da.GetAll();
            return drivers;
        }

        // GET: api/Driver/5
        [EnableCors("OpenPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public List<Drivers> Get(int id)
        {
            List<Drivers> drivers  = new List<Drivers>();
            DriverDataAccess cda = new DriverDataAccess();
            drivers = cda.GetAll();
            return drivers;
        }

        // POST: api/Driver
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Driver/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Driver/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
