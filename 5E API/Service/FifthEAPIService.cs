using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using _5E_API.Data;
using System.Net.Http.Json;
using static System.Console;

namespace _5E_API.Service
{
    public class FifthEAPIService
    {
        private HttpClient httpClient;

        public FifthEAPIService() 
        { 
            httpClient = new HttpClient();
        }

        public async Task<string> GetSpell(string indx)
        {
            var apiResponse = await httpClient.GetFromJsonAsync<JsonElement>($"https://www.dnd5eapi.co/api/spells/{indx}");

            string name = $"{apiResponse.GetProperty("name")}";
            string description = $"{apiResponse.GetProperty("desc")}";
            string range = $"The range of the spell is {apiResponse.GetProperty("range")}";
            string duration = $"Duration: {apiResponse.GetProperty("duration")}";
            string action = $"Casting time: {apiResponse.GetProperty("casting_time")}";


            WriteLine(name);
            WriteLine(description);
            WriteLine(range);
            WriteLine(duration);
            WriteLine(action);

            return name;
                
            
        }
    }
}
