using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realtimedelegatedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaStorage m = new MediaStorage();
            AudioPlayer ap = new AudioPlayer();
            VideoPlayer vp = new VideoPlayer();

            MediaStorage.PlayerMedia playDelegate = ap.PlayAudioFile;
            playDelegate += vp.PlayVideoFile;
            m.ReportResult(playDelegate, "mp3");
            m.ReportResult(playDelegate, "mp4");
            Console.ReadKey(true);
        }
    }
}
