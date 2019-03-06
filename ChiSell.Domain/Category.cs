using System;
using System.Collections.Generic;

namespace ChiSell.Domain
{
    public class Category
    {
        public Category()
        {
            Name = string.Empty;
            Categories = new List<Category>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid? ParentCategoryId { get; set; }

        public Category? ParentCategory { get; set; }

        public IList<Category> Categories { get; set; }
    }
}