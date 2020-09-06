using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement.BL;
using System;
using System.Collections.Generic;

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

        [TestMethod]
        public void GetOrderToDisplayTest()
        {
            // Arrange
            var orderRepo = new OrderRepository();
            var expectedOrder = new OrderDisplay()
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                OrderDate = new DateTimeOffset(2020, 9, 6, 20, 00, 00, new TimeSpan(7, 0, 0)),
                DeliveryAddress = new Address()
                {
                    AddressType = 1,
                    Street = "Kwiatowa",
                    City = "Kraków",
                    Country = "Poska",
                    PostCode = "31-444",
                },

                OrderItemDisplayList = new List<OrderItemDisplay>()
                {
                    new OrderItemDisplay()
                    {
                        ProductName = "Krzesło",
                        OrderQuantity = 4,
                        PurchasePrice = 119.77M
                    },
                    new OrderItemDisplay()
                    {
                        ProductName = "Stolik",
                        OrderQuantity = 7,
                        PurchasePrice = 249M
                    }
                }
            };
            // Act
            var actualOrder = orderRepo.GetOrderToDisplay(10); 
                

            // Assert
            Assert.AreEqual(expectedOrder.OrderId, actualOrder.OrderId);
            Assert.AreEqual(expectedOrder.OrderDate, actualOrder.OrderDate);
            Assert.AreEqual(expectedOrder.FirstName, actualOrder.FirstName);
            Assert.AreEqual(expectedOrder.LastName, actualOrder.LastName);

            Assert.AreEqual(expectedOrder.DeliveryAddress.AddressId, actualOrder.DeliveryAddress.AddressId);
            Assert.AreEqual(expectedOrder.DeliveryAddress.AddressType, actualOrder.DeliveryAddress.AddressType);
            Assert.AreEqual(expectedOrder.DeliveryAddress.Street, actualOrder.DeliveryAddress.Street);
            Assert.AreEqual(expectedOrder.DeliveryAddress.City, actualOrder.DeliveryAddress.City);
            Assert.AreEqual(expectedOrder.DeliveryAddress.Country, actualOrder.DeliveryAddress.Country);
            Assert.AreEqual(expectedOrder.DeliveryAddress.PostCode, actualOrder.DeliveryAddress.PostCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expectedOrder.OrderItemDisplayList[i].ProductName, actualOrder.OrderItemDisplayList[i].ProductName);
                Assert.AreEqual(expectedOrder.OrderItemDisplayList[i].PurchasePrice, actualOrder.OrderItemDisplayList[i].PurchasePrice);
                Assert.AreEqual(expectedOrder.OrderItemDisplayList[i].OrderQuantity, actualOrder.OrderItemDisplayList[i].OrderQuantity);
            }
        }
    }
};


