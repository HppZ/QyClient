using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using puma_dll_uwp;
using puma_dll_uwp.Structs;

namespace QyClient.Core.Player
{
    /// <summary>
    /// puma回调
    /// </summary>
   partial class PlayerCore :   IQYPlayerCallback
    {
        public void OnSeekSuccess(long msec)
        {
            throw new NotImplementedException();
        }

        public void OnWaiting(bool value)
        {
            throw new NotImplementedException();
        }

        public void OnPlayerStateChanged(int to_state)
        {
            throw new NotImplementedException();
        }

        public void OnVideoRenderAreaChanged(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void OnBitStreamChanging(int from_bitstream, int to_bitstream, int duration)
        {
            throw new NotImplementedException();
        }

        public void OnBitStreamChanged(int from_bitstream, int to_bitstream)
        {
            throw new NotImplementedException();
        }

        public void OnTrialWatching(int try_and_see_type, long start_time, long end_time, string auth_result)
        {
            throw new NotImplementedException();
        }

        public void OnShowSubtitle(string subtitle)
        {
            throw new NotImplementedException();
        }

        public void OnSubtitleStateChange(string path, int codec_id, bool inside, bool success, bool close)
        {
            throw new NotImplementedException();
        }

        public void OnAdCallback(int command, string @params)
        {
            throw new NotImplementedException();
        }

        public void OnStart()
        {
            throw new NotImplementedException();
        }

        public void OnError(QYPlayerError error_no)
        {
            throw new NotImplementedException();
        }

        public void OnSendPingback(int type, int param)
        {
            throw new NotImplementedException();
        }

        public void OnP2PCallback(int command, string @params)
        {
            throw new NotImplementedException();
        }

        public void OnLiveStreamCallback(int command, string @params)
        {
            throw new NotImplementedException();
        }

        public void OnAudioTrackChanging(QYPlayerAudioTrackLanguage from_audiotrack, QYPlayerAudioTrackLanguage to_audiotrack,
            int duration)
        {
            throw new NotImplementedException();
        }

        public void OnAudioTrackChanged(QYPlayerAudioTrackLanguage from_audiotrack, QYPlayerAudioTrackLanguage to_audiotrack)
        {
            throw new NotImplementedException();
        }

        public void OnAdPrepared()
        {
            throw new NotImplementedException();
        }

        public void OnPrepared()
        {
            throw new NotImplementedException();
        }

        public void OnSubtitleLanguageChanged(int current_subtitle_language)
        {
            throw new NotImplementedException();
        }

        public void OnQYPlayerCallback(int command, string @params)
        {
            throw new NotImplementedException();
        }
    }
}
