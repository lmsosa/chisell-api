using ChiSell.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChiSell.Data.Seed
{
    public class SeedData
    {
        public  void Seed(ModelBuilder modelBuilder)
        {
            var oregonSeller = new Seller() { Id = GetGuid(1), Name = "Oregon Inc. Items" };

            modelBuilder.Entity<Seller>().HasData(
                oregonSeller
            );

            var lifeFitnessBrand = new Brand() { Id = GetGuid(1), Name = "Life Fitness" };

            modelBuilder.Entity<Brand>().HasData(
                lifeFitnessBrand,
                new Brand() { Id = GetGuid(2), Name = "Zellens" },
                new Brand() { Id = GetGuid(3), Name = "Include Fitness" },
                new Brand() { Id = GetGuid(4), Name = "Corplus" },
                new Brand() { Id = GetGuid(5), Name = "M#" },
                new Brand() { Id = GetGuid(6), Name = "Super fit" }
            );

            var cardioSuperCategory = new Category() { Id = GetGuid(1), Name = "Cardio training", ParentCategoryId = null };
            var climberSuperCategory = new Category() { Id = GetGuid(2), Name = "Climbers & Steppers", ParentCategoryId = GetGuid(1) };
            var verticalClimbersCategory = new Category() { Id = GetGuid(3), Name = "Vertical Climbers", ParentCategoryId = GetGuid(2) };
            var stairSteppersCategory = new Category() { Id = GetGuid(4), Name = "Stair Steppers", ParentCategoryId = GetGuid(2) };
            var treadMillsCategory = new Category() { Id = GetGuid(5), Name = "TreadMills", ParentCategoryId = GetGuid(1) };

            modelBuilder.Entity<Category>().HasData(
                cardioSuperCategory,
                climberSuperCategory,
                verticalClimbersCategory,
                stairSteppersCategory,
                treadMillsCategory
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = GetGuid(1), Name = "Jacobs Ladder", CategoryId = GetGuid(3), BrandId = GetGuid(1), Price = 9500, SellerId = GetGuid(1) }
            );

        }

        private Guid GetGuid(byte number)
        {
            var guidBytes = new byte[16];
            guidBytes[15] = number;
            return new Guid(guidBytes);
        }
    }
}
