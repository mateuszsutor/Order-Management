using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement.BL;

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
    }
}
