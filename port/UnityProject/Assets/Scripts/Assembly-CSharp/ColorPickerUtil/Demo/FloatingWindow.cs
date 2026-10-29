using UnityEngine;
using UnityEngine.EventSystems;

namespace ColorPickerUtil.Demo
{
	public class FloatingWindow : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		[SerializeField]
		private RectTransform target;

		private Camera eventCam;

		private Vector2 beginPos;

		private Vector2 dragPos;

		public Vector2 GetMousePosition()
		{
			return default;
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
