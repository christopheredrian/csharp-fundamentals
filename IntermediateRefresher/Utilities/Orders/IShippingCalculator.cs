namespace Utilities.Orders
{
    public interface IShippingCalculator
    {
        decimal CalculateShipping(Order order);
    }
}
