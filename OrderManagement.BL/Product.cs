using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

        public Decimal? ActualPrice { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }

        /// <summary>
        /// Get one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product GetProduct(int productId)
        {
            // Kod, który ma pobierać zdefioniowany product
            return new Product();
        }


        /// <summary>
        /// Save product
        /// </summary>
        /// <returns></returns>
        public bool SaveProduct()
        {
            // Kod, który zapisuje produkt do kolekcji
            return true;
        }

        /// <summary>
        /// Validates the required field ProductName
        /// </summary>
        /// <returns>returns true if the product name is correct and false if is null </returns>
        public bool Validate()
        {
            var correct = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                correct = false;
                       
            return correct;
        }

    }
}
