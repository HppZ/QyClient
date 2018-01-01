using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.Core.Player.Model;

namespace QyClient.Core.Player
{
    interface IMediaPlayerAdCallback    
    {
        void ShowAd(bool show, AdModel adModel);
        void CountDown(int count);

    }
}
