using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gemography.UnitTest.Factory
{
    public class Requester
    {
        protected readonly HttpClient TestClient;

        public Requester(HttpClient httpClient)
        {
            TestClient = httpClient;
        }


        public async Task<T> GetAsync<T>(string url)
        {
            var response = await TestClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseString);
        }

    }
}