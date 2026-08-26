public class RequestTracker
{
    private readonly Guid _instanceId=Guid.NewGuid();
    private int _touchCount=0;

    public string InstanceId=>_instanceId.ToString();

    public int Touch()
    {
        _touchCount++;
        return _touchCount;
    }
}