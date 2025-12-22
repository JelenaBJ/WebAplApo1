using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthHub.Models;

namespace HealthHub.Components
{
    public class NavigationMenuViewComponent : ViewComponent 
    {
       private I_StoreRepository repository; 

        public NavigationMenuViewComponent(I_StoreRepository repo)
        {
            repository = repo;
        } 

        public IViewComponentResult Invoke()
        {
	     ViewBag.SelectedCategory = RouteData?.Values["category"]; 
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }


    }

}