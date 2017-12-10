using System.Threading.Tasks;
using QyClient.Core.Web.Business.Base;
using QyClient.Core.Web.BusinessResponse;

namespace QyClient.Core.Web.WebServiceEngine
{
    // 所有 business 执行引擎，进行管理控制

    class WebServiceEngine
    {
        private static WebServiceEngine _instance;
        public static WebServiceEngine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WebServiceEngine();

                return _instance;
            }
        }

        private WebServiceEngine() { }

        public async Task<WebBusinessResponseBase> StartAsync(WebBusinessBase business)
        {
            var data = business.PrepareRequestData();
            var url = data.ToUrl();
            // ...


            await Task.Delay(1);
            var result = "http result";
            var rsp = business.ReceiveData(result);
            return rsp;
        }
    }
}
