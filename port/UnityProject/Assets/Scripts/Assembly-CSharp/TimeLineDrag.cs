using UnityEngine;
using UnityEngine.EventSystems;

public class TimeLineDrag : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler
{
	public RectTransform dragPoint;

	public bool isVertical;

	public bool isHorizontal;

	public float minMoveArea;

	public float maxMoveArea;

	private Vector3 offsetPos;

	void IDragHandler.OnDrag(PointerEventData eventData)
	{
	}

	void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
	{
	}
}
