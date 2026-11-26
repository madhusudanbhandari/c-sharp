using First.Application.Interface;
using First.Domain.Entities;

namespace First.Application.Services;

public class JobService : IJobService
{
    private readonly IJobRepository _jobRepository;

    public JobService(IJobRepository jobRepository)
    {
        _jobRepository=jobRepository;
    }
    public async Task<ViewJobDto> AddJob(AddJobDto dto)
    {
        var job=new Job
        {
            Name=dto.Title,
            Description=dto.Description,
            Tasks=dto.Tasks
        };

        await _jobRepository.AddJob(job);
        return new ViewJobDto
        {
            Id=job.Id,
            Title=job.Name,
            Description=job.Description,
            Tasks=job.Tasks
        };

    }

    public async Task<ViewJobDto?> ViewJobById(int id)
    {
        var job=await _jobRepository.GetJobById(id);

        if (job == null)
        {
            throw new Exception("Cannot find job");
        }

        return new ViewJobDto
        {
            Title=job.Name,
            Description=job.Description,
            Tasks=job.Tasks
        };
    }

    public async Task<List<ViewJobDto>> ViewAllJobs()
    {
        var jobs=await _jobRepository.GetAllJobs();

        return jobs.Select(job=> new ViewJobDto
        {
            Title=job.Name,
            Description=job.Description,
            Tasks=job.Tasks
        }).ToList();
    }
}