using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using QyClient.Core.Player.Interface;
using QyClient.Core.Player.Model;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace QyClient.Core.Player.PlayerControl
{
    public sealed partial class Player : UserControl, IMediaPlayerCallback, IMediaPlayerAdCallback, IMediaPlayerBulletsCallback
    {
        public Player()
        {
            this.InitializeComponent();
            _playerCore = new PlayerCore(this, this, this, null);
        }

        private PlayerCore _playerCore;

        public PlayerCore PlayerCore
        {
            get { return _playerCore; }
            set { _playerCore = value; }
        }


        public void OnPlayStateChanged(string state)
        {
            throw new NotImplementedException();
        }

        public void ShowAd(bool show, AdModel adModel)
        {
            throw new NotImplementedException();
        }

        public void CountDown(int count)
        {
            throw new NotImplementedException();
        }

        public void ShowBullets(bool show, string bullets)
        {
            throw new NotImplementedException();
        }
    }
}
