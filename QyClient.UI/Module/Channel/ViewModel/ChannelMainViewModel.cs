using QyClient.Core.Controller;

namespace QyClient.UI.Module.Channel.ViewModel
{
    public class ChannelMainViewModel
    {

        public string Data { get; set; }

        public ChannelMainViewModel()
        {
            var data = QyClientControllerAccess.ChannelController.GetData();
            Data = data;
        }
    }
}
