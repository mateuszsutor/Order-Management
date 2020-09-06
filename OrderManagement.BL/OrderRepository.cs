using System;

namespace OrderManagement.BL
{
    public class OrderRepository
    {

        /// <summary>
        /// Get one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order GetOrder(int orderId)
        {
            // kod, który pobiera wartosci np z bazy danych

            // tymczasiwy kod, który ma pobierać zdefiniowany produkt
            var order = new Order(orderId);
           
            if (orderId == 10)
                order.OrderDate = new DateTimeOffset(2020, 9, 6, 12, 00, 00, new TimeSpan(7, 0, 0));

            return order;

        }


        /// <summary>
        /// Save order
        /// </summary>
        /// <returns></returns>
        public bool SaveOrder()
        {
            // Kod, który zapisuje zamówienie do kolekcji
            return true;
        }
    }
}
