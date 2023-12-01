using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Lumbungku
{
    internal class Weather
    {
        private string _season;
        private int _rainfall;
        private int _temperature;
        private int _wind_speed;
        private int _wind_deg;
        private int _wind_gust;
        private int _humidity;
        private int _pressure;
        private int _sea_level;
        private int _ground_level;

        public Weather(float lat, float lon)
        {
            getWeather(lat, lon);
        }
        public void getWeather(float lat, float lon)
        {
            // latitude and longitude should be float with max 5 decimals
            string url = $"https://forecast9.p.rapidapi.com/rapidapi/forecast/{lat}/{lon}/summary/";
        }
    }
}
