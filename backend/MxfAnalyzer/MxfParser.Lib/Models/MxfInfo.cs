using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MxfParser.Lib.Models
{
    public class MxfInfo
    {
        public string Message { get; set; } 
        public List<Track> Tracks { get; set; }
        public VideoInfo VideoInfo { get; set; }
        public SoundInfo SoundInfo { get; set; }
        public TextInfo TextInfo { get; set; }

        public MxfInfo ()
        {
            this.Message = string.Empty;
            this.Tracks = new ();
            this.VideoInfo = new ();
            this.SoundInfo = new ();
            this.TextInfo = new ();
        }
    }
}
