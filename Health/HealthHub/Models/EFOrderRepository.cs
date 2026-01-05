using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HealthHub.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private StoreContextDb context;
        
        public EFOrderRepository(StoreContextDb ctx) 
        {
            context = ctx;
        }
        
       

    }
}
