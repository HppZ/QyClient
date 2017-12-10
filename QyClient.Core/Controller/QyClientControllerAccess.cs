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
        // UI: model
        // Core: app business: result(infomation) / app & web business: response (infomation) / protocol /

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
