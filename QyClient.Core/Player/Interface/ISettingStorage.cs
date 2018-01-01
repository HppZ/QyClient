using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QyClient.Core.Player.Interface
{
    interface ISettingStorage
    {
        object GetSetting(string key);
        bool SaveSetting(string key, object value);

    }
}
