using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SliderEndDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IPointerClickHandler
{
	public Slider slider;

	private bool isDragging;

	private void Awake()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	private void HandleValueChanged(float value)
	{
	}

	private void TriggerChange()
	{
	}

	private void InterruptReviewHistory()
	{
	}

	private void OnDestroy()
	{
	}
}
