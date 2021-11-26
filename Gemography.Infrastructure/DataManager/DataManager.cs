using AutoMapper;
using Gemography.Application.Components;
using Gemography.Application.Components.GetLanguagesList;
using Gemography.Crosscut.Localization;
using Gemography.Crosscut.Responses;
using Gemography.Integration.GetRemoteData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Gemography.Infrastructure.DataManager
{
    public class DataManager:IDataManager
    {
        private readonly IRemoteData _remoteData;
        private readonly IMapper _mapper;

        public DataManager(IRemoteData remoteData, IMapper mapper)
        {
            _remoteData = remoteData;
            _mapper = mapper;
        }

        public async Task<OutputResponse<List<GetLanguagesListQueryResult>>>  GetLanguagesList()
        {
            string queryParams = "?q=created>" + DateTime.Now.AddDays(-30).ToShortDateString() + "& sort=stars&order=desc&page=1&per_page=100";

            var data =await _remoteData.GetRepositoriesData(queryParams);

            var groupedLanguages = data.GroupBy(a => a.language).Select(a => new GetLanguagesListQueryResult
            {
                LanguageName = a.Key!=null?a.Key:ResponseMessageTranslator.NotSpecified,
                ReposUsingCnt = a.Count(),
                ReposUsingList = a.ToList()
            }) ;
            return new OutputResponse<List<GetLanguagesListQueryResult>>
            {
                Message = ResponseMessageTranslator.Success,
                StatusCode = HttpStatusCode.OK,
                Success = true,
                Model = groupedLanguages.ToList(),
                Count=data.Count
            };
        }
    }
}
