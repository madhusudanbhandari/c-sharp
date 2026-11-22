using System.Security.Claims;
using First.Application.Dtos;
using First.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace First.Api.Controller;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService=taskService;
    }

    [HttpPost("add-task")]
    public async Task<IActionResult> AddTask(AddTaskDto dto)
    {
        var task=await _taskService.AddTask(dto);

        return Ok(task);
    }

    [HttpGet("view-task")]
    public async Task<IActionResult> ViewTask(int id)
    {
        var task=await _taskService.ViewTaskById(id);
        return Ok(task);
    }

    [HttpPatch("update-task")]
    public async Task<IActionResult> UpdateTask(int id,UpdateTaskDto dto)
    {
        var updated=await _taskService.UpdateTask(id,dto);
        return Ok(updated);
    }

    [HttpDelete("delete-task")]
    public async Task<IActionResult> DeleteTask(int id)
    {
        var deleted=await _taskService.DeleteTask(id);
        return Ok(deleted);
    }

    [Authorize(Roles ="User")]
    [HttpGet("View-my-tasks")]
    public async Task<IActionResult> GetMyTasks()
    {
        var user=User.FindFirstValue(ClaimTypes.NameIdentifier);

        if(!int.TryParse(user,out int userId))
        {
            return Unauthorized();
        }

        var tasks=await _taskService.GetMyTasks(userId);
        return Ok(tasks);
    }


}