using Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PaintPortal.APIS
{
    public class APICalls : IApiCalls
    {
        private readonly HttpClient _httpClient;
        private readonly string _urlAPI;


        public APICalls(HttpClient httpClient,IConfiguration configuration)
        {
            _httpClient = httpClient;
            _urlAPI = configuration["Services:ApiURI"];
        }

        public async Task<IEnumerable<Adress>> GetAdressAsync()
        {
            var response = await _httpClient.GetAsync($"{_urlAPI}/Adress");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                IEnumerable<Adress> adresses = JsonConvert.DeserializeObject<IEnumerable<Adress>>(content);

                return adresses;
            }

            throw new HttpRequestException($"Invalid status code Adresses in the HttpResponseMessage: {response.StatusCode}.");
        }

        public async Task<IEnumerable<PaintHouse>> GetPaintHouseAsync()
        {
            var response = await _httpClient.GetAsync($"{_urlAPI}/PaintHouse");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                IEnumerable<PaintHouse> paintHouses = JsonConvert.DeserializeObject<IEnumerable<PaintHouse>>(content);

                return paintHouses;
            }

            throw new HttpRequestException($"Invalid status code PaintHouses in the HttpResponseMessage: {response.StatusCode}.");
        }

        public async Task<IEnumerable<Person>> GetPeopleAsync()
        {
            var response = await _httpClient.GetAsync($"{_urlAPI}/People");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                IEnumerable<Person> people = JsonConvert.DeserializeObject<IEnumerable<Person>>(content);

                return people;
            }

            throw new HttpRequestException($"Invalid status code People in the HttpResponseMessage: {response.StatusCode}.");
        }
    }


}
