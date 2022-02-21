using MxfParser.Lib.Models;
using MxfParser.Lib.Services;
using MxfParser.Lib.Concretes;


// See https://aka.ms/new-console-template for more information
Console.WriteLine ("== Start");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine ($"Args: {args.Length}");
foreach (var arg in args)
{
    Console.WriteLine ($"  [{arg}]");
}

Parser parser = new ();
string path = @"Location://abc/file.txst";

Task.Run (async () => {
    parser = new ();
    await parser.GetTree (path);
    global::System.Console.WriteLine ($"async result [{parser.Mxf.Message}]");
    });

if(parser != null)
    Console.WriteLine ($"Result : [{parser.Mxf.Message}]");
else
    Console.WriteLine ("Null Parser");
Console.ResetColor ();
Console.WriteLine ("== End");