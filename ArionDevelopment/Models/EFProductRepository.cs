using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ArionDevelopment.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext context;
        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Product> Products => context.Products;

        public void SaveProduct(Product product)
        {
            if (product.ProductID == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry = context.Products
                .FirstOrDefault(p => p.ProductID == product.ProductID);
                if (dbEntry != null)
                {
                    dbEntry.Make = product.Make;
                    dbEntry.Model = product.Model;
                    dbEntry.Price = product.Price;
                    dbEntry.Color = product.Color;
                    dbEntry.BodyType = product.BodyType;
                    dbEntry.Mileage = product.Mileage;
                    dbEntry.Year = product.Year;
                    dbEntry.NumberOfSeats = product.NumberOfSeats;
                    dbEntry.CityMPG = product.CityMPG;
                    dbEntry.HighwayMPG = product.HighwayMPG;
                    dbEntry.Location = product.Location;
                    dbEntry.DailyRate = product.DailyRate;
                    dbEntry.Picture = product.Picture;

                }
            }
            context.SaveChanges();
        }
        public Product DeleteProduct(int productID)
        {
            Product dbEntry = context.Products
            .FirstOrDefault(p => p.ProductID == productID);
            if (dbEntry != null)
            {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
