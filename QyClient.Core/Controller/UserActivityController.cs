using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.Core.Manager.Interface;

namespace QyClient.Core.Controller
{
    // 下载 ，播放记录， 收藏 等用户活动
    public class UserActivityController
    {
        private IDownloadManager _downloadManager;
        private IPlayRecordManager _playRecordManager;
        private IUserLikeManager _userLikeManager;
        public UserActivityController(IDownloadManager downloadManager, IPlayRecordManager playRecordManager, IUserLikeManager userLikeManager)
        {
            
        }
    }
}
