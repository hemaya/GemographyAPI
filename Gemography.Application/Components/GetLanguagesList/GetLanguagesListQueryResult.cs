using Gemography.Integration.Responses;
using System.Collections.Generic;

namespace Gemography.Application.Components.GetLanguagesList
{
    public class GetLanguagesListQueryResult
    {
        public string LanguageName { get; set; }
        public int ReposUsingCnt { get; set; }

        public List<ItemsResponse> ReposUsingList { get; set; }
    }
}
