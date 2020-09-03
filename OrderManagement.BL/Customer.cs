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
    }
}
