using AutoMapper;
using Gemography.Integration.Models;
using Gemography.Integration.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gemography.Integration.GetRemoteData
{

    public class RemoteDataManager : IRemoteData
    {
        private readonly RemoteSettings _remoteDataSetting;
        private readonly IMapper _mapper;

        public RemoteDataManager(RemoteSettings remoteDataSetting, IMapper mapper)
        {
            _remoteDataSetting = remoteDataSetting;
            _mapper = mapper;
        }



        public async Task <List<ItemsResponse>> GetRepositoriesData(string queryParams="")
        {


            string url = _remoteDataSetting.BaseUrl + _remoteDataSetting.SearchEndPoint;
            url += queryParams;
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "http://developer.github.com/v3/#user-agent-required");

            //object payload
            try
            {
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    MainResponse dataResponse = JsonSerializer.Deserialize<MainResponse>(result);
                    return  _mapper.Map<List<ItemsResponse>>(dataResponse?.items);
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
