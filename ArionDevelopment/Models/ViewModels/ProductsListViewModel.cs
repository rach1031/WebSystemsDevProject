using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ArionDevelopment.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ArionDevelopment.Models.ViewModels
{
    public class ProductsListViewModel
    {
     //   public List<Product> Products1 { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

        
      //  public SelectList Makes { get; set; }
        public string CurrentMake { get; set; }

        public string CurrentType { get; set; }
        
        /*
       
        [Display(Name = "Make")]
        public string VehicleMake { get; set; }
        public IEnumerable<SelectListItem> Makes { get; set; }

       
        [Display(Name = "Model")]
        public string SelectedModel { get; set; }
        public IEnumerable<SelectListItem> Models { get; set; }

    */

    }
}
