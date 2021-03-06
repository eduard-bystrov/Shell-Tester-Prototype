﻿using System;
using System.IO;

namespace ShellTester
{
	public class Test
	{
		public Test(
			StreamReader input,
			StreamReader output,
			String id,
			Int32 timeLimit_ms,
			Int32 memoryLimit_mb,
			Int32 price
		)
		{
			InputStream = input;
			IdealOutputStream = output;
			Id = id;
			TimeLimit_ms = timeLimit_ms;
			MemoryLimit_mb = memoryLimit_mb;
			Price = price;
		}

		public StreamReader InputStream { get; }
		public StreamReader IdealOutputStream { get; }
		public String Id { get; }
		public Int32 TimeLimit_ms { get;}
		public Int32 MemoryLimit_mb { get; }
		public Int32 Price { get; }

	}
}