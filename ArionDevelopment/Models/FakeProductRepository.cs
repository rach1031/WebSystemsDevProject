

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArionDevelopment.Models
{
    public class FakeProductRepository // : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product {Make = "Volkswagen", Price = 14000},
            new Product {Make = "Subaru", Price = 14750}
        };
    }
}
