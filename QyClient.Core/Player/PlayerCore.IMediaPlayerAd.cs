using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.Core.Player.Interface;
using QyClient.Core.Player.Model;

namespace QyClient.Core.Player
{

    /// <summary>
    /// 广告
    /// </summary>
    public partial class PlayerCore : IMediaPlayerAd
    {
        public void Setup()
        {
            throw new NotImplementedException();
        }

        public void SkipAd()
        {
            throw new NotImplementedException();
        }

        public void ClickEvent()
        {
            throw new NotImplementedException();
        }

        private void GetAdModel()
        {
            
        }

        private void DisplayAd(AdModel adModel)
        {
            _mediaPlayerAdCallback.ShowAd(true, adModel);
        }

    }
}
