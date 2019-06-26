using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace hitf5.Api.Client
{
    public class FactorialClient
    {
        private readonly HttpClient httpClient = new HttpClient();

        public FactorialClient(Uri endpoint)
        {
            httpClient.BaseAddress = endpoint;
        }

        public async Task<int> Get(int value)
        {
            var response = await httpClient.GetAsync($"/{value}");

            if(response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                if(Int32.TryParse(content, out var result))
                {
                    return result;
                }
            }

            throw new HttpRequestException($"Nepodařilo se získat výsledek výpočtu faktoriál pro hodnotu {value}.");
        }
    }
}
