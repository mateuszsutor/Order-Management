using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BL
{
    public class Customer
    {
        public static int Count { get; set; }

        public int IdCustomer { get; private set; }

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

        public Customer GetCustomer(int idCustomer) 
        {
            // kod który pobiera okreslonego klienta
            return new Customer();
        }

        public List<Customer> GetAllCustomer()
        {
            // kod który pobiera wszytkich klientów
            return new List<Customer>();
        }






    }
}
