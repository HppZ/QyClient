﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QyClient.Core.Player.Interface
{
    interface IMediaPlayerAd
    {
        void Setup();
        void SkipAd();
        void ClickEvent();
    }
}
