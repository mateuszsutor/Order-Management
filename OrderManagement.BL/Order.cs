using Common;
using System;
using System.Collections.Generic;

namespace OrderManagement.BL
{
    public class Order : BaseClass, ILogin
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }

        public DateTimeOffset? OrderDate { get; set; }

        public List<OrderItem> OrdersItems { get; set; }

        public int CustomerId { get; set; }

        public int DesntinationAddressId  { get; set; }

        /// <summary>
        /// Checks correct data of the order 
        /// </summary>
        /// <returns>returns true if the order day is it not null and false if is null </returns>
        public override bool Validate()
        {
            var correct = true;

            if (OrderDate == null)
                correct = false;

            return correct;
        }

        public override string ToString()
        {
            return OrderDate.Value.DateTime + "( id: " + OrderId + ")";
        }

        public string Log()
        {
            var logText = OrderId + ": " +
                          "Data: " + OrderDate.Value.Date + " " +
                          "Status :" + ObjectStatus.ToString();

            return logText;
        }
    }
}
