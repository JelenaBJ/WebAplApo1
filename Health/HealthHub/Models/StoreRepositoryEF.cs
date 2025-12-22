using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthHub.Models
{
    public class StoreRepositoryEF : I_StoreRepository
    {
        private StoreContextDb context; 

        public StoreRepositoryEF(StoreContextDb ctx) 
        {
            context = ctx;
        } 

        public IQueryable<Product> Products => context.Products; 
        public void CreateProduct(Product p) 
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteProduct(Product p) 
        {
            context.Remove(p);
            context.SaveChanges();
        }

        public void SaveProduct(Product p) 
        {
            context.SaveChanges();
        }




    }
}