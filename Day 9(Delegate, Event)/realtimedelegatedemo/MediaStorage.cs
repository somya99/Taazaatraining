using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realtimedelegatedemo
{
    public class MediaStorage
    {
        public delegate int PlayerMedia(string a);
        public void ReportResult(PlayerMedia p, string type)
        {
            var status = p(type);
            if(status == 0)
            {
                Console.WriteLine("Media played successully");
            }
            else
            {
                Console.WriteLine("Media did not played successfully");
            }
        }
    }
}
