using EmsCalculator.Api.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsCalculator.Api
{
    public sealed class MaxWeightApi : BaseEmsApi
    {
        public MaxWeightApi() : base("ems.get.max.weight")
        {

        }

        public MaxWeight GetMaxWeight(JObject json)
        {
           return new MaxWeight() { Weight = double.Parse(json["rsp"]["max_weight"].ToString()) };
        }
     
    }
}
