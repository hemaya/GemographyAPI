using Gemography.Crosscut.Responses;
using MediatR;
using System.Collections.Generic;

namespace Gemography.Application.Components.GetLanguagesList
{
    public class GetLanguagesListQuery :IRequest<OutputResponse<List<GetLanguagesListQueryResult>>>
    {
    }
}