using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libcupid_uwp;

namespace QyClient.Core.Player
{
    /// <summary>
    /// 广告回调
    /// </summary>
    public partial class PlayerCore: IAdObjectAppDelegate
    {
        public void OnSlotReady(long start_time)
        {
            throw new NotImplementedException();
        }

        public void OnSlotFailed(SlotFailureType type, long start_time)
        {
            throw new NotImplementedException();
        }

        public void OnAdReady(uint ad_id)
        {
            throw new NotImplementedException();
        }

        public void OnAdMayBeBlocked()
        {
            throw new NotImplementedException();
        }
    }
}
