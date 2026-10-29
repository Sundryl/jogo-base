using UnityEngine;
using UnityEngine.EventSystems;

namespace Michsky.MUIP
{
	public class WindowDragger : UIBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler
	{
		[Header("Resources")]
		public RectTransform dragArea;

		public RectTransform dragObject;

		[Header("Settings")]
		public bool topOnDrag;

		private Vector2 originalLocalPointerPosition;

		private Vector3 originalPanelLocalPosition;

		private RectTransform DragObjectInternal => null;

		private RectTransform DragAreaInternal => null;

		public new void Start()
		{
		}

		public void OnBeginDrag(PointerEventData data)
		{
		}

		public void OnDrag(PointerEventData data)
		{
		}

		private void ClampToArea()
		{
		}
	}
}
