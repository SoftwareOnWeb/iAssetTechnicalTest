using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using iAssetTechnicalTest_MVCWebAPI_4Dot5.Models;
using iAssetTechnicalTest_MVCWebAPI_4Dot5.Service;

namespace iAssetTechnicalTest_MVCWebAPI_4Dot5.Controllers
{
    public class WeatherController : ApiController
    {

        IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
        [HttpGet]
        // GET api/values/5
        public WeatherDataVIewModel Get([FromUri] WeatherFilter weatherFilter)
        {
            if (ModelState.IsValid)
            {
                return _weatherService.GetWeatherByCityAndCountry(weatherFilter);
            }
            else
            {
                return new WeatherDataVIewModel();
            }
           
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
