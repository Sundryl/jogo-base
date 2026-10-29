using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class DropdownInfo : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetupDropdownItemsTooltip_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DropdownInfo _003C_003E4__this;

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
		public _003CSetupDropdownItemsTooltip_003Ed__39(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CRefreshDropdownListFonts_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DropdownInfo _003C_003E4__this;

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
		public _003CRefreshDropdownListFonts_003Ed__40(int _003C_003E1__state)
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

	[SerializeField]
	public TMP_Dropdown m_Dropdown;

	[SerializeField]
	public TextMeshProUGUI m_Label;

	[Header("Font Settings")]
	[Range(10f, 40f)]
	[SerializeField]
	private float m_ChineseFontSize;

	[Range(10f, 40f)]
	[SerializeField]
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

	[Header("Option Font Settings")]
	[SerializeField]
	private bool m_EnableDynamicOptionFonts;

	[SerializeField]
	[Range(8f, 30f)]
	private float m_MinOptionFontSize;

	[SerializeField]
	[Range(12f, 40f)]
	private float m_MaxOptionFontSize;

	[Header("Tooltip Settings")]
	[SerializeField]
	private bool m_EnableTooltip;

	private bool m_ClickListenerRegistered;

	public void SetLabel(string label)
	{
	}

	public void SetToolTipsKey(string toolTipKey)
	{
	}

	private void Awake()
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

	public void RefreshDropdownFonts()
	{
	}

	private void EnsureDropdownClickListener()
	{
	}

	private void OnDropdownValueChanged(int value)
	{
	}

	private void UpdateDropdownCaptionFont()
	{
	}

	private void UpdateTemplateOptionFont()
	{
	}

	private void ApplyDynamicFont(TMP_Text target, string content, bool adjustSizing)
	{
	}

	private TMP_FontAsset ResolveFontByContent(string content)
	{
		return null;
	}

	private static bool ContainsHangul(string text)
	{
		return false;
	}

	private bool IsContentCurrentLanguage(string content)
	{
		return false;
	}

	private float GetCurrentLanguageFontSize()
	{
		return 0f;
	}

	private void OnDropdownClicked()
	{
	}

	[IteratorStateMachine(typeof(_003CSetupDropdownItemsTooltip_003Ed__39))]
	private IEnumerator SetupDropdownItemsTooltip()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRefreshDropdownListFonts_003Ed__40))]
	private IEnumerator RefreshDropdownListFonts()
	{
		return null;
	}
}
