using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.UI.Navigation.Interface;
using QyClient.UI.ViewModel.Locator;

namespace QyClient.UI.Navigation.Navigator
{
    class MainTabsNavigator : IMainTabsNavigator
    {
        public void GotoHome()
        {
            ViewModelLocator.MainViewModel.GotoHome();
        }

        public void GotoChannel()
        {
            ViewModelLocator.MainViewModel.GotoChannel();
        }

        public void GotoVip()
        {
            ViewModelLocator.MainViewModel.GotoVip();
        }

        public void GotoSetting()
        {
            ViewModelLocator.MainViewModel.GotoSetting();
        }
    }
}
