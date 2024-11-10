using CloudCustomers.UnitTesting.Fixtures;
using CloudCustormers.Api.Controllers;
using CloudCustormers.Api.Models;
using CloudCustormers.Api.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace CloudCustomers.UnitTesting.Systems.Controllers
{
    public class TestUsersController
    {
        [Fact]
        public async Task Get_OnSuccess_RetrunStatusCode200()
        {
            //Arrange
            var mockUserService = new Mock<IUsersService>();

            mockUserService
                .Setup(services => services.GetAllUsers())
                 .ReturnsAsync(UsersFixture.GetTestUsers());
            var sut =  new UsersController(mockUserService.Object);

            //Act
            var result =(OkObjectResult) await sut.Get();

            //Assert
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task Get_OnSuccess_InvokesUserService()
        {
            //Arrange
            var mockUserService = new Mock<IUsersService>();

            mockUserService
                .Setup(services => services.GetAllUsers())
                .ReturnsAsync(new List<User>());

            var sut = new UsersController(mockUserService.Object);

            //Act
            var result = await sut.Get();

            //Assert
            mockUserService.Verify(service => service.GetAllUsers(), Times.Once());
        }

        [Fact]
        public async Task Get_OnSeuccess_ReturnListOfUsers()
        {
            // Arrange 

            var mockUserService = new Mock<IUsersService>();

            mockUserService
                .Setup(services => services.GetAllUsers())
                 .ReturnsAsync(UsersFixture.GetTestUsers());

            var sut = new UsersController(mockUserService.Object);

            // Act
            var result = await sut.Get();

            // Assert 
            result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult) result;
            objectResult.Value.Should().BeOfType<List<User>>();
        }

        [Fact]
        public async Task Get_OnNoUserFound_Returns404()
        {
            // Arrange 

            var mockUserService = new Mock<IUsersService>();

            mockUserService
                .Setup(services => services.GetAllUsers())
                .ReturnsAsync(new List<User>());

            var sut = new UsersController(mockUserService.Object);

            // Act
            var result = await sut.Get();

            // Assert 
            result.Should().BeOfType<NotFoundResult>();
            var objectResult = (NotFoundResult) result;

            objectResult.StatusCode.Should().Be(404);
        }


    }
}

