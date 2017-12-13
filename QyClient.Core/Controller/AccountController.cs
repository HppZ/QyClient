using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.Core.Auth;
using QyClient.Core.DAL.Interface;
using QyClient.Core.Model;
using QyClient.Core.Navigation.INavigator;

namespace QyClient.Core.Controller
{
   public class AccountController
   {
       private IAccountRepository _repository;
        public AccountController(IAccountRepository repository)
        {
            _repository = repository;
        }

        public void Login()
        {


        }

        public void Logout()
        {
            
        }


        private void UpdateAuth()
        {
            var account = new Account();
            AuthData.Update(account);
        }



    }
}
