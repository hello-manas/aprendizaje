using RESTExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTExample.Controllers
{
    public class WeatherController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<WeatherInfo> Get()
        {
            var weatherinfolist = new List<WeatherInfo>();
            for(int i=0;i<10;i++)
            {
                var weatherInfo = new WeatherInfo
                {
                    Location = $"Location = {i}",
                    Degree = i * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime()

                };
                weatherinfolist.Add(weatherInfo);
            }
        
            return weatherinfolist;
        }

        // GET api/<controller>/5
        public WeatherInfo Get(int id)
        {
            var weatherInfo = new WeatherInfo
            {
                Location = $"Location = {id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()

            };
            return weatherInfo;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}