using System;

namespace ChiSell.Domain
{
    public class Seller
    {
        public Seller()
        {
            Name = string.Empty;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}