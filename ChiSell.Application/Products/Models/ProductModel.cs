using System;

namespace ChiSell.Application.Products.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
            Name = string.Empty;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
