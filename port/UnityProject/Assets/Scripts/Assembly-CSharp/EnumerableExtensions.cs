using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public static class EnumerableExtensions
{
	[CompilerGenerated]
	private sealed class _003CChunk_003Ed__0<T> : IEnumerable<IEnumerable<T>>, IEnumerable, IEnumerator<IEnumerable<T>>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private IEnumerable<T> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int size;

		public int _003C_003E3__size;

		private IEnumerable<T> source;

		public IEnumerable<T> _003C_003E3__source;

		private IEnumerator<T> _003C_003E7__wrap1;

		IEnumerable<T> IEnumerator<IEnumerable<T>>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CChunk_003Ed__0(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<IEnumerable<T>> IEnumerable<IEnumerable<T>>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[IteratorStateMachine(typeof(_003CChunk_003Ed__0<>))]
	public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int size)
	{
		return null;
	}
}
