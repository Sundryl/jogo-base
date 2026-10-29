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
	[RequireComponent(typeof(Animator))]
	public class HorizontalSelector : MonoBehaviour
	{
		[Serializable]
		public class SelectorEvent : UnityEvent<int>
		{
		}

		[Serializable]
		public class ItemTextChangedEvent : UnityEvent<TMP_Text>
		{
		}

		[Serializable]
		public class Item
		{
			public string itemTitle;

			public Sprite itemIcon;

			public UnityEvent onItemSelect;
		}

		[CompilerGenerated]
		private sealed class _003CDisableAnimator_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HorizontalSelector _003C_003E4__this;

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
			public _003CDisableAnimator_003Ed__40(int _003C_003E1__state)
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

		public TextMeshProUGUI label;

		public TextMeshProUGUI labelHelper;

		public Image labelIcon;

		public Image labelIconHelper;

		public Transform indicatorParent;

		public GameObject indicatorObject;

		public Animator selectorAnimator;

		public HorizontalLayoutGroup contentLayout;

		public HorizontalLayoutGroup contentLayoutHelper;

		private string newItemTitle;

		public bool enableIcon;

		public bool saveSelected;

		public string saveKey;

		public bool enableIndicators;

		public bool invokeAtStart;

		public bool invertAnimation;

		public bool loopSelection;

		[Range(0.25f, 2.5f)]
		public float iconScale;

		[Range(1f, 50f)]
		public int contentSpacing;

		public int defaultIndex;

		[HideInInspector]
		public int index;

		public List<Item> items;

		public SelectorEvent onValueChanged;

		public ItemTextChangedEvent onItemTextChanged;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void SetupSelector()
		{
		}

		public void PreviousItem()
		{
		}

		public void NextItem()
		{
		}

		public void PreviousClick()
		{
		}

		public void ForwardClick()
		{
		}

		public void CreateNewItem(string title)
		{
		}

		public void CreateNewItem(string title, Sprite icon)
		{
		}

		public void RemoveItem(string itemTitle)
		{
		}

		public void UpdateUI()
		{
		}

		public void UpdateIndicators()
		{
		}

		public void UpdateContentLayout()
		{
		}

		[IteratorStateMachine(typeof(_003CDisableAnimator_003Ed__40))]
		private IEnumerator DisableAnimator()
		{
			return null;
		}
	}
}
