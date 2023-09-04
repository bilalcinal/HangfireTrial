using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HangfireTrial.Interfaces;
using HangfireTrial.Service;

namespace HangfireTrial.Classes
{
    public class WeatherReports
    {
            
        public class WeatherReport : IWeatherReport
        {
            public static readonly string[] Summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
            private ICoreService service;

            public WeatherReport(ICoreService service)
            {
                this.service = service;
            }

            public void ReportWeather()
            {
                var array = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
                foreach (var item in array)
                {
                    Debug.Write(item.Date + " | ");
                    Debug.Write(item.TemperatureC + " | ");
                    Debug.WriteLine(item.Summary);
                    Debug.WriteLine("".PadRight(40, '*'));
                }
            }
            public void ReportWeather2()
            {
                var array = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
                foreach (var item in array)
                {
                    //if (item.TemperatureC > 50) { throw new Exception("OverFlow Hottt!"); }
                    Debug.Write("2." + item.Date + " | ");
                    Debug.Write("2." + item.TemperatureC + " | ");
                    Debug.WriteLine("2." + item.Summary);
                    Debug.WriteLine("".PadRight(40, '*'));
                }
            }
            
        }
    
    }

}
