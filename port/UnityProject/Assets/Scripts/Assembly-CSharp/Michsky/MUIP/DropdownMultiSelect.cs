using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	public class DropdownMultiSelect : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerClickHandler
	{
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
		}

		public enum AnimationType
		{
			Modular = 0,
			Stylish = 1
		}

		[Serializable]
		public class Item
		{
			public string itemName;

			public bool isOn;

			[HideInInspector]
			public int itemIndex;

			[SerializeField]
			public ToggleEvent onValueChanged;
		}

		public GameObject triggerObject;

		public Transform itemParent;

		public GameObject itemObject;

		public GameObject scrollbar;

		private VerticalLayoutGroup itemList;

		private Transform currentListParent;

		public Transform listParent;

		private Animator dropdownAnimator;

		public TextMeshProUGUI setItemText;

		public CanvasGroup contentCG;

		public bool isInteractable;

		public bool initAtStart;

		public bool enableIcon;

		public bool enableTrigger;

		public bool enableScrollbar;

		public bool setHighPriority;

		public bool outOnPointerExit;

		public bool isListItem;

		public bool invokeAtStart;

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

		public AnimationType animationType;

		[Range(1f, 25f)]
		public float transitionSmoothness;

		[Range(1f, 25f)]
		public float sizeSmoothness;

		public float panelSize;

		public RectTransform listRect;

		public CanvasGroup listCG;

		private bool isInTransition;

		private float closeOn;

		[SerializeField]
		public List<Item> items;

		private bool isInitialized;

		private int currentIndex;

		private Toggle currentToggle;

		private string textHelper;

		private bool isOn;

		public int siblingIndex;

		private EventTrigger triggerEvent;

		private void OnEnable()
		{
		}

		private void Initialize()
		{
		}

		private void Update()
		{
		}

		private void ProcessModularAnimation()
		{
		}

		public void SetupDropdown()
		{
		}

		private void UpdateToggle(bool value)
		{
		}

		private void UpdateToggleData(int itemIndex)
		{
		}

		public void Animate()
		{
		}

		public void CreateNewItem(string title, bool value, bool notify)
		{
		}

		public void CreateNewItem(string title, bool value)
		{
		}

		public void CreateNewItem(string title)
		{
		}

		public void RemoveItem(string itemTitle)
		{
		}

		public void UpdateItemLayout()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
