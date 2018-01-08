using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QyClient.Core.Player
{
    /// <summary>
    /// 设置保存
    /// </summary>
    public partial class PlayerCore
    {
        bool IsBulletOn()
        {
            _settingStorage.GetSetting("IsBulletOn");
            return true; 
        }

        bool SaveIsBulletOn(bool isOn)
        {
            _settingStorage.SaveSetting("IsBulletOn", isOn);
            return true;
        }


    }
}
