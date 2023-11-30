using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Lumbungku
{
    public class CurrentWeather
    {
        public long LastUpdatedEpoch { get; set; }
        public string Last_Updated { get; set; }
        public double Temp_C { get; set; }
        public double Temp_F { get; set; }
        public int IsDay { get; set; }
        public WeatherCondition Condition { get; set; }
        public double Wind_Mph { get; set; }
        public double WindKph { get; set; }
        public int WindDegree { get; set; }
        public string WindDir { get; set; }
        public double PressureMb { get; set; }
        public double PressureIn { get; set; }
        public double PrecipMm { get; set; }
        public double PrecipIn { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        public double FeelsLikeC { get; set; }
        public double FeelsLikeF { get; set; }
        public double VisibilityKm { get; set; }
        public double VisibilityMiles { get; set; }
        public double Uv { get; set; }
        public double GustMph { get; set; }
        public double GustKph { get; set; }
    }
    public class WeatherCondition
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public int Code { get; set; }
    }
    internal class WeatherData
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public float Lat { get; set; }
        public float Lon { get; set; }
        public string TimeZoneId { get; set; }
        public long LocalTimeEpoch { get; set; }
        public string LocalTime { get; set; }
        public CurrentWeather Current { get; set; }

        public WeatherData()
        {
        }
        public async Task<string> getWeather(float lat = -7.7981396f, float lon = 110.3677f)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://weatherapi-com.p.rapidapi.com/current.json?q={lat}%2C{lon}"),
                Headers =
            {
                { "X-RapidAPI-Key", "da661eb308msh3026fd2370d171ap1c81c4jsn57bbcb0e83f1" },
                { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
            },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

    }
}
