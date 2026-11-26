using System.Net.NetworkInformation;
using First.Application.Dtos;
using First.Application.Interface;
using First.Application.services;

namespace First.Application.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository=projectRepository;
    }
    public async Task<ViewProjectDto> AddProject(AddProjectDto dto)
    {
        var projects=new Projects
        {
            Name=dto.Name,
            Tasks=dto.Tasks
        };

        await _projectRepository.AddProject(projects);

        return new ViewProjectDto
        {
            Id=projects.Id,
            Name=projects.Name,
            Tasks=projects.Tasks
        };
    }

    public async Task<ViewProjectDto?> GetProjectById(int id)
    {
        var project=await _projectRepository.GetProjectById(id);

        if (project == null)
        {
            throw new Exception("Cannot find the project");
        }

        return new ViewProjectDto
        {
            Id=project.Id,
            Name=project.Name,
            Tasks=project.Tasks
        };


    }

    public async Task<List<ViewProjectDto>> GetAllProjects()
    {
        var projects=await _projectRepository.GetAllProjects();
        return projects.Select(project=>new ViewProjectDto
        {
            Id=project.Id,
            Name=project.Name,
            Tasks=project.Tasks
        }).ToList();
    }

    public async Task<ViewProjectDto?> UpdateProject(int projectId,UpdateProjectDto dto)
    {
        var project=await _projectRepository.GetProjectById(projectId);

        if(project==null)
            throw new Exception("project cannot be found");

        await _projectRepository.UpdateProject(project.Id,dto);

        return new ViewProjectDto
        {
            Id=project.Id,
            Name=dto.Name,
            Tasks=dto.Tasks
        };

    }


}