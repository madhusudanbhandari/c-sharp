using First.Application.services;

namespace First.Test;

public class Test
{
    [Fact]
    public void Add_Two_Numbers_And_Return_Sum()
    {
        var service=new CalculatorService();

        var result=service.Add(23,2);

        Assert.Equal(25,result);
    }

    [Theory]
    [InlineData(10,5,5)]
    [InlineData(5,5,0)]
    [InlineData(1,5,-4)]
    public void SUM_TWO_NUMBERS(int a,int b,int expected)
    {
        var service=new CalculatorService();
        var result=service.Sub(a,b);

        Assert.Equal(result,expected);
    }

    [Theory]
    [InlineData(10,true)]
    [InlineData(5,false)]
    [InlineData(0,true)]
    public void TEST_EVEN_OR_ODD(int a,bool test)
    {
        var service=new CalculatorService();
        bool result=service.IsEven(a);

        Assert.Equal(result,test);

    }
}