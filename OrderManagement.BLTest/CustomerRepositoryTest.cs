using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement.BL;
using System.Collections.Generic;

namespace OrderManagement.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void GetCustomerTest()
        {
            // Arrange
            var customerRepo = new CustomerRepository();
            var expectedValue = new Customer(1)
            {
                EmailAddress = "jan.kowalski@test.pl",
                FirstName = "Jan",
                LastName = "Kowalski"
            };

            // Act

            var actualValue = customerRepo.GetCustomer(1);

            // Assert
            Assert.AreEqual(expectedValue.CustomerId, actualValue.CustomerId);
            Assert.AreEqual(expectedValue.EmailAddress, actualValue.EmailAddress);
            Assert.AreEqual(expectedValue.FirstNameAndLastName, actualValue.FirstNameAndLastName);

        }

        [TestMethod]
        public void GetCustomerWithAddressesTest()
        {
            // Arrange
            var customerRepo = new CustomerRepository();
            var expectedValue = new Customer(1)
            {
                EmailAddress = "jan.kowalski@test.pl",
                FirstName = "Jan",
                LastName = "Kowalski",
                AddressesList = new List<Address>()
                {
                    new Address(1)
                    {
                        AddressType = 1,
                        Street = "Kwiatowa",
                        City = "Kraków",
                        Country = "Polska",
                        PostCode = "31-444"
                    },
                    new Address(2)
                    {
                        AddressType = 2,
                        Street = "Lindego",
                        City = "Kraków",
                        Country = "Polska",
                        PostCode = "01-995"
                    }
                }
            };

            // Act

            var actualValue = customerRepo.GetCustomer(1);

            // Assert
            Assert.AreEqual(expectedValue.CustomerId, actualValue.CustomerId);
            Assert.AreEqual(expectedValue.EmailAddress, actualValue.EmailAddress);
            Assert.AreEqual(expectedValue.FirstNameAndLastName, actualValue.FirstNameAndLastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expectedValue.AddressesList[i].AddressType, actualValue.AddressesList[i].AddressType);
                Assert.AreEqual(expectedValue.AddressesList[i].Street, actualValue.AddressesList[i].Street);
                Assert.AreEqual(expectedValue.AddressesList[i].City, actualValue.AddressesList[i].City);
                Assert.AreEqual(expectedValue.AddressesList[i].PostCode, actualValue.AddressesList[i].PostCode);
                Assert.AreEqual(expectedValue.AddressesList[i].Country, actualValue.AddressesList[i].Country);
            }
        }
    }
}
