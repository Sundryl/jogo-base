using System;
using System.Collections.Generic;
using System.Diagnostics;

public sealed class SaveLoadPerfSession : IDisposable
{
	private readonly struct PhaseEntry
	{
		public readonly string Name;

		public readonly double ElapsedMs;

		public readonly double Ratio;

		public readonly int CallCount;

		public PhaseEntry(string _name, double _elapsedMs, double _ratio, int _callCount)
		{
			Name = null;
			ElapsedMs = 0.0;
			Ratio = 0.0;
			CallCount = 0;
		}
	}

	private sealed class PhaseScope : IDisposable
	{
		private SaveLoadPerfSession m_Session;

		private readonly string m_PhaseName;

		private readonly Stopwatch m_Stopwatch;

		public PhaseScope(SaveLoadPerfSession _session, string _phaseName)
		{
		}

		public void Dispose()
		{
		}
	}

	private sealed class NoOpScope : IDisposable
	{
		public static readonly NoOpScope Instance;

		private NoOpScope()
		{
		}

		public void Dispose()
		{
		}
	}

	[ThreadStatic]
	private static SaveLoadPerfSession s_CurrentSession;

	private readonly Dictionary<string, long> m_ElapsedTicksByPhase;

	private readonly Dictionary<string, int> m_CallCountByPhase;

	private readonly Dictionary<string, int> m_PayloadCharsByKey;

	private readonly Stopwatch m_TotalStopwatch;

	private readonly SaveLoadPerfSession m_PreviousSession;

	private readonly string m_SessionName;

	private readonly long m_StartMemoryBytes;

	private bool m_IsCompleted;

	private SaveLoadPerfSession(string _sessionName)
	{
	}

	public static SaveLoadPerfSession Begin(string _sessionName)
	{
		return null;
	}

	public static IDisposable MeasureCurrent(string _phaseName)
	{
		return null;
	}

	public IDisposable Measure(string _phaseName)
	{
		return null;
	}

	public void RecordPayloadSizeChars(string _payloadName, int _charCount)
	{
	}

	public void CompleteSuccess()
	{
	}

	public void CompleteFailure(string _reason)
	{
	}

	private void CompleteInternal(bool _isSuccess, string _reason)
	{
	}

	private void AddPhaseSample(string _phaseName, long _elapsedTicks)
	{
	}

	public void Dispose()
	{
	}

	private static void LogPhaseSubset(List<PhaseEntry> phaseEntries, string phasePrefix, int maxCount)
	{
	}
}
