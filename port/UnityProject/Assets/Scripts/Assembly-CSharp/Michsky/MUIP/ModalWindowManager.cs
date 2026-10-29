using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[RequireComponent(typeof(CanvasGroup))]
	public class ModalWindowManager : MonoBehaviour
	{
		public enum StartBehaviour
		{
			None = 0,
			Disable = 1,
			Enable = 2
		}

		public enum CloseBehaviour
		{
			None = 0,
			Disable = 1,
			Destroy = 2
		}

		public enum OnEnableBehaviour
		{
			None = 0,
			Restore = 1
		}

		[CompilerGenerated]
		private sealed class _003CDisableObject_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ModalWindowManager _003C_003E4__this;

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
			public _003CDisableObject_003Ed__35(int _003C_003E1__state)
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

		public Image windowIcon;

		public TextMeshProUGUI windowTitle;

		public TextMeshProUGUI windowDescription;

		public ButtonManager confirmButton;

		public ButtonManager cancelButton;

		public Animator mwAnimator;

		public Sprite icon;

		public string titleText;

		[TextArea(1, 4)]
		public string descriptionText;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		public UnityEvent onConfirm;

		public UnityEvent onCancel;

		public bool useCustomContent;

		public bool isOn;

		public bool closeOnCancel;

		public bool closeOnConfirm;

		public bool showCancelButton;

		public bool showConfirmButton;

		public StartBehaviour startBehaviour;

		public CloseBehaviour closeBehaviour;

		public OnEnableBehaviour onEnableBehaviour;

		private float cachedStateLength;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateUI()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void OpenWindow()
		{
		}

		public void CloseWindow()
		{
		}

		public void AnimateWindow()
		{
		}

		[IteratorStateMachine(typeof(_003CDisableObject_003Ed__35))]
		private IEnumerator DisableObject()
		{
			return null;
		}
	}
}
