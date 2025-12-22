using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace HealthHub.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();
        
        [Required(ErrorMessage = "Molimo Vas upišite svoje ime!")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Molimo Vas upišite adresu!")]
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        
        [Required(ErrorMessage = "Molimo Vas upišite grad!")]
        public string? City { get; set; }
        
        [Required(ErrorMessage = "Molimo Vas upišite ime opštine ili okruga!")]
        public string? State { get; set; }
        
        public string? Zip { get; set; }
        
        [Required(ErrorMessage = "Molimo Vas upišite ime države!")]
        public string? Country { get; set; }
        
        public bool GiftWrap { get; set; }

        [BindNever]
        public bool Shipped { get; set; }


    }
}