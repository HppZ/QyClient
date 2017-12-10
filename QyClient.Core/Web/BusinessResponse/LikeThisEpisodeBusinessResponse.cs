using QyClient.Core.Web.WebProtocol.response;

namespace QyClient.Core.Web.BusinessResponse
{
    class LikeThisEpisodeBusinessResponse:WebBusinessResponseBase
    {

        // ...
         

        public static LikeThisEpisodeBusinessResponse From(like_this_episode_rsp rsp)
        {
            var result = new LikeThisEpisodeBusinessResponse();
            // ... 
            // information 

            return result;
        }
    }
}
