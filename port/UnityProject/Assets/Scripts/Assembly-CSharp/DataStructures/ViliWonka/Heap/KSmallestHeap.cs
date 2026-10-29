using System.Collections.Generic;

namespace DataStructures.ViliWonka.Heap
{
	public class KSmallestHeap : BaseHeap
	{
		public bool Full => false;

		public KSmallestHeap(int maxEntries)
			: base(0)
		{
		}

		public override void PushValue(float h)
		{
		}

		public override float PopValue()
		{
			return 0f;
		}

		public void Print()
		{
		}

		public bool HeapPropertyHolds(int index, int depth = 0)
		{
			return false;
		}
	}
	public class KSmallestHeap<T> : KSmallestHeap
	{
		private T[] objs;

		private T tempObjs;

		public T HeadHeapObject => default;

		public KSmallestHeap(int maxEntries)
			: base(0)
		{
		}

		protected override void Swap(int A, int B)
		{
		}

		public override void PushValue(float h)
		{
		}

		public void PushObj(T obj, float h)
		{
		}

		public override float PopValue()
		{
			return 0f;
		}

		public T PopObj()
		{
			return default;
		}

		public T PopObj(ref float heapValue)
		{
			return default;
		}

		public void FlushResult(List<T> resultList, List<float> heapList = null)
		{
		}
	}
}
