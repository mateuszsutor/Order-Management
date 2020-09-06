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
            var productRepo = new ProductRepository();
            var expectedProduct = new Product(2)
            {
                ProductName = "Klocki",
                Description = "Klocki dla dzieci 3+",
                ActualPrice = 119.99M
            };

            // Act

            var actualProduct = productRepo.GetProduct(2);

            // Assert
            Assert.AreEqual(expectedProduct.ProductName, actualProduct.ProductName);
            Assert.AreEqual(expectedProduct.Description, actualProduct.Description);
            Assert.AreEqual(expectedProduct.ActualPrice, actualProduct.ActualPrice);
        }
    }
}
