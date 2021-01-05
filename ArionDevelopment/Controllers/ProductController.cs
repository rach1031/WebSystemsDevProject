using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArionDevelopment.Models;
using ArionDevelopment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ArionDevelopment.Controllers
{
    public class ProductController : Controller

    {

        private IProductRepository repository;
        public int PageSize = 2;

     

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }



        public ViewResult List(string make, string bodyType, int page = 1)
         => View(new ProductsListViewModel
         {

             Products = repository.Products
                          .Where(p => (make == null || p.Make == make) 
                                &&  bodyType == null || p.BodyType == bodyType)
                         .OrderBy(p => p.ProductID)
                         .Skip((page - 1) * PageSize)
                         .Take(PageSize),
             PagingInfo = new PagingInfo
             {
                 CurrentPage = page,
                 ItemsPerPage = PageSize,
                    TotalItems = make == null ?
                    repository.Products.Count() :
                    repository.Products.Where(e =>
                    e.Make == make).Count()
             },
             CurrentMake = make,
             CurrentType = bodyType
         });

    }

}
    

