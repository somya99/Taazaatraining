using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realtimedelegatedemo
{
    public class VideoPlayer
    {
        private int VideoPlayerStatus;
        public int PlayVideoFile(string extensionType)
        {
            if(extensionType != "mp4")
            {
                VideoPlayerStatus = -1;
            }
            else
            {
                VideoPlayerStatus = 0;
            }
            return VideoPlayerStatus;
        }
    }
}
