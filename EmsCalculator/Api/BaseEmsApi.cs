using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmsCalculator.Api
{
    public abstract class BaseEmsApi
    {
        protected HttpClient _client;
        protected const string _baseUrl = @"http://emspost.ru/api/rest/?";
        protected string _apiMetod;

        public BaseEmsApi(string apiMetod)
        {
            _client = new HttpClient();
        }

        protected string Url
        {
            get
            {
                return _baseUrl + "method=" + _apiMetod;
            }
        }

        protected async Task<JObject> Parse()
        {
            string result = await _client.GetStringAsync(Url);
            return JObject.Parse(result);
        }

        protected bool IsOk(BaseApiResult apiResult)
        {
            return apiResult.Stat == "ok";
        }

        public async Task SendRequest(Action<BaseApiResult, JObject> onComplite, Action<BaseApiResult> onError, Action onLoad)
        {
            try
            {
                onLoad();

                var obj = await Parse();

                BaseApiResult apiResult = new BaseApiResult() { Stat = obj["rsp"]["stat"].ToString() };

                if(IsOk(apiResult))
                {
                    apiResult.Msg = "Готово";
                    onComplite(apiResult, obj);
                }
                else
                {
                    apiResult.Msg = obj["rsp"]["err"]["msg"].ToString();
                    onError(apiResult);
                }
            }
            catch (Exception ex)
            {
                onError(new BaseApiResult() { Stat = "Exception", Msg = ex.Message });
            }
        }

    }
}
