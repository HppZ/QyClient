using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QyClient.Core.Player
{
    interface IMediaPlayerBullets
    {
        void Open(bool open);
        void SetBulletsFontSize();
        void GetEmojiList();
        void SetMyBulletsColor();
        // void OnBulletsFinished(string id); // 一组显示结束
    }
}
