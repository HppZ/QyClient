using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.Core.Navigation.INavigator;

namespace QyClient.UI.Navigation.Interface
{
    interface IMainTabsNavigator : INavigator
    {
        void GotoHome();
        void GotoChannel();
        void GotoVip();
        void GotoSetting();

    }



}
