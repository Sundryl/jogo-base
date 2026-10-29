using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Mask))]
[RequireComponent(typeof(Image))]
public class VerticalTimeLineUI : MonoBehaviour
{
	private enum enumDirection
	{
		left = 0,
		right = 1
	}

	public TimeLineConfig config;

	public TimeLineItem[] items;

	private float topOffset;

	private enumDirection itemDirection;

	private const float ITEM_CENTER_SPACE = 30f;

	private const float ITEM_DEFAULT_TOP_OFFSET = 50f;

	private const float ITEM_DEFAULT_BOTTOM_OFFSET = 20f;

	private RectTransform rootTransform;

	private float moveControlMinPosition;

	private float moveControlMaxPosition;

	private int moveControlState;

	private float moveControlTick;

	private float moveControlTarget;

	private void Start()
	{
	}

	private void MakeMoveControl()
	{
	}

	private void MakeCenterLine()
	{
	}

	private void MakeStartPoint()
	{
	}

	private void MakeEndPoint()
	{
	}

	private void MakeItems()
	{
	}

	private void MakeItem(TimeLineItem item, enumDirection direction, float topOffset)
	{
	}

	private void MakeItemTitle(TimeLineItem item, RectTransform parentTransform, ref Image outputImg, ref Text outputTxt)
	{
	}

	private Image MakeItemArrow(enumDirection direction, TimeLineItem item, RectTransform parentTransform)
	{
		return null;
	}

	private void MakeItemMemo(TimeLineItem item, RectTransform parentTransform, ref Image outputImg, ref Text outputTxt)
	{
	}

	private void MakeItemPoint(enumDirection direction, RectTransform parentTransform)
	{
	}

	public void MoveNext()
	{
	}

	public void MoveNext(float offset)
	{
	}

	public void MovePrev()
	{
	}

	public void MovePrev(float offset)
	{
	}

	private void Update()
	{
	}
}
