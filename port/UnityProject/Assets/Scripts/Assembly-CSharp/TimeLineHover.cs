using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TimeLineHover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private enum enumFadeState
	{
		NONE = 0,
		fadeIn = 1,
		fadeOut = 2
	}

	public Image titleImage;

	public Text titleText;

	public Image memoImage;

	public Text memoText;

	public Image arrowImage;

	public TimeLineItem item;

	private enumFadeState state;

	public bool isArrowMemoColor;

	public TimeLineConfig config;

	private float colorFade;

	void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
	{
	}

	void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}

	private void UpdateColor()
	{
	}
}
