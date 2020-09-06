using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BL
{
    public class Order
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

        /// <summary>
        /// Checks correct data of the order 
        /// </summary>
        /// <returns>returns true if the order day is it not null and false if is null </returns>
        public bool Validate()
        {
            var correct = true;

            if (OrderDate == null)
                correct = false;

            return correct;
        }

    }
}
