namespace ChiSell.Application.Common.Models
{
    public class AddressModel
    {
        public string AddressLine { get; set; } = default!;

        public string City { get; set; } = default!;

        public StateModel? State { get; set; }

        public CountryModel? Country { get; set; }
    }
}
