namespace Calculator;

public class CalculatorService
{
    public int Add(int a, int b)
    {
        return a+b;
    }

    public int Subtraction(int a, int b){
        return a-b;
    }

    public int Multiplication(int a, int b)
    {
        return a*b;
    }

    public double Division(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }

        return a/b;
    }
}