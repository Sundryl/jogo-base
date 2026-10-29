using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Animator))]
	public class NotificationManager : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public enum StartBehaviour
		{
			None = 0,
			Disable = 1,
			Open = 2
		}

		public enum CloseBehaviour
		{
			None = 0,
			Disable = 1,
			Destroy = 2
		}

		public enum SlideDirection
		{
			Default = 0,
			Left = 1,
			Right = 2
		}

		[CompilerGenerated]
		private sealed class _003CStartTimer_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NotificationManager _003C_003E4__this;

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
			public _003CStartTimer_003Ed__29(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CDisableNotification_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NotificationManager _003C_003E4__this;

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
			public _003CDisableNotification_003Ed__30(int _003C_003E1__state)
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

		public Sprite icon;

		public string title;

		[TextArea(1, 4)]
		public string description;

		public Animator notificationAnimator;

		public Image iconObj;

		public TextMeshProUGUI titleObj;

		public TextMeshProUGUI descriptionObj;

		public bool enableTimer;

		public float timer;

		[SerializeField]
		private bool useCustomContent;

		public bool closeOnClick;

		public bool useStacking;

		[HideInInspector]
		public bool isOn;

		public StartBehaviour startBehaviour;

		public CloseBehaviour closeBehaviour;

		public SlideDirection slideDirection;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void OpenNotification()
		{
		}

		public void CloseNotification()
		{
		}

		public void UpdateUI()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[IteratorStateMachine(typeof(_003CStartTimer_003Ed__29))]
		private IEnumerator StartTimer()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDisableNotification_003Ed__30))]
		private IEnumerator DisableNotification()
		{
			return null;
		}
	}
}
