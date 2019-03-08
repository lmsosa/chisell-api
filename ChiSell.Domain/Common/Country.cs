using System;

namespace ChiSell.Domain.Common
{
    public class Country
    {
        public Country()
        {
            Name = string.Empty;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}