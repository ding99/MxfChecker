using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MxfParser.Lib.Models
{
    public class SoundInfo
    {
        public List<Sound> Sounds { get; set; }

        public SoundInfo ()
        {
            this.Sounds = new ();
        }
    }
}
