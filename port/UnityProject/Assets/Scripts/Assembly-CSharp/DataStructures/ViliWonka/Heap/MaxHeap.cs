using System.Collections.Generic;

namespace DataStructures.ViliWonka.Heap
{
	public class MaxHeap : BaseHeap
	{
		public MaxHeap(int initialSize = 2048)
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
	}
	public class MaxHeap<T> : MaxHeap
	{
		private T[] objs;

		private T tempObjs;

		public T HeadHeapObject => default;

		public MaxHeap(int maxNodes)
			: base(0)
		{
		}

		protected override void Swap(int A, int B)
		{
		}

		public override void PushValue(float h)
		{
		}

		public override float PopValue()
		{
			return 0f;
		}

		public void PushObj(T obj, float h)
		{
		}

		public T PopObj()
		{
			return default;
		}

		public T PopObj(ref float heapValue)
		{
			return default;
		}

		protected override void UpsizeHeap()
		{
		}

		public void FlushResult(List<T> resultList, List<float> heapList = null)
		{
		}
	}
}
