using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[RequireComponent(typeof(Slider))]
	public class SliderManager : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		public class SliderEvent : UnityEvent<float>
		{
		}

		public Slider mainSlider;

		public TextMeshProUGUI valueText;

		public TextMeshProUGUI popupValueText;

		public bool enableSaving;

		public bool invokeOnAwake;

		public string sliderTag;

		public bool usePercent;

		public bool showValue;

		public bool showPopupValue;

		public bool useRoundValue;

		public float minValue;

		public float maxValue;

		[SerializeField]
		public SliderEvent onValueChanged;

		[Space(8f)]
		public SliderEvent sliderEvent;

		[HideInInspector]
		public Animator sliderAnimator;

		[HideInInspector]
		public float saveValue;

		private void Awake()
		{
		}

		public void UpdateUI()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
