using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using GalaSoft.MvvmLight.Command;
using QyClient.Core.Navigation;
using QyClient.UI.Navigation;
using QyClient.UI.Navigation.Interface;
using ChannelMainView = QyClient.UI.Module.Channel.View.ChannelMainView;
using HomeMainView = QyClient.UI.Module.Home.View.HomeMainView;
using ParameterWrapper = QyClient.UI.MVVM.ParameterWrapper;

namespace QyClient.UI.ViewModel
{
    public class MainViewModel 
    {

        public RelayCommand<ParameterWrapper> _contentFrameLoadedCommand;

        public RelayCommand<ParameterWrapper> ContentFrameLoadedCommand => _contentFrameLoadedCommand ?? (_contentFrameLoadedCommand = new RelayCommand<ParameterWrapper>(OnContentFrameLoaded));

        private void OnContentFrameLoaded(ParameterWrapper wrapper)
        {
            NavigationController.SetCurrentFrame(wrapper.Sender as Frame);
        }


        public RelayCommand GotoHomeCommand
        {
            get
            {
                return new RelayCommand(GotoHome);
            }
        }

        public RelayCommand GotoChannelCommand
        {
            get
            {
                return new RelayCommand(GotoChannel);
            }
        }

        public void GotoHome()
        {
           NavigationTool.GetNavigator<IMainTabsNavigator>().GotoHome();
        }

        public void GotoChannel()
        {
           NavigationTool.GetNavigator<IMainTabsNavigator>().GotoChannel();

        }

        public void GotoVip()
        {
            NavigationTool.GetNavigator<IMainTabsNavigator>().GotoVip();

        }

        public void GotoSetting()
        {
            NavigationTool.GetNavigator<IMainTabsNavigator>().GotoSetting();

        }


    }
}
