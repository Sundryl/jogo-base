using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LocalizationToggleButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class _003CDelayedAdjustSize_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocalizationToggleButton _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDelayedAdjustSize_003Ed__59(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Toggle State")]
	[Tooltip("当前切换状态（开/关）")]
	[SerializeField]
	private bool m_IsOn;

	[SerializeField]
	[Header("Localization Keys")]
	[Tooltip("基础本地化键，将自动添加 :On 或 :Off 后缀")]
	private string m_Key;

	[SerializeField]
	[Tooltip("自定义文本（如果不为空则使用此文本而非本地化文本）")]
	private string m_CustomText;

	[SerializeField]
	[Tooltip("开启状态下的提示文本键")]
	private string m_TooltipsKeyOn;

	[SerializeField]
	[Tooltip("关闭状态下的提示文本键")]
	private string m_TooltipsKeyOff;

	[Range(10f, 100f)]
	[SerializeField]
	[Header("Font Size Settings")]
	[Tooltip("Font size to use for Chinese text")]
	private float m_FontSizeCN;

	[Range(10f, 100f)]
	[SerializeField]
	[Tooltip("Font size to use for Korean text")]
	private float m_FontSizeKR;

	[Tooltip("Font size to use for English/Latin text")]
	[SerializeField]
	[Range(10f, 100f)]
	private float m_FontSizeEN;

	[Header("Text Spacing Settings")]
	[Tooltip("Text spacing for English text")]
	[SerializeField]
	private int m_SpacingEN;

	[Tooltip("Text spacing for Chinese text")]
	[SerializeField]
	private int m_SpacingCN;

	[Tooltip("Text spacing for Korean text")]
	[SerializeField]
	private int m_SpacingKR;

	[Header("Custom Font Settings")]
	[Tooltip("Custom font asset for Chinese text")]
	[SerializeField]
	private TMP_FontAsset m_CustomChineseFont;

	[Tooltip("Custom font asset for Korean text")]
	[SerializeField]
	private TMP_FontAsset m_CustomKoreanFont;

	[Tooltip("Custom font asset for English/Latin text")]
	[SerializeField]
	private TMP_FontAsset m_CustomLatinFont;

	[Tooltip("Whether to use custom fonts instead of default localization fonts")]
	[SerializeField]
	private bool m_UseCustomFonts;

	[Range(0f, 100f)]
	[SerializeField]
	[Tooltip("Min height for the button")]
	[Header("UI Settings")]
	private float m_MinHeight;

	[Tooltip("Reference to the TextMeshProUGUI component")]
	[SerializeField]
	private TextMeshProUGUI m_TmpText;

	[Tooltip("GameObject to show when hovering over this button")]
	[SerializeField]
	private GameObject m_HoverTips;

	[Header("Button Colors")]
	[Tooltip("Button color when toggle is ON")]
	[SerializeField]
	private Color m_ColorOn;

	[Tooltip("Button color when toggle is OFF")]
	[SerializeField]
	private Color m_ColorOff;

	[Tooltip("Button highlighted color when toggle is ON")]
	[SerializeField]
	private Color m_HighlightedColorOn;

	[Tooltip("Button highlighted color when toggle is OFF")]
	[SerializeField]
	private Color m_HighlightedColorOff;

	[Tooltip("Button pressed color when toggle is ON")]
	[SerializeField]
	private Color m_PressedColorOn;

	[SerializeField]
	[Tooltip("Button pressed color when toggle is OFF")]
	private Color m_PressedColorOff;

	[Header("Text Colors")]
	[Tooltip("文本颜色当切换为开启状态")]
	[SerializeField]
	private Color m_TextColorOn;

	[Tooltip("文本颜色当切换为关闭状态")]
	[SerializeField]
	private Color m_TextColorOff;

	[Tooltip("文本颜色当切换为开启状态")]
	[SerializeField]
	[Header("Text Colors")]
	private Color m_TextColorOnStringColor;

	[Tooltip("文本颜色当切换为关闭状态")]
	[SerializeField]
	private Color m_TextColorOffStringColor;

	private Button m_Button;

	private Image m_ButtonImage;

	private ColorBlock m_ColorBlock;

	private bool m_UseExistingButtonStyle;

	private Color m_ExistingImageColor;

	private bool m_IsInitialized;

	private Coroutine m_SizeAdjustCoroutine;

	private TooltipTrigger m_TooltipTrigger;

	public bool IsOn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string CustomText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void SetBaseKey(string key)
	{
	}

	public void SetFixedTextColor(Color color)
	{
	}

	public void UseExistingButtonStyle()
	{
	}

	public void SetButtonStyle(ColorBlock colorBlock, Color imageColor)
	{
	}

	public void SetStateStyle(Color colorOn, Color colorOff, Color highlightedColorOn, Color highlightedColorOff, Color pressedColorOn, Color pressedColorOff, Color textColorOn, Color textColorOff)
	{
	}

	public void SetUnifiedFontSize(float fontSize)
	{
	}

	public void SetTooltipsKeys(string tooltipsKeyOn, string tooltipsKeyOff)
	{
	}

	private void Awake()
	{
	}

	private void Init()
	{
	}

	public void ToggleState()
	{
	}

	public void SetState(bool _isOn)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void EnsureTooltipTrigger()
	{
	}

	private void UpdateTooltipProvider()
	{
	}

	public void RefreshVisuals()
	{
	}

	public void RefreshLocalization()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedAdjustSize_003Ed__59))]
	private IEnumerator DelayedAdjustSize()
	{
		return null;
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

	private void UpdateButtonColor()
	{
	}

	private void ApplyTmpSpecificFormatting()
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

	public void SetCustomText(string _customText)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
