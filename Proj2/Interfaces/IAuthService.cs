namespace Proj2.Interfaces;

using Proj.DTOs;
using Proj2.DTOs;

public interface IAuthService
{
    Task<AuthResponseDto> RegisterAsync(RegisterDto dto);

    Task<AuthResponseDto> LoginAsync(LoginDto dto);
}