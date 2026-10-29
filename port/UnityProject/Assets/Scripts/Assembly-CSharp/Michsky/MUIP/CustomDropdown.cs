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
	public class CustomDropdown : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler, IPointerClickHandler, ISubmitHandler
	{
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
		}

		[Serializable]
		public class ItemTextChangedEvent : UnityEvent<TMP_Text>
		{
		}

		public enum AnimationType
		{
			Modular = 0,
			Custom = 1
		}

		public enum PanelDirection
		{
			Bottom = 0,
			Top = 1
		}

		[Serializable]
		public class Item
		{
			public string itemName;

			public Sprite itemIcon;

			[HideInInspector]
			public int itemIndex;

			public UnityEvent OnItemSelection;
		}

		[CompilerGenerated]
		private sealed class _003CStartExpand_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CustomDropdown _003C_003E4__this;

			private float _003CelapsedTime_003E5__2;

			private Vector2 _003CstartPos_003E5__3;

			private Vector2 _003CendPos_003E5__4;

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
			public _003CStartExpand_003Ed__71(int _003C_003E1__state)
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
		private sealed class _003CStartMinimize_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CustomDropdown _003C_003E4__this;

			private float _003CelapsedTime_003E5__2;

			private Vector2 _003CstartPos_003E5__3;

			private Vector2 _003CendPos_003E5__4;

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
			public _003CStartMinimize_003Ed__72(int _003C_003E1__state)
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

		public Animator dropdownAnimator;

		public GameObject triggerObject;

		public TextMeshProUGUI selectedText;

		public Image selectedImage;

		public Transform itemParent;

		public GameObject itemObject;

		public GameObject scrollbar;

		public VerticalLayoutGroup itemList;

		public AudioSource soundSource;

		public RectTransform listRect;

		public CanvasGroup listCG;

		public CanvasGroup contentCG;

		public bool isInteractable;

		public bool enableIcon;

		public bool enableTrigger;

		public bool enableScrollbar;

		public bool updateOnEnable;

		public bool outOnPointerExit;

		public bool setHighPriority;

		public bool invokeAtStart;

		public bool initAtStart;

		public bool enableDropdownSounds;

		public bool useHoverSound;

		public bool useClickSound;

		[Range(1f, 50f)]
		public int itemPaddingTop;

		[Range(1f, 50f)]
		public int itemPaddingBottom;

		[Range(1f, 50f)]
		public int itemPaddingLeft;

		[Range(1f, 50f)]
		public int itemPaddingRight;

		[Range(1f, 50f)]
		public int itemSpacing;

		public int selectedItemIndex;

		public AnimationType animationType;

		public PanelDirection panelDirection;

		[Range(25f, 1000f)]
		public float panelSize;

		[Range(0.5f, 10f)]
		public float curveSpeed;

		public AnimationCurve animationCurve;

		public bool saveSelected;

		public string saveKey;

		[SerializeField]
		public List<Item> items;

		public DropdownEvent onValueChanged;

		public ItemTextChangedEvent onItemTextChanged;

		public AudioClip hoverSound;

		public AudioClip clickSound;

		private bool isInitialized;

		[HideInInspector]
		public bool isOn;

		[HideInInspector]
		public int index;

		[HideInInspector]
		public int siblingIndex;

		[HideInInspector]
		public TextMeshProUGUI setItemText;

		[HideInInspector]
		public Image setItemImage;

		private EventTrigger triggerEvent;

		private Sprite imageHelper;

		private string textHelper;

		private void OnEnable()
		{
		}

		private void Initialize()
		{
		}

		public void SetupDropdown()
		{
		}

		public void ChangeDropdownInfo(int itemIndex)
		{
		}

		public void SetDropdownIndex(int itemIndex)
		{
		}

		public void Animate()
		{
		}

		public void Interactable(bool value)
		{
		}

		public void CreateNewItem(string title, Sprite icon, bool notify = false)
		{
		}

		public void CreateNewItem(string title, bool notify = false)
		{
		}

		public void RemoveItem(string itemTitle, bool notify = false)
		{
		}

		public void UpdateItemLayout()
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

		public void OnSubmit(BaseEventData eventData)
		{
		}

		[IteratorStateMachine(typeof(_003CStartExpand_003Ed__71))]
		private IEnumerator StartExpand()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CStartMinimize_003Ed__72))]
		private IEnumerator StartMinimize()
		{
			return null;
		}
	}
}
