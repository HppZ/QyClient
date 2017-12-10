namespace QyClient.Core.Web.WebProtocol.request
{
    // 协议请求定义


    class like_this_episode_req : request
    {
        public string episode_id { get; set; }
        // other params

        public override string ToUrl()
        {
            return "";
        }


    }
}
