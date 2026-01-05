using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthHub.Models;


namespace HealthHub.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        
        public OrderController(IOrderRepository repoService, Cart cartService) 
        {
            repository = repoService;
            cart = cartService;
        }

       

    }
}
