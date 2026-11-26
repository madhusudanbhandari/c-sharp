using First.Application.Dtos;
using First.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace First.Api.Controller;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    private readonly IProjectService _projectService;
    
    public ProjectController(IProjectService projectService)
    {
        _projectService=projectService;
    }

    [HttpPost("add-project")]
    public async Task<IActionResult> AddProject(AddProjectDto dto)
    {
        var project=await _projectService.AddProject(dto);
        return Ok(project);
    }

    [HttpGet("get-project")]
    public async Task<IActionResult> ViewProject(int id)
    {
        var project=await _projectService.GetProjectById(id);
        return Ok(project);
    }

    [HttpGet("get-projects")]
    public async Task<IActionResult> GetProjects()
    {
        var projects=await _projectService.GetAllProjects();
        return Ok(projects);
    }

    [HttpPatch("update-project")]
    public async Task<IActionResult> UpdateProject(int id,UpdateProjectDto dto)
    {
        var project=await _projectService.UpdateProject(id,dto);

        return Ok(project);
    }
}