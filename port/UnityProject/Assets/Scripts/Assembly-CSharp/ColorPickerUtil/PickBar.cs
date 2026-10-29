using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ColorPickerUtil
{
	public class PickBar : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		[SerializeField]
		private RectTransform indicator;

		public ColorPickerFloatEvent onValueChanged;

		[HideInInspector]
		public ColorPicker.Mode mode;

		[HideInInspector]
		public Vector2 pickAreaValue;

		private RectTransform rectTransform;

		private Texture2D texture;

		private Vector2 m_Offset;

		private float m_value;

		public float value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		Transform ICanvasElement.transform => null;

		protected override void Awake()
		{
		}

		public void Initialize()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnEnable()
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
		}

		public void Refresh()
		{
		}

		public void Rebuild(CanvasUpdate executing)
		{
		}

		public void LayoutComplete()
		{
		}

		public void GraphicUpdateComplete()
		{
		}
	}
}
