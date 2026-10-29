using System.Runtime.CompilerServices;
using MPUIKIT;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TraitButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public delegate void BadgeRemoveHandler(string trait);

	public delegate void BadgeStateChangeHandler(string trait, bool isActive);

	[Header("组件引用")]
	public TextMeshProUGUI textLabel;

	public Button closeButton;

	[Header("按钮状态")]
	[SerializeField]
	private bool m_IsActive;

	[SerializeField]
	private Color m_ActiveColor;

	[SerializeField]
	private Color m_InactiveColor;

	[SerializeField]
	private MPImage m_BackgroundImage;

	[Header("Font Settings")]
	[SerializeField]
	[Range(10f, 40f)]
	private float m_ChineseFontSize;

	[SerializeField]
	[Range(10f, 40f)]
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

	private string translationKey;

	[CompilerGenerated]
	private BadgeRemoveHandler m_OnBadgeRemoved;

	[CompilerGenerated]
	private BadgeStateChangeHandler m_OnBadgeStateChanged;

	[Header("提示功能")]
	public string tooltipKey;

	public string customDescription;

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

	public event BadgeStateChangeHandler OnBadgeStateChanged
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

	public void RefreshLocalization()
	{
	}

	public void Initialize(string text, string key, bool fixedWidth = false, string tooltip = "")
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

	private void ToggleState()
	{
	}

	private void UpdateVisualState()
	{
	}

	public void SetState(bool isActive)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public void RemoveSelf()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void SetTooltip(string key)
	{
	}

	public void SetCustomDescription(string description)
	{
	}

	private void EnsureTooltipTrigger()
	{
	}

	private void UpdateTooltipBinding()
	{
	}

	private void UpdateDisplayedText()
	{
	}

	public void SetDisplayLocalizationKey(string key, bool refreshImmediately = true)
	{
	}
}
