using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using QyClient.UI.Module.Channel.ViewModel;
using QyClient.UI.Module.Home.ViewModel;

namespace QyClient.UI.ViewModel.Locator
{
   public class ViewModelLocator
    {
        //public static ViewModelLocator GetInstance()
        //{
        //    return Application.Current.Resources["AppViewModelLocator"] as ViewModelLocator;
        //}

        public static MainViewModel _mainViewModel;
        public static MainViewModel MainViewModel
        {
            get
            {
                if (_mainViewModel == null)
                {
                    _mainViewModel = new MainViewModel();
                }
                return _mainViewModel;
            }
        }

        public static HomeMainViewModel _homeMainViewModel;
        public static HomeMainViewModel HomeMainViewModel
        {
            get
            {
                if (_homeMainViewModel == null)
                {
                    _homeMainViewModel = new HomeMainViewModel();
                }
                return _homeMainViewModel;
            }
        }

        public static ChannelMainViewModel _channelMainViewModel;
        public static ChannelMainViewModel ChannelMainViewModel
        {
            get
            {
                if (_channelMainViewModel == null)
                {
                    _channelMainViewModel = new ChannelMainViewModel();
                }
                return _channelMainViewModel;
            }
        }




    }
}
