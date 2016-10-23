using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsCalculator.Api
{
    public class WorldLocationsApi : LocationsApi
    {
        public WorldLocationsApi() : base("&type=countries&plain=true")
        {

        }
    }
}
