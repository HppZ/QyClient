using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QyClient.Core.Player.Interface
{
    // 播放基本行为回调，可用于外部投递，比如视频开播，广告开播
    interface IMediaPlayerCallback
    {
        void OnPlayStateChanged( string  state);





    }
}
