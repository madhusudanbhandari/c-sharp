using Dapper;
using First.Application.Interface;
using First.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using First.Application.Dtos;
using System.Runtime.Intrinsics.Arm;
using First.Domain.Entities.Enum;

namespace First.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly SqlConnection _connection;

    public UserRepository(SqlConnection sqlConnection)
    {
        _connection=sqlConnection;
    }


    public async Task AddUser(User user)
    {

        const string sql="INSERT INTO Users (Name, Email,Password,Age,Role) VALUES (@Name, @Email,@Password,@Age,@Role)";
        await _connection.ExecuteAsync(sql, user);
    }

    public async Task<User?> GetUserById(int id)
    {
        //return await _context.Users.FirstOrDefaultAsync(u=>u.Id==id);
        
        const string sql="SELECT *FROM Users WHERE Id=@Id";

        return await _connection.QuerySingleOrDefaultAsync<User>(sql,new {Id=id});
    }

    public async Task<User?> GetUserByEmail(string email)
    {
        const string sql="SELECT *FROM Users WHERE Email=@Email";

        return await _connection.QueryFirstOrDefaultAsync<User>(sql,new {Email=email});
    }

    public async Task<User?> UpdateUser(int id,UpdateUserDto dto)
    {
        
        const string sql="UPDATE Users SET Name=@Name, Age=@Age, Email=@Email, Password=@Password WHERE Id=@Id";

        var parameters=new DynamicParameters();
        parameters.Add("@Name",dto.Name,dbType:System.Data.DbType.String);
        parameters.Add("@Age",dto.Age,dbType:System.Data.DbType.Int32);
        parameters.Add("@Email",dto.Email,dbType:System.Data.DbType.String);
        parameters.Add("@Password",dto.Password,dbType:System.Data.DbType.String);
        parameters.Add("@Id",id);

        await _connection.ExecuteAsync(sql,parameters);
        
        
        return await GetUserById(id);

    }

    public async Task<User?> UpdateRole(int id,UpdateRole dto)
    {
        
        const string sql="UPDATE Users SET Role=@Role WHERE Id=@Id";
       
        var parameters=new DynamicParameters();
        parameters.Add("@Id",id);
        parameters.Add("@Role",dto.Role);

        await _connection.ExecuteAsync(sql,parameters);
        
        return await GetUserById(id);

    }

    public async Task<string?> DeleteUserById(int id)
    {
        const string sql="DELETE FROM Users WHERE Id=@Id";

        var parameters=new DynamicParameters();
        parameters.Add("@Id",id);

        await _connection.ExecuteAsync(sql,parameters);        
        return "User deleted successfully";
    }

    public async Task AddRole(int UserId,UserRole Role)
    {
        const string sql=@"INSERT INTO Roles (UserId,Role) VALUES(@UserId,@Role)";

        var parameters=new DynamicParameters();
        parameters.Add("@UserId",UserId);
        parameters.Add("@Role",Role);

         await _connection.ExecuteAsync(sql,parameters);
    }

    public async Task<UserRole> GetUserRole(int userId)
    {
        const string sql=@"SELECT Role FROM Roles WHERE UserId=@userId";


        var role= await _connection.QueryFirstOrDefaultAsync<int>(sql,new{UserId=userId});
        return (UserRole)role;
    }
}