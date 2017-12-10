using QyClient.Core.Controller;

namespace QyClient.UI.Module.Home.ViewModel
{
    public class HomeMainViewModel
    {

        public string Data { get; set; }

        public HomeMainViewModel()
        {
            Data = "";
            var banners = QyClientControllerAccess.ContentController.GetBanners();
            foreach (var banner in banners)
            {
                Data += banner;
            }
        }
    }
}
