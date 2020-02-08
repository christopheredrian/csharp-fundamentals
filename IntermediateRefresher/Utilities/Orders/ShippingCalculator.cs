namespace Utilities.Orders
{
    public class ShippingCalculator: IShippingCalculator
    {
        public decimal CalculateShipping(Order order)
        {

            decimal cost = 10;

            if (order.TotalCost > 30)
            {
                decimal percentage = 0.10M;
                cost = order.TotalCost * percentage;
            }

            return cost;
        }
    }
}
