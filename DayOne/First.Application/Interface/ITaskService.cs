using First.Application.Dtos;
using First.Domain.Entities;

namespace First.Application.Interface;

public interface ITaskService
{
    public  Task<ViewTaskDto> AddTask(AddTaskDto dto);
    public  Task<ViewTaskDto?> ViewTaskById(int id);
    public  Task<ViewTaskDto?> UpdateTask(int id,UpdateTaskDto dto);
    public Task<string?> DeleteTask(int id);

    public Task<List<ViewTaskDto>> GetMyTasks(int userId);
}