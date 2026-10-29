using System;
using System.Collections.Generic;

[Serializable]
public class TimelineNodeData
{
	public List<HistoryEvent> historyEvents;

	public int year;

	public float xPosition;

	public float yPosition;

	public bool isAboveLine;

	public float nodeHeight;

	public int groupIndex;

	public TimelineNodeData(int year)
	{
	}

	public void AddEvent(HistoryEvent evt)
	{
	}

	public double GetTimestamp()
	{
		return 0.0;
	}
}
