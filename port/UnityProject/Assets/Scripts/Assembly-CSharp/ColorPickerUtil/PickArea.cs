using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ColorPickerUtil
{
	public class PickArea : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		[SerializeField]
		private RectTransform indicator;

		[SerializeField]
		private Image indicatorImage;

		public ColorPickerVector2Event onValueChanged;

		[HideInInspector]
		public ColorPicker.Mode mode;

		[HideInInspector]
		public float pickBarValue;

		[HideInInspector]
		public float lValue;

		private RectTransform rectTransform;

		private Texture2D texture;

		private Vector2 m_Offset;

		private Vector2 m_value;

		public Vector2 value
		{
			get
			{
				return default;
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
