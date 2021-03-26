//audioplayer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realtimedelegatedemo
{
    public class AudioPlayer
    {
        private int AudioPlayerStatus;
        public int PlayAudioFile(string extensionType)
        {
            if (extensionType != "wmv")
            {
                AudioPlayerStatus = -1;
            }
            else
            {
                AudioPlayerStatus = 0;
            }
            return AudioPlayerStatus;
        }
    }
}
