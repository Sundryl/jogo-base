using System.Collections.Generic;
using NodaTime;
using Unity.Profiling;

public class TimeManager
{
	private static TimeManager _instance;

	private static readonly LocalDate c_MaxSupportedDate;

	private static readonly LocalDate c_MinSupportedDate;

	private static readonly ProfilerMarker s_MonthlyAssignUpdateDaysMarker;

	private static readonly ProfilerMarker s_MonthlyPopulationMedianMarker;

	private static readonly ProfilerMarker s_MonthlyDiplomacyMarker;

	private static readonly ProfilerMarker s_MonthlyWarV1Marker;

	private static readonly ProfilerMarker s_MonthlyWarV2Marker;

	private static readonly ProfilerMarker s_MonthlyCharactersMarker;

	private static readonly ProfilerMarker s_MonthlyFamiliesMarker;

	private static readonly ProfilerMarker s_MonthlyPopulationVisualizerMarker;

	private static readonly ProfilerMarker s_DailyProvincesMarker;

	private static readonly ProfilerMarker s_DailyStatesMarker;

	private static readonly ProfilerMarker s_DailyFamiliesMarker;

	private static readonly ProfilerMarker s_DailyVassalsMarker;

	private static readonly ProfilerMarker s_YearlyCaptureHistoryMarker;

	private static readonly ProfilerMarker s_YearlyStatesMarker;

	private static readonly ProfilerMarker s_YearlyFamiliesMarker;

	public List<double> HistoryTimePoints;

	public float secondsPerDay;

	public int startYear;

	public int startMonth;

	public int startDay;

	private float gameTime;

	private float gameTimeCounter;

	private double calendarTimeOffsetSeconds;

	public int prevDayCount;

	private LocalDate currentDate;

	private LocalDate startDate;

	public static TimeManager Instance => null;

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	public static TimeSerializationData ParseJsonOnly(string json)
	{
		return null;
	}

	public void ApplyParsedData(TimeSerializationData data)
	{
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	public float GetTime()
	{
		return 0f;
	}

	public double GetCalendarTimeOffsetSeconds()
	{
		return 0.0;
	}

	public void ClearCustomCalendarDateOffset()
	{
	}

	public bool SetCustomCalendarDate(int _year, int _month, int _day, bool _isAD)
	{
		return false;
	}

	public int GetYearSince(double time)
	{
		return 0;
	}

	public int GetMonthSince(double time)
	{
		return 0;
	}

	public int GetDayBetween(double time1, double time2)
	{
		return 0;
	}

	private void AdvanceOneDay()
	{
	}

	public int GetCurrentMonth()
	{
		return 0;
	}

	public void CaptureHistory()
	{
	}

	public void ClearHistoryData()
	{
	}

	public LocalDate GetDate(double gameTime)
	{
		return default;
	}

	public string GetDateString(double t)
	{
		return null;
	}

	public string GetYearString(double t)
	{
		return null;
	}

	public string GetDateStringTranslation(double t, bool isNeedDefaultFont = false, bool useShortFormat = true)
	{
		return null;
	}

	public string GetDateStringNoYear(double t)
	{
		return null;
	}

	internal int GetYear(double timestamp)
	{
		return 0;
	}

	internal void Clear()
	{
	}

	public float GetBirthTimeFromAge(float ageInYears)
	{
		return 0f;
	}

	public LocalDate GetDisplayDate(double _gameTime)
	{
		return default;
	}

	private static int ConvertToDisplayYear(int _isoYear)
	{
		return 0;
	}

	private LocalDate GetDateByDayCount(int _dayCount)
	{
		return default;
	}

	private double GetDisplayTime(double t)
	{
		return 0.0;
	}
}
