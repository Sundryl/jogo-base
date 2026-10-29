using System.Collections.Generic;

namespace DataStructures.ViliWonka.Heap
{
	public abstract class BaseHeap
	{
		protected int nodesCount;

		protected int maxSize;

		protected float[] heap;

		protected float tempHeap;

		public int Count => 0;

		public float HeadValue => 0f;

		protected BaseHeap(int initialSize)
		{
		}

		public void Clear()
		{
		}

		protected int Parent(int index)
		{
			return 0;
		}

		protected int Left(int index)
		{
			return 0;
		}

		protected int Right(int index)
		{
			return 0;
		}

		protected void BubbleDownMax(int index)
		{
		}

		protected void BubbleUpMax(int index)
		{
		}

		protected void BubbleDownMin(int index)
		{
		}

		protected void BubbleUpMin(int index)
		{
		}

		protected virtual void Swap(int A, int B)
		{
		}

		protected virtual void UpsizeHeap()
		{
		}

		public virtual void PushValue(float h)
		{
		}

		public virtual float PopValue()
		{
			return 0f;
		}

		public void FlushHeapResult(List<float> heapList)
		{
		}
	}
}
