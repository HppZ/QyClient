using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.Core.Model;

namespace QyClient.Core.Auth
{
    internal static class AuthData
    {
        public static event Action AuthDataUpdated;

        public static string account { get; private set; }
        public static string cookie { get; private set; }

  
        public static void Update(string a, string c)
        {
            account = a;
            cookie = c;

            AuthDataUpdated?.Invoke();
        }

    }
}
