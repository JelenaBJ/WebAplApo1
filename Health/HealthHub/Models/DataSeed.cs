using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HealthHub.Models
{
    public static class DataSeed
    {
        public static void EnsurePopulated(IApplicationBuilder app ) 
        {
            StoreContextDb context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreContextDb>(); 

            if (context.Database.GetPendingMigrations().Any()) 
            {
                context.Database.Migrate();
            } 

            if (!context.Products.Any())  
            {
                context.Products.AddRange(
                    new Product 
                    {
                    Name = "Beviplex", 
                    Description = "Galenika - Kompleks vitamina B",
                    Category = "Vitamini", 
                    Price = 375
                    }, 
                    new Product {
                    Name = "Vitamin C",
                    Description = "Biofar, 20 šumećih tableta",
                    Category = "Vitamini", 
                    Price = 445
                    },
                    new Product {
                    Name = "Solevita Multivitamin",
                    Description = "šumeće tablete, 20 komada",
                    Category = "Vitamini", 
                    Price = 450
                    },
                    new Product {
                    Name = "Magnesium Citrate 300",
                    Description = "Biofar Tri-Activ",
                    Category = "Vitamini", 
                    Price = 450
                    },
                    new Product {
                    Name = "PROBIOTIC 10 kapsla",
                    Description = "Hemofarm",
                    Category = "Probiotici", 
                    Price = 659
                    },
                    new Product {
                    Name = "PROBIOTIC FORTE 10 kapsla",
                    Description = "Hemofarm",
                    Category = "Probiotici", 
                    Price = 855
                    },
                    new Product {
                    Name = "Rhinostop",
                    Description = "BOSNALIJEK- na bazi paracetamola",
                    Category = "Protiv prehlade", 
                    Price = 455
                    },
                    new Product {
                    Name = "caffetin COLD",
                    Description = "ALKALOID",
                    Category = "Protiv prehlade", 
                    Price = 375
                    },
                    new Product {
                    Name = "Primal Pulmint",
                    Description = "sirup za sve vrste kašlja, 200ml",
                    Category = "Protiv prehlade", 
                    Price = 699
                    },
                    new Product {
                    Name = "PropoMucil kesice",
                    Description = "Herbiko",
                    Category = "Protiv prehlade", 
                    Price = 559
                    },
                    new Product {
                    Name = "Brufen 200mg",
                    Description = "VIATRIS - 30 film tableta",
                    Category = "Protiv bolova", 
                    Price = 195
                    },
                    new Product {
                    Name = "DiclofenacDuo 75mg",
                    Description = "PHARMASWISS - 30 kapsula sa modifikovanim oslobađanjem",
                    Category = "Protiv bolova", 
                    Price = 550
                    },
                    new Product {
                    Name = "Synopen mast",
                    Description = "PLIVA",
                    Category = "Masti, kreme i gelovi", 
                    Price = 230
                    },
                    new Product {
                    Name = "Weleda Skin Food",
                    Description = "univerzalna krema, 75ml",
                    Category = "Masti, kreme i gelovi", 
                    Price = 1535
                    },
                    new Product {
                    Name = "Eucerin UreaRepair Plus",
                    Description = "krema sa 30% uree",
                    Category = "Masti, kreme i gelovi", 
                    Price = 1709
                    },
                    new Product {
                    Name = "Sebamed Sum krem ",
                    Description = "SPF30 75ml",
                    Category = "Masti, kreme i gelovi", 
                    Price = 1225
                    },
                    new Product {
                    Name = "PROPANTHEN skin renewal",
                    Description = "TOP TEN - sa aloe verom",
                    Category = "Masti, kreme i gelovi", 
                    Price = 345
                    },
                    new Product {
                    Name = "Canesten 20g",
                    Description = "BAYER - 1% krem klotrimazol",
                    Category = "Masti, kreme i gelovi", 
                    Price = 675
                    }
                );
                context.SaveChanges(); 
            }
            
           
        }
    }
}

    