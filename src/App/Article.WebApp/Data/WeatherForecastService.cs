using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static Article.WebApp.Data.Models;

namespace Article.WebApp.Data
{
    public class WeatherForecastService
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        HttpClient client = new HttpClient();
        string baseUrl = "https://localhost:44301";
        public async Task<string> Authenticate()
        {
            var response = await client.PostAsJsonAsync($"https://localhost:44301/user/authenticate", new { Username = "raiden", Password = "32768a82236" });
            var token = await response.Content.ReadAsStringAsync();
            return token;
        }
    }
}
