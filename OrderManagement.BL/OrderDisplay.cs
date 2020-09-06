using System;
using System.Collections.Generic;

namespace OrderManagement.BL
{
    public class OrderDisplay
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItemDisplay> OrderItemDisplayList { get; set; }
        public int OrderId { get; set; }
        public Address DeliveryAddress { get; set; }
    }
}
