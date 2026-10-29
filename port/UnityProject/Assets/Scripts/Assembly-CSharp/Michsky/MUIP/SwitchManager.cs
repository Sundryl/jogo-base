using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(Animator))]
	public class SwitchManager : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
	{
		[Serializable]
		public class SwitchEvent : UnityEvent<bool>
		{
		}

		[CompilerGenerated]
		private sealed class _003CDisableAnimator_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SwitchManager _003C_003E4__this;

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
			public _003CDisableAnimator_003Ed__25(int _003C_003E1__state)
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
		public SwitchEvent onValueChanged;

		public UnityEvent OnEvents;

		public UnityEvent OffEvents;

		public bool saveValue;

		public string switchTag;

		public bool isOn;

		public bool invokeAtStart;

		public bool enableSwitchSounds;

		public bool useHoverSound;

		public bool useClickSound;

		public Animator switchAnimator;

		public Button switchButton;

		public AudioSource soundSource;

		public AudioClip hoverSound;

		public AudioClip clickSound;

		private bool isInitialized;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void GetSavedData()
		{
		}

		public void AnimateSwitch()
		{
		}

		public void SetOn()
		{
		}

		public void SetOff()
		{
		}

		public void UpdateUI()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[IteratorStateMachine(typeof(_003CDisableAnimator_003Ed__25))]
		private IEnumerator DisableAnimator()
		{
			return null;
		}
	}
}
