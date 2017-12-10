using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QyClient.Core.Controller
{
    public class ContentController
    {

        public List<string> GetBanners()
        {
            // web business
            return new List<string>()
            {
                "电影",
                "电视",
                "动漫",
                "新闻",
            };
        }

    }
}
