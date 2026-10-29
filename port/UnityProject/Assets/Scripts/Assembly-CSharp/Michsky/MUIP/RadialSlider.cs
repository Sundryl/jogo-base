using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	public class RadialSlider : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Serializable]
		public class SliderEvent : UnityEvent<float>
		{
		}

		public enum StartPoint
		{
			Left = 0,
			Right = 1,
			Top = 2,
			Down = 3
		}

		private const string PREFS_UI_SAVE_NAME = "Radial";

		public float currentValue;

		public Image sliderImage;

		public Transform indicatorPivot;

		public TextMeshProUGUI valueText;

		public float minValue;

		public float maxValue;

		[Range(0f, 8f)]
		public int decimals;

		public bool isPercent;

		public StartPoint startPoint;

		public bool rememberValue;

		public string sliderTag;

		[SerializeField]
		public SliderEvent onValueChanged;

		public UnityEvent onPointerEnter;

		public UnityEvent onPointerExit;

		private GraphicRaycaster graphicRaycaster;

		private RectTransform hitRectTransform;

		private bool isPointerDown;

		private float currentAngle;

		private float currentAngleOnPointerDown;

		private float valueDisplayPrecision;

		public float SliderAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SliderValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SliderValueRaw
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void LoadState()
		{
		}

		public void SaveState()
		{
		}

		public void UpdateUI()
		{
		}

		private bool HasValueChanged()
		{
			return false;
		}

		private void HandleSliderMouseInput(PointerEventData eventData, bool allowValueWrap)
		{
		}
	}
}
