namespace OrderManagement.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId )
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Get one order item
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem GetOrder(int orderItemId)
        {
            // Kod, który ma pobierać zamówienie
            return new OrderItem();
        }


        /// <summary>
        /// Save order item
        /// </summary>
        /// <returns></returns>
        public bool SaveOrderItem()
        {
            // Kod, który zapisuje zamówienie do kolekcji
            return true;
        }

        /// <summary>
        /// Checks correct order item
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var correct = true;

            if (Quantity <=0)
                correct = false;
            if (ProductId <= 0)
                correct = false;
            if (PurchasePrice == null)
                correct = false;

            return correct;
        }
    }
}
