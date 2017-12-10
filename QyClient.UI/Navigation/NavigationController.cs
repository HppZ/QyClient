using System;
using Windows.UI.Xaml.Controls;

namespace QyClient.UI.Navigation
{
    static class NavigationController
    {
        private static Frame _mainFrame;
        private static Frame _curFrame;

        public static void SetMainFrame(Frame frame)
        {
            _mainFrame = frame;
        }

        public static void SetCurrentFrame(Frame frame)
        {
            _curFrame = frame;
        }

        public static void RootNavigateTo()
        {

        }

        public static void NavigateTo(Type pageType, object param)
        {
            _curFrame.Navigate(pageType, param);
        }

        public static void ShowLoginDialog()
        {
            
        }

    }
}
