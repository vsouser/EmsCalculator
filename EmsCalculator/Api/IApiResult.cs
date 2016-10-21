using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsCalculator.Api
{
    public interface IApiResult
    {
       string Stat { get; set; }
        string Msg { get; set; }
    }
}
