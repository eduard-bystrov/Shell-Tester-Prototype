using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class Logger
{
    public void Write(String s)
    {
        Console.WriteLine(s);
    }

    private static readonly Lazy<Logger> lazy =
        new Lazy<Logger>(() => new Logger());

    public static Logger Instance { get { return lazy.Value; } }
    private Logger()
    {
    }
}

