namespace OrderManagement.BL
{
    public class OrderItemDisplay
    {
        public int OrderItemId  { get; set; }
        public int OrderQuantity { get; set; }
        public string ProductName { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}