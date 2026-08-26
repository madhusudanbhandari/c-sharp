using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TrackerController : ControllerBase
{
    private readonly ServiceA _serviceA;
    private readonly ServiceB _serviceB;
    private readonly ServiceC _serviceC;
    private readonly RequestTracker _trackerDirect;

    public TrackerController(ServiceA serviceA, ServiceB serviceB, ServiceC serviceC, RequestTracker trackerDirect)
    {
        _serviceA=serviceA;
        _serviceB=serviceB;
        _serviceC=serviceC;
        _trackerDirect=trackerDirect;
    }

    [HttpGet]
    public IActionResult Check()
    {
        var resultA=_serviceA.DoWork();
        var resultB=_serviceB.DoWork();
        var resultC=_serviceC.DoWork();
        var controllerSeesId=_trackerDirect.InstanceId;

        return Ok(new
        {
            resultA,
            resultB,
            resultC,
            controllerSeesId
        });
    }
}