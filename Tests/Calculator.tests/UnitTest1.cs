using Calculator;
using Xunit;
using Moq;


namespace Calculator.Tests;
public class CalculatorServiceTests
{
    [Theory] ///for testing multiple inputs through InlineData for input
    [InlineData(2,3,5)]
    [InlineData(-4,5,1)]
    [InlineData(-5,-6,-11)]
    [InlineData(5,-7,-2)]
    [InlineData(0,0,0)]
    public void Add_TwoNumbers_Result(int a,int b,int expected)
    {
        //arrange
        var calculator=new CalculatorService();

        //act
        var result=calculator.Add(a,b);

        //assert==check the expeted and actual result
        Assert.Equal(expected,result);
    }

    [Fact] ///for checking the single set of input
    public void  Sub_TwoNumbers_Result()
    {
        var calculator=new CalculatorService();

        var result=calculator.Subtraction(7,3);

        Assert.Equal(4,result);
    }

    [Theory]
    [InlineData(2,3,6)]
    [InlineData(-23,2,-46)]
    [InlineData(-10,-10,100)]
    [InlineData(-20,0,0)]
    public void Multiply_TwoNumbers_Result(int a,int b, int product)
    {
        var calculator=new CalculatorService();
        
        var result=calculator.Multiplication(a,b);

        Assert.Equal(product,result);
    }

    [Theory]
    [InlineData(9,4.5,2)]
    [InlineData(10,5,2)]
    [InlineData(-11,2,-5.5)]
    [InlineData(0,5,0)]
    [InlineData(10,-2,-5)]
    public void Division_ByNonZero_Result(double a, double b, double reminder)
    {
        var calculator=new CalculatorService();

        var result=calculator.Division(a,b);

        Assert.Equal(reminder,result);
    }

    [Fact]
    public void DivideBy_ZeroException()
    {
        var calculator=new CalculatorService();

        Assert.Throws<DivideByZeroException>(
            ()=>calculator.Division(3,0)
        );
    }

    [Fact]
    public void Calculate_Discount_Percentage()
    {
        var mockDiscountProvider=new Mock<IDiscountProvider>();
        
        mockDiscountProvider.Setup(x=>x.getDiscountPercentage()).Returns(10m);

        var priceCalculator=new PriceCalculator(mockDiscountProvider.Object);

        decimal result=priceCalculator.calculateFinalDiscount(100m);

        Assert.Equal(90m,result);


    }


}
