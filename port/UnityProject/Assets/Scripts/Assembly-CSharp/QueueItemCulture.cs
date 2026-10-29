using System;

public class QueueItemCulture : IComparable<QueueItemCulture>
{
	public int Priority { get; set; }

	public int CellID { get; set; }

	public int CultureID { get; set; }

	public int CompareTo(QueueItemCulture other)
	{
		return 0;
	}
}
