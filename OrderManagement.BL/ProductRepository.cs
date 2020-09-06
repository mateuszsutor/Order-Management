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
        public bool SaveProduct()
        {
            // Kod, który zapisuje produkt do kolekcji
            return true;
        }
    }
}
