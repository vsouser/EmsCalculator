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
    public class RussianLocationsApi : LocationsApi
    {
        public RussianLocationsApi() : base("&type=russia&plain=true")
        {

        }


    }
}
