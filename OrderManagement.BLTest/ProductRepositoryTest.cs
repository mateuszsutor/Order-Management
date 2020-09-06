using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement.BL;

namespace OrderManagement.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void GetProductTest()
        {
            // Arrange
            var productRepo = new Product();
            var expectedProduct = new Product()
            {
                ProductName = "Klocki",
                Description = "Klocki dla dzieci 3+",
                ActualPrice = 119.99M
            };

            // Act

            var actualProduct = productRepo.GetProduct(2);

            // Assert
            Assert.AreEqual(productRepo.ProductName, actualProduct.ProductName);
            Assert.AreEqual(productRepo.Description, actualProduct.Description);
            Assert.AreEqual(productRepo.ActualPrice, actualProduct.ActualPrice);
            

        }

    }
}
