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

        [HttpGet("{city}", Name = "get-by-city")]
        public ActionResult GetAddressByCity(string city)
        {
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            var JSONString = System.IO.File.ReadAllText(contentRootPath + "/Data/SampleData.json");
            SampleData sampleData = JsonConvert.DeserializeObject<SampleData>(JSONString);
            var results = sampleData.data.Where(p => p.City.ToUpperInvariant() == city.ToUpperInvariant()).GroupBy(a => a.City, (key, g) => new { city = key, address = g.ToList() });

            return Ok(results);
        }
    }
}