using Calculator;
namespace Calculator;

public class PriceCalculator
{
    private readonly IDiscountProvider _discountProvider;

    public PriceCalculator(IDiscountProvider discountProvider)
    {
        _discountProvider=discountProvider;
    }

    public decimal calculateFinalDiscount(decimal price)
    {
        decimal percentage= _discountProvider.getDiscountPercentage();


        return price-(price*percentage/100);

    }
}