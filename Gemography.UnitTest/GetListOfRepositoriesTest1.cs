using FluentAssertions;
using Gemography.APIs;
using Gemography.Application.Components.GetLanguagesList;
using Gemography.Crosscut.Responses;
using Gemography.Crosscut.Routers;
using Gemography.UnitTest.Factory;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Gemography.UnitTest
{
   public class GetListOfRepositoriesTest1 : IClassFixture<MyReaderApiAppFactory>
    {
        private readonly Requester _requester;

        public GetListOfRepositoriesTest1(MyReaderApiAppFactory factory)
        {
            var client = factory.CreateClient();
            _requester = new Requester(client);
        }

        [Fact]

        public async Task GetListOfRepositories_MustReturnSuccess()
        {
            //arrange


            var response = await _requester.GetAsync <OutputResponse<List<GetLanguagesListQuery>>>(Router.Repos.GetLanguages);

            ////assert
            response.Should().NotBeNull();
            response?.StatusCode.Should().Be(HttpStatusCode.OK);
        }

    }
}
