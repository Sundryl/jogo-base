using System;

public class QueueItemState : IComparable<QueueItemState>
{
	public int s;

	public int b;

	public float p { get; set; }

	public int e { get; set; }

	public int CompareTo(QueueItemState other)
	{
		return 0;
	}
}
