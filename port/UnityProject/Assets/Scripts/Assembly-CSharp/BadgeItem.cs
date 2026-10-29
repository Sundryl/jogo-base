using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BadgeItem : MonoBehaviour
{
	public delegate void BadgeRemoveHandler(string trait);

	[Header("组件引用")]
	public TextMeshProUGUI textLabel;

	public Button closeButton;

	public RectTransform backgroundRect;

	public LayoutElement layoutElement;

	[Header("配置参数")]
	public float maxWidth;

	public float horizontalPadding;

	public float verticalPadding;

	public float closeButtonWidth;

	[Tooltip("启用后，Badge将使用固定宽度(maxWidth)而不是自适应内容")]
	public bool useFixedWidth;

	public float badgeWidth;

	public float badgeHeight;

	public float offsetHeight;

	[Header("Font Settings")]
	[Range(10f, 40f)]
	[SerializeField]
	private float m_ChineseFontSize;

	[Range(10f, 40f)]
	[SerializeField]
	private float m_KoreanFontSize;

	[Range(10f, 40f)]
	[SerializeField]
	private float m_LatinFontSize;

	[SerializeField]
	private TMP_FontAsset m_CustomChineseFont;

	[SerializeField]
	private TMP_FontAsset m_CustomKoreanFont;

	[SerializeField]
	private TMP_FontAsset m_CustomLatinFont;

	[SerializeField]
	private bool m_UseCustomFonts;

	[HideInInspector]
	public string traitKey;

	[CompilerGenerated]
	private BadgeRemoveHandler m_OnBadgeRemoved;

	[Header("提示功能")]
	public string tooltipKey;

	public GameObject hoverTips;

	private TooltipTrigger m_TooltipTrigger;

	public event BadgeRemoveHandler OnBadgeRemoved
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLanguageChanged()
	{
	}

	public void Initialize(string text, string key, bool fixedWidth = false, string tooltip = "")
	{
	}

	public void UpdateHeight()
	{
	}

	private void ConfigureTextComponent()
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

	public void SetFontSizes(float _chineseFontSize, float _koreanFontSize, float _latinFontSize)
	{
	}

	private void RemoveSelf()
	{
	}

	private void OnBadgeHover()
	{
	}

	private void OnBadgeExit()
	{
	}

	public void SetTooltip(string key)
	{
	}

	private void EnsureTooltipTrigger()
	{
	}

	private void UpdateTooltipBinding()
	{
	}
}
