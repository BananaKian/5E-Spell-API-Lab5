using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using _5E_API.Data;
using System.Net.Http.Json;

namespace _5E_API.Service
{
    public class FifthEAPIService : I5eAPIService
    {
        private HttpClient httpClient;

        public FifthEAPIService() 
        { 
            httpClient = new HttpClient();
        }

        public async Task<Spells> GetSpell(string spellIndex)
        {
            var apiResponse = await httpClient.GetFromJsonAsync<JsonElement>($"https://www.dnd5eapi.co/api/spells/{spellIndex}");

            return new Spells
            {
                Name = $"{apiResponse.GetProperty("name")}",
                Description = $"{apiResponse.GetProperty("desc")}"
            };
        }
    }
}
