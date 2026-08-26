public class ServiceB
{
    private readonly RequestTracker _tracker;
    public ServiceB(RequestTracker tracker)
    {
        _tracker=tracker;
    }

    public string DoWork()
    {
        var count=_tracker.Touch();
        return $"ServiceB saw instance {_tracker.InstanceId},touch #{count}";

    }

}
