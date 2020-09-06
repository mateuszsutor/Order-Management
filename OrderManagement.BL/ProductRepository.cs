using System;

namespace OrderManagement.BL
{
    public class ProductRepository
    {

        /// <summary>
        /// Get one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product GetProduct(int productId)
        {
            // tymczasiwy kod, który ma pobierać zdefiniowany produkt
            var product = new Product(productId);

            Object myObject = new Object();
            Console.WriteLine("Obiekt :" + myObject.ToString()); 
            Console.WriteLine("Product :" + product.ToString()); 

            if (productId == 2)
            {
                product.ProductName = "Klocki";
                product.Description = "Klocki dla dzieci 3+";
                product.ActualPrice = 119.99M;
            }

            return product;
        }


        /// <summary>
        /// Save product
        /// </summary>
        /// <returns></returns>
        public bool SaveProduct(Product product)
        {
            // Kod, który zapisuje produkt do kolekcji
            var success = true;

            if (product.HasChanges && product.DataIsCorrect)
            {
                if (product.IsItsNew)
                {
                    // wywołanie prodedury składowej insert (zapis do bazy)
                }
                else
                {
                    // wywołanie prodedury składowej update (update do bazy) 
                }
            }

            return success;
        }
    }
}
