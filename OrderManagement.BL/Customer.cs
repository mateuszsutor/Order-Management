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
        /// <returns>returns true if the properties is valid and false if not valid </returns>
        public bool Validate()
        {
            var correct = true;

            if (string.IsNullOrWhiteSpace(LastName))
                correct = false;

            if (string.IsNullOrWhiteSpace(EmailAddress))
                correct = false;

            return correct;
        }
    }
}
