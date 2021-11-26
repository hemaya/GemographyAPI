using AspNetCore.ServiceRegistration.Dynamic;
using Gemography.Integration.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gemography.Integration.GetRemoteData
{
    /// <summary>
    /// 
    /// INotifier interface
    /// </summary>
    public interface IRemoteData : IScopedService
    {
        public Task<List<ItemsResponse>> GetRepositoriesData(string queryParams = "");
    }
}
