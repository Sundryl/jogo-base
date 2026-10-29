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
	[AddComponentMenu("Modern UI Pack/Context Menu/Context Menu Content")]
	public class ContextMenuContent : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Serializable]
		public class ContextItem
		{
			[Space(-5f)]
			[Header("Information")]
			public string itemText;

			public Sprite itemIcon;

			public ContextItemType contextItemType;

			[Header("Sub Menu")]
			public List<SubMenuItem> subMenuItems;

			[Header("Events")]
			public UnityEvent onClick;
		}

		[Serializable]
		public class SubMenuItem
		{
			public string itemText;

			public Sprite itemIcon;

			public ContextItemType contextItemType;

			public UnityEvent onClick;
		}

		public enum ContextItemType
		{
			Button = 0,
			Separator = 1
		}

		[CompilerGenerated]
		private sealed class _003CExecuteAfterTime_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public ContextMenuContent _003C_003E4__this;

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
			public _003CExecuteAfterTime_003Ed__15(int _003C_003E1__state)
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

		public ContextMenuManager contextManager;

		public Transform itemParent;

		public bool useIn3D;

		public List<ContextItem> contexItems;

		private GameObject selectedItem;

		private Image setItemImage;

		private TextMeshProUGUI setItemText;

		private Sprite imageHelper;

		private string textHelper;

		private void Awake()
		{
		}

		public void ProcessContent()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[IteratorStateMachine(typeof(_003CExecuteAfterTime_003Ed__15))]
		private IEnumerator ExecuteAfterTime(float time)
		{
			return null;
		}

		public void OnMouseOver()
		{
		}

		public void AddNewItem()
		{
		}
	}
}
