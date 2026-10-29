using UnityEngine;
using UnityEngine.EventSystems;

public class SimpleTooltipTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private string m_TooltipText;

	private int m_OriginalSortingOrder;

	private bool m_OriginalOverrideSorting;

	public void Initialize(string text)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	private void EnsureTooltipAboveDropdown()
	{
	}

	private void RestoreTooltipCanvas()
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void OnDisable()
	{
	}
}
