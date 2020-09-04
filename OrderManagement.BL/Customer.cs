using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BL
{
    public class Customer
    {
        public Customer() { }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }


        public static int Count { get; set; }

        public int CustomerId { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string HomeAddress { get; set; }

        public string WorkAddress { get; set; }

        public string FirstNameAndLastName
        {
            get
            {
                string fistNameAndLastName = FirstName;

                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fistNameAndLastName))
                    {
                        fistNameAndLastName += " ";
                    }
                    fistNameAndLastName += LastName;
                }

                return fistNameAndLastName;
            }
        }


        /// <summary>
        /// Validates the required properties
        /// </summary>
        /// <returns>return true if the properties is valid and false if not valid </returns>
        public bool Validate()
        {
            var correct = true;

            if (string.IsNullOrWhiteSpace(LastName))
                correct = false;

            if (string.IsNullOrWhiteSpace(EmailAddress))
                correct = false;

            return correct;
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
        /// <param name="idCustomer">Customer id</param>
        /// <returns></returns>
        public Customer GetCustomer(int idCustomer)
        {
            // kod który pobiera okreslonego klienta
            return new Customer();
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
