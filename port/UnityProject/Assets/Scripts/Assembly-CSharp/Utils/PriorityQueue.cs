using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Utils
{
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(PriorityQueueDebugView<, >))]
	public class PriorityQueue<TElement, TPriority> where TElement : notnull where TPriority : notnull
	{
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(PriorityQueueDebugView<, >))]
		public sealed class UnorderedItemsCollection : IReadOnlyCollection<(TElement, TPriority)>, IEnumerable<(TElement, TPriority)>, IEnumerable, ICollection
		{
			public struct Enumerator : IEnumerator<(TElement, TPriority)>, IEnumerator, IDisposable
			{
				private readonly PriorityQueue<TElement, TPriority> _queue;

				private readonly int _version;

				private int _index;

				public (TElement Element, TPriority Priority) Current { get; private set; }

				object IEnumerator.Current => null;

				internal Enumerator(PriorityQueue<TElement, TPriority> queue)
				{
					_queue = null;
					_version = 0;
					_index = 0;
					Current = default;
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				private bool MoveNextRare()
				{
					return false;
				}

				void IEnumerator.Reset()
				{
				}
			}

			internal readonly PriorityQueue<TElement, TPriority> _queue;

			object ICollection.SyncRoot => null;

			bool ICollection.IsSynchronized => false;

			public int Count => 0;

			internal UnorderedItemsCollection(PriorityQueue<TElement, TPriority> queue)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default;
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}

			IEnumerator<(TElement, TPriority)> IEnumerable<(TElement, TPriority)>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private const int Arity = 4;

		private const int Log2Arity = 2;

		private (TElement Element, TPriority Priority)[] _nodes;

		private readonly IComparer<TPriority>? _comparer;

		private UnorderedItemsCollection? _unorderedItems;

		private int _size;

		private int _version;

		public int Count => 0;

		public IComparer<TPriority> Comparer => null;

		public UnorderedItemsCollection UnorderedItems => null;

		public PriorityQueue()
		{
		}

		public PriorityQueue(int initialCapacity)
		{
		}

		public PriorityQueue(IComparer<TPriority>? comparer)
		{
		}

		public PriorityQueue(int initialCapacity, IComparer<TPriority>? comparer)
		{
		}

		public PriorityQueue(IEnumerable<(TElement Element, TPriority Priority)> items)
		{
		}

		public PriorityQueue(IEnumerable<(TElement Element, TPriority Priority)> items, IComparer<TPriority>? comparer)
		{
		}

		public void Enqueue(TElement element, TPriority priority)
		{
		}

		public TElement Peek()
		{
			return default;
		}

		public TElement Dequeue()
		{
			return default;
		}

		public bool TryDequeue([MaybeNullWhen(false)] out TElement element, [MaybeNullWhen(false)] out TPriority priority)
		{
			element = default;
			priority = default;
			return false;
		}

		public bool TryPeek([MaybeNullWhen(false)] out TElement element, [MaybeNullWhen(false)] out TPriority priority)
		{
			element = default;
			priority = default;
			return false;
		}

		public TElement EnqueueDequeue(TElement element, TPriority priority)
		{
			return default;
		}

		public void EnqueueRange(IEnumerable<(TElement Element, TPriority Priority)> items)
		{
		}

		public void EnqueueRange(IEnumerable<TElement> elements, TPriority priority)
		{
		}

		public void Clear()
		{
		}

		public int EnsureCapacity(int capacity)
		{
			return 0;
		}

		public void TrimExcess()
		{
		}

		private void Grow(int minCapacity)
		{
		}

		private void RemoveRootNode()
		{
		}

		private static int GetParentIndex(int index)
		{
			return 0;
		}

		private static int GetFirstChildIndex(int index)
		{
			return 0;
		}

		private void Heapify()
		{
		}

		private void MoveUpDefaultComparer((TElement Element, TPriority Priority) node, int nodeIndex)
		{
		}

		private void MoveUpCustomComparer((TElement Element, TPriority Priority) node, int nodeIndex)
		{
		}

		private void MoveDownDefaultComparer((TElement Element, TPriority Priority) node, int nodeIndex)
		{
		}

		private void MoveDownCustomComparer((TElement Element, TPriority Priority) node, int nodeIndex)
		{
		}

		private static IComparer<TPriority> InitializeComparer(IComparer<TPriority>? comparer)
		{
			return null;
		}
	}
}
