using System;
using System.Collections.Generic;

[Serializable]
public class TimeSerializationData
{
	public float SecondsPerDay { get; set; }

	public int StartYear { get; set; }

	public int StartMonth { get; set; }

	public int StartDay { get; set; }

	public float GameTime { get; set; }

	public List<double> HistoryTimePoints { get; set; }

	public List<float> OverflowTimePoints { get; set; }

	public double CalendarTimeOffsetSeconds { get; set; }
}
