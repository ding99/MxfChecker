using MxfParser.Lib;
using MxfParser.Lib.Models;
using MxfParser.Lib.Services;
using MxfParser.Lib.Concretes;

namespace CheckMxf;

class Program
{
    static void Main ()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine ("== Start");

        string path = @"local:\abc\file.txt";

        Parser parser = new ();

        string message = string.Empty;

        Task.Run (async () =>
        {
            await parser.GetTree (path);
        });

        message = parser.Mxf.Message;

        Console.WriteLine ($"Result : [{message}]");
    }
}

