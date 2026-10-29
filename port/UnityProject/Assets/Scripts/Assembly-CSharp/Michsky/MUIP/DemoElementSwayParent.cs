using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Michsky.MUIP
{
	public class DemoElementSwayParent : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSWMHelper_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DemoElementSwayParent _003C_003E4__this;

			public int index;

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
			public _003CSWMHelper_003Ed__9(int _003C_003E1__state)
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
		private Animator titleAnimator;

		[SerializeField]
		private TextMeshProUGUI elementTitle;

		[SerializeField]
		private TextMeshProUGUI elementTitleHelper;

		private List<DemoElementSway> elements;

		private int prevIndex;

		private void Awake()
		{
		}

		public void DissolveAll(DemoElementSway currentSway)
		{
		}

		public void HighlightAll()
		{
		}

		public void SetWindowManagerButton(int index)
		{
		}

		[IteratorStateMachine(typeof(_003CSWMHelper_003Ed__9))]
		private IEnumerator SWMHelper(int index)
		{
			return null;
		}
	}
}
