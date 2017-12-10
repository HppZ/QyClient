using QyClient.Core.Web.BusinessResponse;
using QyClient.Core.Web.WebProtocol.request;

namespace QyClient.Core.Web.Business.Base
{
    abstract class WebBusinessBase
    {
        protected internal abstract request PrepareRequestData();
        protected internal abstract WebBusinessResponseBase ReceiveData(string data);



    }
}
