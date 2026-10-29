using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Serilog.Events;
using UnityEngine;

public class LoggingService : MonoBehaviour
{
	[Serializable]
	public class LogCategoryConfig
	{
		public string category;

		public bool enabled;

		public LogEventLevel minLevel;
	}

	private static LoggingService s_Instance;

	private static string s_SessionTimestamp;

	private static ILogHandler s_PreviousLogHandler;

	[Header("Global Settings")]
	[SerializeField]
	private bool m_EnableLogging;

	[SerializeField]
	private int m_DaysToKeepLogs;

	[SerializeField]
	[Header("Unity Log Type Filters")]
	private bool m_LogUnityDebug;

	[SerializeField]
	private bool m_LogUnityWarning;

	[SerializeField]
	private bool m_LogUnityError;

	[Header("Log Categories")]
	[SerializeField]
	private List<LogCategoryConfig> m_Categories;

	private static Dictionary<string, LogCategoryConfig> s_CategoryLookup;

	private static readonly Regex s_CategoryRegex;

	private void Awake()
	{
	}

	private void HandleUnityLog(string _logString, string _stackTrace, LogType _type)
	{
	}

	internal static bool IsCategoryEnabled(string _category, LogEventLevel _level)
	{
		return false;
	}

	private void RemoveLatestPrefix(string _logPath)
	{
	}

	private void CleanupOldLogs(string _logPath, int _daysToKeep)
	{
	}

	private void OnDestroy()
	{
	}

	public static void SetCategoryEnabled(string _category, bool _enabled)
	{
	}

	public static void SetCategoryMinLevel(string _category, LogEventLevel _level)
	{
	}

	public static List<string> GetCategories()
	{
		return null;
	}

	public static void SetLogUnityDebug(bool _enabled)
	{
	}

	public static void SetLogUnityWarning(bool _enabled)
	{
	}

	public static void SetLogUnityError(bool _enabled)
	{
	}

	internal static bool ShouldFilterConsole()
	{
		return false;
	}

	internal static bool ShouldAllowConsoleLogType(LogType _type)
	{
		return false;
	}

	internal static void ParseCategoryAndMessage(string _logString, out string _category, out string _message)
	{
		_category = null;
		_message = null;
	}
}
