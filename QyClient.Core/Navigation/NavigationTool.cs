using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace QyClient.Core.Navigation
{
    public static class NavigationTool
    {
        private static readonly Dictionary<Type, Type> _navigators = new Dictionary<Type, Type>();

        public static T GetNavigator<T>() where T : INavigator.INavigator
        {
            var type = typeof(T);
            if (_navigators.ContainsKey(type))
            {
                var nav = _navigators[type];
                return (T) Activator.CreateInstance(nav);
            }

            return default(T);
        }

        public static void RegisterNavigator<TAbs, TImpl>( ) where TImpl : TAbs, INavigator.INavigator, new()
        {
            var keyType = typeof(TAbs);
            if (!_navigators.ContainsKey(keyType))
            {
                _navigators.Add(keyType, typeof(TImpl));
            }
        }


    }
}
