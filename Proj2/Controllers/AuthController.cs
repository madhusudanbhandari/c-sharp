using Microsoft.AspNetCore.Mvc;
using Proj.DTOs;
using Proj2.DTOs;
using Proj2.Interfaces;

namespace Proj2.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService=authService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<AuthResponseDto>> Register(RegisterDto dto)
    {
        var response=await _authService.RegisterAsync(dto);

        return Ok(response);
    }
}