using First.Application.Dtos;
using First.Application.Interface;
using First.Application.Services;
using Moq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using First.Domain.Entities;


namespace First.Test;


public class Test
{
    [Fact]
    public async Task REGISTER_USER_TEST()
    {

        //arrange
        var repository=new Mock<IUserRepository>();
        var logger=new Mock<ILogger<UserService>>();
        var configuration=new Mock<IConfiguration>();
        var mockToken=new Mock<ITokenRepository>();

        var service=new UserService(repository.Object, configuration.Object, logger.Object, mockToken.Object);

        var userDto=new AddUserDto
        {
            Name="Ram",
            Age=23,
            Email="ram@gmail.com",
            Password="ram@123"
        };

        repository
        .Setup(x => x.AddUser(It.IsAny<User>()))
        .Callback<User>(user => user.Id = 1)
        .Returns(Task.CompletedTask);

        //Act
        var result = await service.RegisterUser(userDto);

        //Asssert

        Assert.NotNull(result);
        Assert.Equal(1, result.Id);
        Assert.Equal("Ram", result.Name);
        Assert.Equal(23, result.Age);
        Assert.Equal("ram@gmail.com", result.Email);

        repository.Verify(
            x => x.AddUser(It.IsAny<User>()),
            Times.Once
        );


    }
}