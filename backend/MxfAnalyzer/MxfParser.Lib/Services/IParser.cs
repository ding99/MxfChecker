using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MxfParser.Lib.Models;

namespace MxfParser.Lib.Services
{
    public interface IParser
    {
        void GetTree (string path);
    }
}
