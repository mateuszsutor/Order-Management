using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void GetOrderTest()
        {
            // Arrange
            var orderRepo = new OrderRepository();
            var expectedOrder = new Order(10)
            {
                OrderDate = new DateTimeOffset(2020, 9, 6, 12, 00, 00, new TimeSpan(7, 0, 0))
            };

            // Act

            var actualOrder = orderRepo.GetOrder(10);

            // Assert
            Assert.AreEqual(expectedOrder.OrderId, expectedOrder.OrderId);
            Assert.AreEqual(expectedOrder.OrderDate, expectedOrder.OrderDate);
        }
    }
}
