using First.Application.Dtos;
using First.Application.Interface;
using First.Domain.Entities;

namespace First.Application.Services;

public class TaskService:ITaskService
{
    private readonly ITaskRepository _taskRepository;
    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository=taskRepository;
    }

    public async Task<ViewTaskDto> AddTask(AddTaskDto dto)
    {
        var newtask=new Tasks
        {
            Title=dto.Title,
            Description=dto.Description,
            Status=dto.Status,
            AssignedTo=dto.AssignedTo
        };

        await _taskRepository.AddTask(newtask);

        return new ViewTaskDto
        {
            Title=newtask.Title,
            Description=newtask.Description,
            Status=newtask.Status,
            AssignedTo=newtask.AssignedTo
        };
    }

    public async Task<ViewTaskDto?> ViewTaskById(int id)
    {
        var newtask=await _taskRepository.GetTaskById(id);

        if (newtask == null)
        {
            throw new Exception("Cant find the tasks");
        }

        return new ViewTaskDto
        {
            Title=newtask.Title,
            Description=newtask.Description,
            Status=newtask.Status,
            AssignedTo=newtask.AssignedTo
        };

    }
    public async Task<ViewTaskDto?> UpdateTask(int id,UpdateTaskDto dto)
    {
        var newtask=await _taskRepository.GetTaskById(id);
        if (newtask == null)
        {
            throw new Exception("Cannot find the task");
        }

        await _taskRepository.UpdateTask(newtask.Id,dto);

        return new ViewTaskDto
        {
            Title=newtask.Title,
            Description=newtask.Description,
            Status=newtask.Status,
            AssignedTo=newtask.AssignedTo
        };

    }

    public async Task<string?> DeleteTask(int id)
    {
        var task=await _taskRepository.GetTaskById(id);
 
        await _taskRepository.DeleteTask(id);

        return "Task deleted successfully";
    }


    public async Task<List<ViewTaskDto>> GetMyTasks(int userId)
    {
        var task=await _taskRepository.GetUsersTasks(userId);

        if (task == null)
        {
            throw new Exception("Cannot find the tasks");
        }

        return task.Select(task=>new ViewTaskDto
        {
            Title=task.Title,
            Description=task.Description,
            Status=task.Status,
            AssignedTo=task.AssignedTo
        }).ToList();

        // return new ViewTaskDto
        // {
        //     Title=task.Title,
        //     Description=task.Description,
        //     Status=task.Status,
        //     AssignedTo=task.AssignedTo
        // };
        
    }

}