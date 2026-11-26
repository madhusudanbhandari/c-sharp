using First.Domain.Entities;

namespace First.Application.Interface;

public interface IJobRepository
{
    Task AddJob(Job job);
    Task<Job?> GetJobById(int id);
    Task<IEnumerable<Job>> GetAllJobs();
}