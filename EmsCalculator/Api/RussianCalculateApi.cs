using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsCalculator.Api
{
    public class RussianCalculateApi : CalculateApi
    {
        public RussianCalculateApi(string from, string to, string weight) : base(string.Format("&from={0}&to={1}&weight={2}", from, to, weight))
        {
        }
    }
}
