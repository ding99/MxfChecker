using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MxfParser.Lib.Services;
using MxfParser.Lib.Models;

namespace MxfParser.Lib.Concretes
{
    public partial class Parser : IParser
    {
        private readonly MxfInfo mxf;

        public Parser ()
        {
            this.mxf = new ();
        }

        public MxfInfo Mxf { get => this.mxf; }

        public async Task GetTree(string path)
        {
            await Task.Run (() =>
            {
                this.mxf.Message = "Ready to Parse";
                Console.WriteLine ("Running...");
            });

            if (string.IsNullOrEmpty (this.mxf.Message))
                this.mxf.Message = "Need to append something";
        }
    }
}
