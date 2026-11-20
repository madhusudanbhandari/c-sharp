using First.Application.Dtos;
using First.Application.Interface;
using First.Domain.Entities.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace First.Api.Controller;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService=userService;
    }

    [AllowAnonymous]
    [HttpPost("register")]
    public async Task<IActionResult> RegisterUser(AddUserDto dto)
    {
        var user=await _userService.RegisterUser(dto);

        return Ok(user);
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> LoginUser(LoginUserDto dto)
    {
        var user=await _userService.LoginUser(dto);

        return Ok(user);
    }
    
    [Authorize(Roles ="User,Admin")]
    [HttpPatch("Update-User")]
    public async Task<IActionResult> UpdateUser(int id, UpdateUserDto dto)
    {
        var user=User.FindFirstValue(ClaimTypes.NameIdentifier)!;
        if(!int.TryParse(user,out int userId))
        {
            return  Unauthorized();
        }

        if (id != userId)
        {
            throw new Exception("You cannot Update others Data");
        }
        var udpatedUser=await _userService.UpdateUser(id,dto);

        return Ok(udpatedUser);
    }

    [Authorize(Roles ="Admin")]
    [HttpDelete("Delete")]
    public async Task<IActionResult> DeleteUserById(int id)
    {
        var deleted=await _userService.DeleteUser(id);
        return Ok(deleted);
    }

    [Authorize(Roles ="Admin")]
    [HttpPatch("Update-Role")]
    public async Task<IActionResult> UpdateRole(int id,UpdateRole dto)
    {
        var roleUpdate=await _userService.UpdateRole(id,dto);

        return Ok(roleUpdate);
    }

    [Authorize(Roles ="Admin")]
    [HttpPost("Assign-Role")]
    public async Task<IActionResult> AssignRole(int userId,UserRole RoleId)
    {
        var assigned=await _userService.AddRole(userId,RoleId);
        return Ok(assigned);
    }



    

}