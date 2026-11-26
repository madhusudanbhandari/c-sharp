namespace First.Application.services;

public class CalculatorService
{
    public int Add(int a,int b)
    {
        return a+b;
    }

    public int Sub(int a,int b)
    {
        return a-b;
    }

    public bool IsEven(int num)
    {
        return num%2==0;
    }
}