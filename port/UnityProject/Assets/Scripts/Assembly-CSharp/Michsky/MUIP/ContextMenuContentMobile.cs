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
	[AddComponentMenu("Modern UI Pack/Context Menu/Context Menu Content (Mobile)")]
	public class ContextMenuContentMobile : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Serializable]
		public class ContextItem
		{
			public string itemText;

			public Sprite itemIcon;

			public ContextItemType contextItemType;

			public UnityEvent onClick;
		}

		public enum ContextItemType
		{
			BUTTON = 0
		}

		[CompilerGenerated]
		private sealed class _003CExecuteAfterTime_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public ContextMenuContentMobile _003C_003E4__this;

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
			public _003CExecuteAfterTime_003Ed__19(int _003C_003E1__state)
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
		public ContextMenuManager contextManager;

		public Transform itemParent;

		[Header("Settings")]
		[Range(0.1f, 6f)]
		public float holdToOpen;

		[Header("Items")]
		public List<ContextItem> contexItems;

		private Animator contextAnimator;

		private GameObject selectedItem;

		private Image setItemImage;

		private TextMeshProUGUI setItemText;

		private Sprite imageHelper;

		private string textHelper;

		private float timer;

		private bool timerEnabled;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void CheckForTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CExecuteAfterTime_003Ed__19))]
		private IEnumerator ExecuteAfterTime(float time)
		{
			return null;
		}

		public void CloseOnClick()
		{
		}
	}
}
