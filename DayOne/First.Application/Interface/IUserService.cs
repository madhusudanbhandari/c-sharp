using First.Application.Dtos;
using First.Domain.Entities.Enum;

namespace First.Application.Interface;

public interface IUserService
{
    public Task<ViewUserDto> RegisterUser(AddUserDto dto);
    public Task<ViewUserDto> UpdateUser(int id,UpdateUserDto dto);
    public Task<string?> DeleteUser(int id);
    public Task<ViewUserDto>LoginUser(LoginUserDto dto);
    public Task<ViewUserDto?> AddRole(int UserId,UserRole RoleId);

    public Task<ViewUserDto> UpdateRole(int id,UpdateRole dto);
}