﻿using System.Threading.Tasks;
using testing.Models.TokenAuth;
using testing.Web.Controllers;
using Shouldly;
using Xunit;

namespace testing.Web.Tests.Controllers
{
    public class HomeController_Tests: testingWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}