using System;
using Newtonsoft.Json.Linq;
using System.IO;



namespace WeatherExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");

            string APIkey = JObject.Parse(key).GetValue("APIKEY").ToString();

            Console.WriteLine("please enter your zipcode:");
                
            var zipcode = Console.ReadLine();

            string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipcode}&units=imperial&appid={APIkey}"; 

            Console.WriteLine($"It is currently{WeatherMap.GetTemp(apiCall)} degrees F in your location.");
        }
    }
}
