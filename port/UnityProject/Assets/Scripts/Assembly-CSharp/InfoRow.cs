using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class InfoRow : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	public TMP_Text title;

	public TMP_Text value;

	[SerializeField]
	[Range(10f, 40f)]
	[Header("Font Settings")]
	private float m_ChineseFontSize;

	[SerializeField]
	[Range(10f, 40f)]
	private float m_KoreanFontSize;

	[SerializeField]
	[Range(10f, 40f)]
	private float m_LatinFontSize;

	[SerializeField]
	private TMP_FontAsset m_CustomChineseFont;

	[SerializeField]
	private TMP_FontAsset m_CustomKoreanFont;

	[SerializeField]
	private TMP_FontAsset m_CustomLatinFont;

	[SerializeField]
	private bool m_UseCustomFonts;

	private UnityAction m_ValueClickAction;

	private readonly Color m_DefaultColor;

	private readonly Color m_HoverColor;

	private bool m_IsHovering;

	private TooltipTrigger m_TooltipTrigger;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLanguageChanged()
	{
	}

	public void SetInfo(string _title, string _value, TextAlignmentOptions _alignment = TextAlignmentOptions.Left, UnityAction _valueClickAction = null, TooltipContentProvider _tooltipProvider = null)
	{
	}

	private void ApplyFontSettings()
	{
	}

	private bool HasCustomFontsAssigned()
	{
		return false;
	}

	private void ApplyCustomFonts()
	{
	}

	private void ApplyDefaultFonts()
	{
	}

	private void ApplyFontSize()
	{
	}

	public void SetCustomFont(TMP_FontAsset _font)
	{
	}

	public void SetLanguageSpecificFonts(TMP_FontAsset _chineseFont, TMP_FontAsset _koreanFont, TMP_FontAsset _latinFont)
	{
	}

	public void SetTitleLanguageSpecificFonts(TMP_FontAsset _chineseFont, TMP_FontAsset _koreanFont, TMP_FontAsset _latinFont)
	{
	}

	public void SetValueLanguageSpecificFonts(TMP_FontAsset _chineseFont, TMP_FontAsset _koreanFont, TMP_FontAsset _latinFont)
	{
	}

	public void SetFontSizes(float _chineseFontSize, float _koreanFontSize, float _latinFontSize)
	{
	}

	public void SetTitleFontSizes(float _chineseFontSize, float _koreanFontSize, float _latinFontSize)
	{
	}

	public void SetValueFontSizes(float _chineseFontSize, float _koreanFontSize, float _latinFontSize)
	{
	}

	private void ApplyTooltipProvider(TooltipContentProvider provider)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
