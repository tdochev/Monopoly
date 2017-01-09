using System;

using Monopoly.Contracts;

namespace Monopoly.Engine
{
	public class ConsoleLogger : ILogger
	{
		//TODO: implement singleton
		public ConsoleLogger()
		{
		}

		public void Log(object message)
		{
			Console.WriteLine(message.ToString());
		}
	}
}
