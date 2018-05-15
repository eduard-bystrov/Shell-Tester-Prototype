using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Enhanced
{
	public struct LogMessage
	{
		public LogMessage(String message, params Object[] args)
		{
			Message = message;
			Args = args;
		}

		public Boolean HasMessage
		{
			get { return Message != null; }
		}

		public String Message { get; private set; }

		public Object[] Args { get; private set; }

	}
}
