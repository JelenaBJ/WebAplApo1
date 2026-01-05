using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HealthHub.Infrastructure;
using HealthHub.Models;


namespace HealthHub.Pages
{
    public class CartModel : PageModel
    {
        private I_StoreRepository repository;

        public CartModel(I_StoreRepository repo, Cart cartService) 
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; } = "/";
        
        public void OnGet(string returnUrl) 
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }
        
        



    }
}
