using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableWindow : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler
{
	[SerializeField]
	private RectTransform dragArea;

	private Vector2 offset;

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
