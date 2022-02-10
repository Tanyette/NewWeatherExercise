﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Net.Http; 

namespace WeatherExercise
{
    class WeatherMap
    {

        public static double GetTemp(string apiCall) 
        {

            var client = new HttpClient();

            var response = client.GetStringAsync(apiCall).Result;

            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString()) ;
            
            return temp ;

        } 


    }
}
