
public class VisitorCounter
{
    private int _count=0;

    private readonly object _lock=new();

    public int Increment()
    {
        lock (_lock)
        {
            _count++;
            return _count;
        }
    }

    public int GetCurrentCount()
    {
        lock (_lock)
        {
            return _count;
        }
    }
}