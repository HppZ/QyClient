using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QyClient.Core.Web.BusinessResponse
{
    abstract class WebBusinessResponseBase
    {


        public bool Succeed { get; set; }
        public string Message { get; set; }
        // ...

    }
}
