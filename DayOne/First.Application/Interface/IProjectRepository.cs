using First.Application.Dtos;
using First.Application.services;

namespace First.Application.Interface;

public interface IProjectRepository
{
    public Task AddProject(Projects projects);

    public Task<Projects?> GetProjectById(int id);

    public Task<IEnumerable<Projects>> GetAllProjects();

    public Task UpdateProject(int projectId,UpdateProjectDto dto);
}