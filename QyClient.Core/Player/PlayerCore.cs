using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.Core.Auth;
using QyClient.Core.Player.Interface;

namespace QyClient.Core.Player
{
    public partial class PlayerCore
    {
        private readonly IMediaPlayerCallback _mediaPlayerCallback;
        private readonly IMediaPlayerAdCallback _mediaPlayerAdCallback;
        private readonly IMediaPlayerBulletsCallback _mediaPlayerBulletsCallback;
        private readonly ISettingStorage _settingStorage;

        public PlayerCore(IMediaPlayerCallback mediaPlayerCallback, IMediaPlayerAdCallback mediaPlayerAdCallback, IMediaPlayerBulletsCallback mediaPlayerBulletsCallback, ISettingStorage settingStorage)
        {
            _mediaPlayerCallback = mediaPlayerCallback;
            _mediaPlayerAdCallback = mediaPlayerAdCallback;
            _mediaPlayerBulletsCallback = mediaPlayerBulletsCallback;
            _settingStorage = settingStorage;

            AuthData.AuthDataUpdated += AuthData_AuthDataUpdated; ;
        }

    
    }
}
