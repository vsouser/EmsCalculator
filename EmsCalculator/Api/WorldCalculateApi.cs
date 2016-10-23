using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsCalculator.Api
{
    public class WorldCalculateApi : CalculateApi
    {
        public WorldCalculateApi(string to, string weight, string type) : base(string.Format("&to={0}&weight={1}&type={2}",to, weight, type))
        {

        }
    }
}
