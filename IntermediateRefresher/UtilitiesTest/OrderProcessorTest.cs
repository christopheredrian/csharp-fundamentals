using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities.Orders;
using System;

namespace UtilitiesTest
{
    [TestClass]
    public class OrderProcessorTest
    {
        // METHODNAME_CONDITION_EXPECTION
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShipingCalculator());
            var order = new Order
            {
                Shipment = new Shipment(),
                IsShipped = true,
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShipingCalculator());
            var order = new Order
            {
                Shipment = new Shipment(),
                IsShipped = false,
            };
            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today, order.Shipment.ShippingDate);
        }
    }

    public class FakeShipingCalculator : IShippingCalculator
    {
        public decimal CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
