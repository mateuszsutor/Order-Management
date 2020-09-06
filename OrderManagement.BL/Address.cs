namespace OrderManagement.BL
{
    public class Address
    {
        public Address() { }

        public Address(int addresId)
        {
            AddressId = addresId;
        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

    }
}
