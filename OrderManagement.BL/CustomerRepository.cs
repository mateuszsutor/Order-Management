﻿using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.BL
{
    public class CustomerRepository
    {

        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Save actual client
        /// </summary>
        /// <returns></returns>
        public bool SaveCustomer()
        {
            // kod który zapisuje zdefiniowanego klienta

            return true;
        }

        /// <summary>
        /// Get one customer
        /// </summary>
        /// <param name="customerId">Customer id</param>
        /// <returns></returns>
        public Customer GetCustomer(int customerId)
        {
            // tworzymy instancje klasy
            Customer customer = new Customer(customerId);
            customer.AddressesList = addressRepository.GetAddressUsingCustomerId(customerId).ToList();

            // kod, który pobiera określonego klienta


            // tymczasowo zakodowane wartości, aby zwrócić klienta

            if (customerId == 1)
            {
                customer.EmailAddress = "jan.kowalski@test.pl";
                customer.FirstName = "Jan";
                customer.LastName = "Kowalski";
            }

            return customer;
        }

        /// <summary>
        /// Get all customer
        /// </summary>
        /// <returns>List all customer</returns>
        public List<Customer> GetAllCustomer()
        {
            // kod który pobiera wszytkich klientów
            return new List<Customer>();
        }
    }
}
