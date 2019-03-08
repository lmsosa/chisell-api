namespace ChiSell.Domain.Common
{
    public class Address
    {
        public Address()
        {
            AddressLine = string.Empty;
            City = string.Empty;
            State = new State();
            Country = new Country();
        }

        public string AddressLine { get; set; }

        public string City { get; set; }

        public State State { get; set; }

        public Country Country { get; set; }
    }
}
