using First.Application.Dtos;
using First.Application.services;

namespace First.Application.Interface;

public interface IProjectService
{
    public Task<ViewProjectDto> AddProject(AddProjectDto dto);
    public Task<ViewProjectDto?> GetProjectById(int id);
    public Task<List<ViewProjectDto>> GetAllProjects();

    public Task<ViewProjectDto?> UpdateProject(int projectId,UpdateProjectDto dto); 
}