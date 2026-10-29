using System.Diagnostics;

namespace Utils
{
	internal sealed class PriorityQueueDebugView<TElement, TPriority> where TElement : notnull where TPriority : notnull
	{
		private readonly PriorityQueue<TElement, TPriority> _queue;

		private readonly bool _sort;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public (TElement Element, TPriority Priority)[] Items => null;

		public PriorityQueueDebugView(PriorityQueue<TElement, TPriority> queue)
		{
		}

		public PriorityQueueDebugView(PriorityQueue<TElement, TPriority>.UnorderedItemsCollection collection)
		{
		}
	}
}
