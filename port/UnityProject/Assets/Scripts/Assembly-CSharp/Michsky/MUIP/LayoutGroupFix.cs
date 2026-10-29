using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	[AddComponentMenu("Modern UI Pack/Layout/Layout Group Fix")]
	[DisallowMultipleComponent]
	public class LayoutGroupFix : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFixDelay_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LayoutGroupFix _003C_003E4__this;

			object IEnumerator<object>.Current
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
			public _003CFixDelay_003Ed__5(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private bool fixOnEnable;

		[SerializeField]
		private bool fixWithDelay;

		private float fixDelay;

		private void OnEnable()
		{
		}

		public void FixLayout()
		{
		}

		[IteratorStateMachine(typeof(_003CFixDelay_003Ed__5))]
		private IEnumerator FixDelay()
		{
			return null;
		}
	}
}
