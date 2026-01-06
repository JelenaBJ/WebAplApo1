using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthHub.Models
{
    public class StoreRepositoryEF : I_StoreRepository
    {
        public StoreRepositoryEF(StoreContextDb ctx) 
        {
            context = ctx;
        } 




    }
}
