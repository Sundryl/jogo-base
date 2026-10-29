using System;
using UnityEngine;

[Serializable]
public class TimeLineConfig : MonoBehaviour
{
	[Header("Line")]
	public float lineWidth;

	[Header("Sprite")]
	public Sprite startSprite;

	public Sprite endSprite;

	public Sprite pointSprite;

	public Sprite arrowSprite;

	public float spriteSize;

	public float arrowSize;

	[Header("Item")]
	public float itemWidth;

	public float itemTitleHeight;

	public float itemMemoHeight;

	public float itemSpace;

	public float itemScrollMoveSpeed;

	public float itemColorFadeSpeed;

	[Header("Title")]
	public Font titleFontName;

	public FontStyle titleFontStyle;

	public int titleFontSize;

	public Color titleNormalColor;

	public Color titleFocusColor;

	public Color titleNormalTextColor;

	public Color titleFocusTextColor;

	[Header("Memo")]
	public Font memoFontName;

	public FontStyle memoFontStyle;

	public int memoFontSize;

	public float memoMarginTop;

	public float memoMarginLeft;

	public Color memoNormalColor;

	public Color memoFocusColor;

	public Color memoNormalTextColor;

	public Color memoFocusTextColor;
}
