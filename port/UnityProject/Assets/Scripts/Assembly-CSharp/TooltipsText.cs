using TMPro;
using UnityEngine;

public class TooltipsText : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI textComponent;

	public RectTransform panel;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Canvas parentCanvas;

	private GameObject m_TrackedUIObject;

	private string m_RawTooltipText;

	private bool m_IsLeadingSpaceEnabled;

	private Coroutine m_FadeCoroutine;

	[Range(2f, 100f)]
	[SerializeField]
	[Tooltip("字体大小 - 中文")]
	[Header("Font Size Settings")]
	private float m_FontSizeCN;

	[Tooltip("字体大小 - 韩文")]
	[Range(2f, 100f)]
	[SerializeField]
	private float m_FontSizeKR;

	[SerializeField]
	[Range(2f, 100f)]
	[Tooltip("字体大小 - 英文/拉丁文")]
	private float m_FontSizeEN;

	[Header("Text Spacing Settings")]
	[Tooltip("英文文本间距")]
	[SerializeField]
	private int m_SpacingEN;

	[SerializeField]
	[Tooltip("中文文本间距")]
	private int m_SpacingCN;

	[Tooltip("韩文文本间距")]
	[SerializeField]
	private int m_SpacingKR;

	[Header("Custom Font Settings")]
	[Tooltip("中文自定义字体")]
	[SerializeField]
	private TMP_FontAsset m_CustomChineseFont;

	[Tooltip("韩文自定义字体")]
	[SerializeField]
	private TMP_FontAsset m_CustomKoreanFont;

	[Tooltip("英文/拉丁文自定义字体")]
	[SerializeField]
	private TMP_FontAsset m_CustomLatinFont;

	[Tooltip("是否使用自定义字体而非默认本地化字体")]
	[SerializeField]
	private bool m_UseCustomFonts;

	private void Awake()
	{
	}

	public void SetText(string message, bool isShow = true, GameObject _uiObject = null)
	{
	}

	private void ShowWithFadeIn()
	{
	}

	private void HideImmediately()
	{
	}

	private void StopFadeCoroutine()
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

	private void ApplyFontSizeAndSpacing()
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

	private void UpdateTextHeight()
	{
	}

	private bool IsMouseOverAnyUI()
	{
		return false;
	}

	private void FixedUpdate()
	{
	}

	public void CloseTooltip()
	{
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

	private void ApplyTooltipTextByMousePosition()
	{
	}

	private void ApplyLeadingSpaceIfNeeded(bool isUpperHalf)
	{
	}
}
