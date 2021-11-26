using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Gemography.Crosscut.Responses;
using MediatR;

namespace Gemography.Application.Components.GetLanguagesList
{
    public class GetLanguagesListQueryHandler : IRequestHandler<GetLanguagesListQuery, OutputResponse<List<GetLanguagesListQueryResult>>>
    {
        private readonly IDataManager _dataManager;

        public GetLanguagesListQueryHandler(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public async Task<OutputResponse<List<GetLanguagesListQueryResult>>> Handle(GetLanguagesListQuery request, CancellationToken cancellationToken)
        {
            return await _dataManager.GetLanguagesList();
        }
    }
}