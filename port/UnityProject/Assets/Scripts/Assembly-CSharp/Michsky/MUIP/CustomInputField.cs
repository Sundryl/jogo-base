using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Michsky.MUIP
{
	[RequireComponent(typeof(TMP_InputField))]
	[RequireComponent(typeof(Animator))]
	public class CustomInputField : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDisableAnimator_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CustomInputField _003C_003E4__this;

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
			public _003CDisableAnimator_003Ed__20(int _003C_003E1__state)
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

		[Header("Resources")]
		public TMP_InputField inputText;

		public Animator inputFieldAnimator;

		[Header("Settings")]
		public bool processSubmit;

		public bool clearOnSubmit;

		[Header("Events")]
		public UnityEvent onSubmit;

		private float cachedDuration;

		private string inAnim;

		private string outAnim;

		private string instaInAnim;

		private string instaOutAnim;

		private bool isActive;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void Initialize()
		{
		}

		public void AnimateIn()
		{
		}

		public void AnimateOut()
		{
		}

		public void UpdateState()
		{
		}

		public void UpdateStateInstant()
		{
		}

		private void HandleEndEdit()
		{
		}

		[IteratorStateMachine(typeof(_003CDisableAnimator_003Ed__20))]
		private IEnumerator DisableAnimator()
		{
			return null;
		}
	}
}
