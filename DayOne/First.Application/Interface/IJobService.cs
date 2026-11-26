using First.Domain.Entities;

namespace First.Application.Interface;

public interface IJobService
{
    public Task<ViewJobDto> AddJob(AddJobDto dto);
    public Task<ViewJobDto?> ViewJobById(int id);
    public Task<List<ViewJobDto>> ViewAllJobs();
}