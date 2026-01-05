using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace HealthHub.Infrastructure
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value) 
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        } 

        

    }
}
