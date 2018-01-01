using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.Core.Player.Interface;

namespace QyClient.Core.Player
{
    partial class PlayerCore
    {
        private IMediaPlayerCallback _mediaPlayerCallback;
        private IMediaPlayerAdCallback _mediaPlayerAdCallback;
        private IMediaPlayerBulletsCallback _mediaPlayerBulletsCallback;
        private ISettingStorage _settingStorage;
        public PlayerCore(IMediaPlayerCallback mediaPlayerCallback, IMediaPlayerAdCallback mediaPlayerAdCallback, IMediaPlayerBulletsCallback mediaPlayerBulletsCallback, ISettingStorage settingStorage)
        {
            _mediaPlayerCallback = mediaPlayerCallback;
            _mediaPlayerAdCallback = mediaPlayerAdCallback;
            _mediaPlayerBulletsCallback = mediaPlayerBulletsCallback;
            _settingStorage = settingStorage;
        }
         




    }
}
