using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using GalaSoft.MvvmLight.Command;
using QyClient.UI.Navigation;
using QyClient.UI.Navigation.Interface;
using ChannelMainView = QyClient.UI.Module.Channel.View.ChannelMainView;
using HomeMainView = QyClient.UI.Module.Home.View.HomeMainView;
using ParameterWrapper = QyClient.UI.MVVM.ParameterWrapper;

namespace QyClient.UI.ViewModel
{
    public class MainViewModel : IMainTabsNavigator
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
