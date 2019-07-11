using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RiskFirstTest.Models;

namespace RiskFirstTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public AddressController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("get-by-city", Name = "GetByCity")]
        public ActionResult GetAddressByCity()
        {
            // List<Address> cities = new List<Address>();

            string contentRootPath = _hostingEnvironment.ContentRootPath;
            var JSONString = System.IO.File.ReadAllText(contentRootPath + "/Data/SampleData.json");
            var sampleData = JsonConvert.DeserializeObject<SampleData>(JSONString);
            // var cities = JsonConvert.DeserializeObject()

            return Ok(sampleData);
        }
    }
}