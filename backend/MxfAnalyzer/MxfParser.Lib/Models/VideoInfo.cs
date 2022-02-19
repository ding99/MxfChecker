using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MxfParser.Lib.Models
{
    public class VideoInfo
    {
        public List<Video> Videos { get; set; }

        public VideoInfo ()
        {
            this.Videos = new ();
        }
    }
}
