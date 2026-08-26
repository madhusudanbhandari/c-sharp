public class ServiceC
{
    private readonly RequestTracker _tracker;

    public ServiceC(RequestTracker tracker)
    {
        _tracker=tracker;
    }

    public string DoWork()
    {
        var count=_tracker.Touch();
        return $"ServiceC saw instance {_tracker.InstanceId} with touch #{count}";
    }
}