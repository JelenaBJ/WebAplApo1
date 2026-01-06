using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthHub.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>(); 
        public PagingInfo PagingInfo { get; set; } = new(); 
        public string? CurrentCategory { get; set; }

    }
}

