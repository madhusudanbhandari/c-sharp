public class ServiceA
{
    private readonly RequestTracker _tracker;

    public ServiceA(RequestTracker tracker)
    {
        _tracker=tracker;
    }

    public string DoWork()
    {
        var count=_tracker.Touch();
        return $"ServiceA saw instance {_tracker.InstanceId}, touch #{count}";
    }
}