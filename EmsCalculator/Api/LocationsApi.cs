using EmsCalculator.Api.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsCalculator.Api
{
     public class LocationsApi : BaseEmsApi
    {
        public LocationsApi(string param) : base("ems.get.locations", param)
        {

        }

        public List<Location> GetLocations(JObject json)
        {
            return JsonConvert.DeserializeObject<List<Location>>(json["rsp"]["locations"].ToString());
        }
    }
}
