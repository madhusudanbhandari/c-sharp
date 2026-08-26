

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class VisitorController : ControllerBase
{
    private readonly VisitorCounter _counter;
    public VisitorController(VisitorCounter counter)
    {
        _counter=counter;
    }

    [HttpGet("visit")]
    public IActionResult Visit()
    {
        var newCount=_counter.Increment();
        return Ok($"You are visitor number {newCount}");
    }

    [HttpGet("count")]
    public IActionResult GetCount()
    {
        return Ok($"Total visits so far: {_counter.GetCurrentCount()}");
    }
}