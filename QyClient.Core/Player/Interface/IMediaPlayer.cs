using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QyClient.Core.Player.Interface
{
    interface IMediaPlayer
    {
        void Init(); 
        void Play();
        void Stop();
        void Pause();
        void Mute(bool isMute);
        void SetVolume(int value);
        void Seek(long msec);
        void Release();

        /// <summary>
        /// value:   -270 -180 -90 0 90 180 270 度顺时针旋转。
        /// </summary>
        /// <param name="value"></param>
        void Rotate(int value);
    }
}
