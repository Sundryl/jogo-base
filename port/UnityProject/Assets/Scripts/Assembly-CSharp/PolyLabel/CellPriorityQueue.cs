using System.Collections.Generic;

namespace PolyLabel
{
	internal class CellPriorityQueue
	{
		private readonly SortedList<float, Cell> queue;

		public bool HasItems => false;

		public void Enqueue(Cell cell)
		{
		}

		public Cell Dequeue()
		{
			return null;
		}
	}
}
