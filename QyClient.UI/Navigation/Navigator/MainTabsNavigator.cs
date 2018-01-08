using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.UI.Module.Channel.View;
using QyClient.UI.Module.Home.View;
using QyClient.UI.Navigation.Interface;
using QyClient.UI.ViewModel.Locator;

namespace QyClient.UI.Navigation.Navigator
{
    class MainTabsNavigator : IMainTabsNavigator
    {
        public void GotoHome()
        {
            NavigationController.NavigateTo(typeof(HomeMainView), null);
        }

        public void GotoChannel()
        {
            NavigationController.NavigateTo(typeof(ChannelMainView), null);
        }

        public void GotoVip()
        {
             
        }

        public void GotoSetting()
        {
             
        }
    }
}
