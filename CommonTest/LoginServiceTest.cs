using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTest
{
    [TestClass]
    public class LoginServiceTest
    {
        [TestMethod]
        public void WriteToFileTest() 
        {
            //Arange
            var changedItems = new List<ILogin>();

            var customer = new Customer(1) 
            {
                FirstName = "Marek",
                LastName = "Nowak",
                EmailAddress = "Jan@o2.pl",
                AddressesList = null
            };
            changedItems.Add(customer);

            var product = new Product(2) 
            {
                ProductName ="Klocki",
                Description = "Klocki do zabawy",
                ActualPrice = 120M
            };
            changedItems.Add(product);   // changedItems.Add(product as ILog);

            var order = new Order(3) 
            {
                OrderDate = new DateTimeOffset(2020, 9, 7, 22,00,00,new TimeSpan(7,0,0))
            };
            changedItems.Add(order);

            //Act
            LoginService.WriteToFile(changedItems);

            //Assert

        }

    }
}
