using System;
using Serilog.Events;
using UnityEngine;

internal class CategoryFilteredLogHandler : ILogHandler
{
	private readonly ILogHandler m_DefaultLogHandler;

	public CategoryFilteredLogHandler(ILogHandler _defaultLogHandler)
	{
	}

	public void LogFormat(LogType _logType, UnityEngine.Object _context, string _format, params object[] _args)
	{
	}

	public void LogException(Exception _exception, UnityEngine.Object _context)
	{
	}

	private static LogEventLevel MapUnityLogTypeToSerilogLevel(LogType _type)
	{
		return LogEventLevel.Verbose;
	}
}
