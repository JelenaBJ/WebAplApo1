using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthHub.Models
{
    public class Product
    {
        public long? ProductID { get; set; }

        [Required(ErrorMessage = "Upišite ime proizvoda")]
        public string Name { get; set; } = String.Empty; 

        [Required(ErrorMessage = "Upišite opis proizvoda")]       
        public string Description { get; set; } = String.Empty;

        
        
       
