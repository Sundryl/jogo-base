using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Mask))]
[RequireComponent(typeof(Image))]
public class HorizontalTimeLineUI : MonoBehaviour
{
	private enum enumDirection
	{
		top = 0,
		bottom = 1
	}

	public TimeLineConfig config;

	public TimeLineItem[] items;

	private float leftOffset;

	private enumDirection itemDirection;

	private const float ITEM_LEFT_SPACE = 30f;

	private const float ITEM_DEFAULT_LEFT_OFFSET = 50f;

	private const float ITEM_DEFAULT_RIGHT_OFFSET = 20f;

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

	private void MakeItems()
	{
	}

	private void MakeItem(TimeLineItem item, enumDirection direction, float leftOffset)
	{
	}

	private void MakeItemTitle(enumDirection direction, TimeLineItem item, RectTransform parentTransform, ref Image outputImg, ref Text outputTxt)
	{
	}

	private void MakeItemMemo(enumDirection direction, TimeLineItem item, RectTransform parentTransform, ref Image outputImg, ref Text outputTxt)
	{
	}

	private Image MakeItemArrow(enumDirection direction, TimeLineItem item, RectTransform parentTransform)
	{
		return null;
	}

	private void MakeItemPoint(enumDirection direction, RectTransform parentTransform)
	{
	}

	private void MakeStartPoint()
	{
	}

	private void MakeEndPoint()
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
