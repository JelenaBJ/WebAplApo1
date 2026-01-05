using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthHub.Models;
using HealthHub.Models.ViewModels;

namespace HealthHub.Controllers
{
    public class HomeController: Controller
    {
        private I_StoreRepository repository; 
        public int PageSize = 4; 

        public HomeController(I_StoreRepository repo)
        {
            repository = repo;
        } 

      

 

    }
}
