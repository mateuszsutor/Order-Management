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
