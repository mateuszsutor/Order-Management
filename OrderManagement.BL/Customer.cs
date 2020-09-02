using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BL
{
    public class Customer
    {
        public int IdCustomer { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string EmailAddress { get; set; }

        public string HomeAddress { get; set; }

        public string WorkAddress { get; set; }
        public string FirstNameAndLastName
        {
            get { return LastName + " " + FirstName; }
        }
   }
}
