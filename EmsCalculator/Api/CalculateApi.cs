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
    public class CalculateApi : BaseEmsApi
    {
        public CalculateApi(string param) : base("ems.calculate", param)
        {

        }

        public Calculate GetCalculate(JObject json)
        {
           return JsonConvert.DeserializeObject<Calculate>(json["rsp"].ToString());
        }
    }
}
