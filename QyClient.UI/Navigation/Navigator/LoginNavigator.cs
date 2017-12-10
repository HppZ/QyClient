using QyClient.Core.Navigation.INavigator;

namespace QyClient.UI.Navigation.Navigator
{
    class LoginNavigator: ILoginNavigator
    {
        public void GotoLogin()
        {
            NavigationController.ShowLoginDialog();
        }

    }
}
