using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.UserActivities;
using QyClient.Core.DAL.Account;
using QyClient.Core.DAL.UserActivityRepository;
using QyClient.Core.Manager.DownloadManager;
using QyClient.Core.Manager.PlayRecordManager;
using QyClient.Core.Manager.UserLikeManager;

namespace QyClient.Core.Controller
{
    public static class QyClientControllerAccess
    {
        // UI: UI model 用于UI定制

        // Core: app business: result(infomation) 对外公开的 app 业务请求结果封装，不同结果对应不同result，包装information 提供给app UI 层。
        // app & web business: business response / (infomation) 网络业务封装。
        // (infomation)：app core 封装层，从 协议结构 / 本地存储结构 的原始数据到 app core 的 结构 / 抽象 的映射，分布在core 层。
        // protocol （服务端协议映射） 

        // entity：sql 本地存储抽象

        public static AccountController AccountController { get; private set; }
        public static ChannelController ChannelController { get; private set; }
        public static ContentController ContentController { get; private set; }
        public static FeedbackController FeedbackController { get; private set; }
        public static MySubscriptionController MySubscriptionController { get; private set; }
        public static SearchController SearchController { get; private set; }
        public static SettingController SettingController { get; private set; }
        public static UserActivityController UserActivityController { get; private set; }


        static QyClientControllerAccess()
        {
            var userActivityRepository = new UserActivityRepository();

            var playRecordManager = new PlayRecordManager(userActivityRepository);
            var downloadManager = new DownloadManager(userActivityRepository);
            var userLikeManager = new UserLikeManager(userActivityRepository);

            AccountController = new AccountController(new AccountRepository());
            ChannelController = new ChannelController();
            ContentController = new ContentController();
            FeedbackController = new FeedbackController();
            MySubscriptionController = new MySubscriptionController();
            SearchController = new SearchController();
            SettingController = new SettingController();
            UserActivityController = new UserActivityController(downloadManager, playRecordManager, userLikeManager);
        }
    }
}
