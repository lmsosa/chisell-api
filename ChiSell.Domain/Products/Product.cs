using System;

namespace ChiSell.Domain.Products
{
    public class Product
    {
        public Product()
        {
            Name = string.Empty;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Guid SellerId { get; set; }

        public Seller? Seller { get; set; }
        
        public Guid BrandId { get; set; }

        public Brand? Brand { get; set; }

        public Guid CategoryId { get; set; }

        public Category? Category { get; set; }


    }
}
