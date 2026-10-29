using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_InputField))]
public class LocalizationTmpInputField : MonoBehaviour
{
	[Header("字体大小设置")]
	[Tooltip("中文文本使用的字体大小")]
	[SerializeField]
	[Range(10f, 100f)]
	private float m_FontSizeCN;

	[SerializeField]
	[Range(10f, 100f)]
	[Tooltip("韩文文本使用的字体大小")]
	private float m_FontSizeKR;

	[Tooltip("英文/拉丁文本使用的字体大小")]
	[SerializeField]
	[Range(10f, 100f)]
	private float m_FontSizeEN;

	[Header("文本间距设置")]
	[Tooltip("英文文本的间距")]
	[SerializeField]
	private int m_SpacingEN;

	[Tooltip("中文文本的间距")]
	[SerializeField]
	private int m_SpacingCN;

	[SerializeField]
	[Tooltip("韩文文本的间距")]
	private int m_SpacingKR;

	[SerializeField]
	[Tooltip("中文文本的自定义字体资源")]
	[Header("自定义字体设置")]
	private TMP_FontAsset m_CustomChineseFont;

	[Tooltip("韩文文本的自定义字体资源")]
	[SerializeField]
	private TMP_FontAsset m_CustomKoreanFont;

	[Tooltip("英文/拉丁文本的自定义字体资源")]
	[SerializeField]
	private TMP_FontAsset m_CustomLatinFont;

	[Tooltip("是否使用自定义字体而非默认本地化字体")]
	[SerializeField]
	private bool m_UseCustomFonts;

	[Header("自定义语言设置")]
	[Tooltip("当不为空时，组件将使用该语言而非全局语言")]
	[SerializeField]
	private string m_CustomLanguage;

	[Tooltip("TMP_InputField 组件引用")]
	[SerializeField]
	private TMP_InputField m_InputField;

	public string CurrentLanguage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool IsCNTypeLanguage()
	{
		return false;
	}

	private void Awake()
	{
	}

	public void RefreshLocalization()
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

	public void SetCustomLanguage(string _language)
	{
	}

	public void ClearCustomLanguage()
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
