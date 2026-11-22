using First.Application.Dtos;
using First.Domain.Entities;

namespace First.Application.Interface;

public interface ITaskRepository
{
    public Task AddTask(Tasks task);
    public Task<Tasks?> GetTaskById(int id);
    public Task UpdateTask(int id, UpdateTaskDto dto);
    public Task DeleteTask(int id);

    public Task<IEnumerable<Tasks>> GetUsersTasks(int userId);
    
}