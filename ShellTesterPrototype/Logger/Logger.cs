using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public sealed class Logger
{
    public void Write(String s)
    {
		_streamWriter.WriteLine(s);
		
    }

    private static readonly Lazy<Logger> lazy =
        new Lazy<Logger>(() => new Logger());

    public static Logger Instance { get { return lazy.Value; } }
    private Logger()
    {
		_streamWriter = new StreamWriter("Logger.txt");
		_streamWriter.AutoFlush = true;
	}

	private readonly StreamWriter _streamWriter;
}

