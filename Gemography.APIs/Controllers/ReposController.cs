using System.Threading.Tasks;
using Gemography.APIs.Setups.Bases;
using Gemography.Application.Components.GetLanguagesList;
using Gemography.Crosscut.Routers;
using Microsoft.AspNetCore.Mvc;

namespace Gemography.APIs.Controllers
{
    public class ReposController : CoreController
    {
        [HttpGet(Router.Repos.GetLanguages)]
        public async Task<IActionResult> GetLanguages()
        {
            GetLanguagesListQuery query = new GetLanguagesListQuery();
            var result = await Mediator.Send(query);
            return ReturnResult(result);
        }

    }
}
