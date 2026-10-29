using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[RequireComponent(typeof(Toggle))]
	[RequireComponent(typeof(Animator))]
	public class CustomToggle : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDisableAnimator_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CustomToggle _003C_003E4__this;

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
			public _003CDisableAnimator_003Ed__8(int _003C_003E1__state)
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

		[HideInInspector]
		public Toggle toggleObject;

		[HideInInspector]
		public Animator toggleAnimator;

		[Header("Settings")]
		public bool invokeOnAwake;

		private bool isInitialized;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void UpdateState()
		{
		}

		public void UpdateState(bool value)
		{
		}

		[IteratorStateMachine(typeof(_003CDisableAnimator_003Ed__8))]
		private IEnumerator DisableAnimator()
		{
			return null;
		}
	}
}
