using AspNetCore.ServiceRegistration.Dynamic;
using Gemography.Application.Components.GetLanguagesList;
using Gemography.Crosscut.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemography.Application.Components
{
    public interface IDataManager : IScopedService
    {
        Task<OutputResponse<List<GetLanguagesListQueryResult>>> GetLanguagesList();

    }
}
