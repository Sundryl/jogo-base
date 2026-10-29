using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	public class ContextMenuSubMenu : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[CompilerGenerated]
		private sealed class _003CExecuteAfterTime_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public ContextMenuSubMenu _003C_003E4__this;

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
			public _003CExecuteAfterTime_003Ed__17(int _003C_003E1__state)
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

		public ContextMenuManager cmManager;

		public ContextMenuContent cmContent;

		public Animator subMenuAnimator;

		public Transform itemParent;

		public GameObject trigger;

		[HideInInspector]
		public int subMenuIndex;

		private GameObject selectedItem;

		private Image setItemImage;

		private TextMeshProUGUI setItemText;

		private Sprite imageHelper;

		private string textHelper;

		private RectTransform listParent;

		[HideInInspector]
		public bool enableFadeOut;

		private void OnEnable()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[IteratorStateMachine(typeof(_003CExecuteAfterTime_003Ed__17))]
		private IEnumerator ExecuteAfterTime(float time)
		{
			return null;
		}

		public void CloseOnClick()
		{
		}
	}
}
