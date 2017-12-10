using System.Threading.Tasks;
using QyClient.Core.DAL.Interface;
using QyClient.Core.Manager.Interface;
using QyClient.Core.Web.Business;
using QyClient.Core.Web.BusinessResponse;
using QyClient.Core.Web.Param;
using QyClient.Core.Web.WebServiceEngine;

namespace QyClient.Core.Manager.UserLikeManager
{
    /// <summary>
    /// 用户活动， 包含： 播放记录 ，收藏记录
    /// </summary>
    class UserLikeManager:IUserLikeManager
    {
        private IUserLikeRepository _repository;
        public UserLikeManager(IUserLikeRepository repository)
        {
            _repository = repository;
        }


        public async Task Like(int id)
        {
            var business = new LikeThisEpisodeBusiness(new LikeThisEpisodeBusinessParam()
            {
                episode_id = id.ToString()
            });

            var r = await WebServiceEngine.Instance.StartAsync(business);
            if (r.Succeed)
            {
                var rsp = r as LikeThisEpisodeBusinessResponse;
                if (rsp != null)
                {
                    
                }
            }

        }


    }
}
