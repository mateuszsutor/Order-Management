using System;
using System.Collections.Generic;

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
                order.OrderDate = new DateTimeOffset(2020, 9, 6, 20, 00, 00, new TimeSpan(7, 0, 0));

            return order;

        }

        /// <summary>
        /// Gets one order to display
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public OrderDisplay GetOrderToDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            //kod który pobiera zamówienie

            // tymczasowe dane do testów
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Jan";
                orderDisplay.LastName = "Kowalski";
                orderDisplay.OrderDate = new DateTimeOffset(2020, 9, 6, 20, 00, 00, new TimeSpan(7, 0, 0));
                orderDisplay.DeliveryAddress = new Address()
                {
                    AddressType = 1,
                    Street = "Kwiatowa",
                    City = "Kraków",
                    Country = "Poska",
                    PostCode = "31-444",
                };
            }

            orderDisplay.OrderItemDisplayList = new List<OrderItemDisplay>();

            // kod który pobiera elementy zamówinia 

            // tymczasowe dane do testów
            if (orderId == 10)
            {
                var orderItemDisplay = new OrderItemDisplay()
                {
                    ProductName = "Krzesło",
                    OrderQuantity = 4,
                    PurchasePrice = 119.77M
                };
                orderDisplay.OrderItemDisplayList.Add(orderItemDisplay);

                orderItemDisplay = new OrderItemDisplay()
                {
                    ProductName = "Stolik",
                    OrderQuantity = 7,
                    PurchasePrice = 249M
                };
                orderDisplay.OrderItemDisplayList.Add(orderItemDisplay);
            }

            return orderDisplay;
        }

        /// <summary>
        /// Save order
        /// </summary>
        /// <returns></returns>
        public bool SaveOrder(Order order)
        {
            // Kod, który zapisuje produkt do kolekcji
            var success = true;

            if (order.HasChanges && order.DataIsCorrect)
            {
                if (order.IsItsNew)
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
