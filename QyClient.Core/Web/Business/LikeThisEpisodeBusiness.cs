using QyClient.Core.Web.Business.Base;
using QyClient.Core.Web.BusinessResponse;
using QyClient.Core.Web.Param;
using QyClient.Core.Web.WebProtocol.request;
using QyClient.Core.Web.WebProtocol.response;

namespace QyClient.Core.Web.Business
{
    class LikeThisEpisodeBusiness : WebBusinessBase
    {
        private LikeThisEpisodeBusinessParam _param;
        public LikeThisEpisodeBusiness(LikeThisEpisodeBusinessParam param)
        {
            _param = param;
        }

        protected internal override request PrepareRequestData()
        {
            var req = new like_this_episode_req()
            {
                episode_id = _param.episode_id,
                // ...

            };

            return req;
        }

        protected internal override WebBusinessResponseBase ReceiveData(string data)
        {
            // 解析
            var rsp = new like_this_episode_rsp();


            return LikeThisEpisodeBusinessResponse.From(rsp);
        }


    }




}
