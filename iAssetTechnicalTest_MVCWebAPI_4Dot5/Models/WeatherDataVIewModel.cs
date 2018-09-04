using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iAssetTechnicalTest_MVCWebAPI_4Dot5.Models
{
    public class WeatherDataVIewModel
    {
        public string Country { get; set; }
        public string City { get; set; }
        public Wind Wind { get; set; }
        public int Visibility { get; set; }
        public Clouds Clouds { get; set; }
        public double Temprature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }

    }
}