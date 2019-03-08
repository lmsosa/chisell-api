using System;

namespace ChiSell.Domain.Products
{
    public class Brand
    {
        public Brand()
        {
            Name = string.Empty;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}