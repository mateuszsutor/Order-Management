using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BL
{
    class AddressRepository
    {

        /// <summary>
        /// Gets one address
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address GetAddress(int addressId)
        {
            Address address = new Address(addressId);

            // kod, kóry pobiera zdefiniowany adres

            // tymczasowo zakodowane wartosci do testów
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.Street = "Kwiatowa";
                address.City = "Kraków";
                address.Country = "Poska";
                address.PostCode = "31-444";
            }
            return address;
        }

        /// <summary>
        /// Gets all defined address from customer id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public IEnumerable<Address> GetAddressUsingCustomerId(int customerId)
        {

            // kod, kóry pobiera zdefiniowand adresy klienta

            // tymczasowo zakodowane wartosci do testów
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                Street = "Kwiatowa",
                City = "Kraków",
                Country = "Polska",
                PostCode = "31-444"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                Street = "Lindego",
                City = "Kraków",
                Country = "Polska",
                PostCode = "01-995"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Save actual address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool SaveAddress(Address address)
        {
            // kod, który ma zapisywać adres

            return true;
        }
    }
}
