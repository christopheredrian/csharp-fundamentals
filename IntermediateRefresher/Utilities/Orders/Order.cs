namespace Utilities.Orders
{
    public class Order  
    {
        public bool IsShipped { get; set; }
        public Shipment Shipment { get; set; }
        public decimal TotalCost { get; set; }
    }
}
