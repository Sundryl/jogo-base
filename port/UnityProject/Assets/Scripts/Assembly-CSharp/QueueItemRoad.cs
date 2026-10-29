using System;

public class QueueItemRoad : IComparable<QueueItemRoad>
{
	public float Priority { get; set; }

	public int e { get; set; }

	public int CompareTo(QueueItemRoad other)
	{
		return 0;
	}
}
