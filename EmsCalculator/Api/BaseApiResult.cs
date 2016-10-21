using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsCalculator.Api
{
    public class BaseApiResult : IApiResult
    {
        private string stat;

        public string Stat
        {
            get
            {
                return stat;
            }
            set
            {
                stat = value;
            }
        }

        public JObject _object;

        public JObject Object
        {
            get
            {
                return _object;
            }
            set
            {
                _object = value;
            }
        }

        private string msg;
        public string Msg
        {
            get
            {
                return msg;
            }

            set
            {
                    msg = value;
            }
        }
    }
}
