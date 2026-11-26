using First.Application.Interface;
using First.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace First.Api.Controller;

[ApiController]
[Route("api/[controller]")]
public class JobController : ControllerBase
{

    private readonly IJobService _jobService;
    public JobController(IJobService jobService)
    {
        _jobService=jobService;
    }
    [HttpPost("add-job")]
    public async Task<IActionResult> AddJob(AddJobDto dto)
    {
        var job=await _jobService.AddJob(dto);
        return Ok(job);
    }

    [HttpGet("get-job")]
    public async Task<IActionResult> GetJob(int id)
    {
        var job=await _jobService.ViewJobById(id);
        return Ok(job);
    }

    [HttpGet("get-jobs")]
    public async Task<IActionResult> GetJobs()
    {
        var jobs=await _jobService.ViewAllJobs();
        return Ok(jobs);   

    }

}