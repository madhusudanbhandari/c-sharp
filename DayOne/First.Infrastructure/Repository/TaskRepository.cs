using Dapper;
using First.Application.Dtos;
using First.Application.Interface;
using First.Domain.Entities;
using Microsoft.Data.SqlClient;

namespace First.Infrastructure.Repository;

public class TaskRepository:ITaskRepository
{
    private readonly SqlConnection _connection;
    public TaskRepository(SqlConnection connection)
    {
        _connection=connection;
    }

    public async Task AddTask(Tasks task)
    {
        const string sql="INSERT INTO Tasks (Title,Description,Status, AssignedTo) VALUES (@Title,@Description,@Status, @AssignedTo)";
        await _connection.ExecuteAsync(sql,task);
    }

    public async Task<Tasks?> GetTaskById(int id)
    {
        const string sql="SELECT *FROM Tasks WHERE Id=@Id";

        var parameters=new DynamicParameters();

        parameters.Add("@Id",id);

        return await _connection.QueryFirstOrDefaultAsync(sql,parameters);
    }

    public async Task UpdateTask(int id,UpdateTaskDto dto)
    {
        const string sql="UPDATE Tasks SET Title=@Title, Description=@Description, Status=@Status, AssignedTo=@AssignedTo";

        var parameters=new DynamicParameters();
        parameters.Add("@Name",dto.Title);
        parameters.Add("@Description",dto.Description);
        parameters.Add("@Status",dto.Status);
        parameters.Add("@AssignedTo",dto.AssignedTo);

        await _connection.ExecuteAsync(sql,parameters);
    }

    public async Task DeleteTask(int id)
    {
        const string sql="DELETE *FROM Tasks WHERE Id=@Id";

        var parameters=new DynamicParameters();
        parameters.Add("@Id",id);
        await _connection.ExecuteAsync(sql,parameters);
    }
}