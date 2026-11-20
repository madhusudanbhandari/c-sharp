using System.Reflection.Metadata;
using First.Application.Dtos;
using First.Domain.Entities;
using First.Domain.Entities.Enum;

namespace First.Application.Interface;

public interface IUserRepository
{
    public Task AddUser(User user);
    public Task<User?> GetUserById(int id);
    public Task<User?> GetUserByEmail(string email);
    public Task<User?> UpdateUser(int id,UpdateUserDto dto);
    public Task<User?> UpdateRole(int id,UpdateRole dto);
    public Task<string?> DeleteUserById(int id);

    public Task AddRole(int UserId,UserRole RoleId);
    public Task<UserRole> GetUserRole(int UserId);

}