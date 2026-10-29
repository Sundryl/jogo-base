using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class LocalizationText : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRefresh_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocalizationText _003C_003E4__this;

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
		public _003CRefresh_003Ed__23(int _003C_003E1__state)
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
	protected TextMeshProUGUI tmpText;

	public float offsetHeight;

	public string key;

	public string customText;

	public float fontSizeCN;

	public float fontSizeEn;

	public float spacingCN;

	public float spacingEN;

	[Header("Custom Font Settings")]
	[SerializeField]
	private TMP_FontAsset m_CustomChineseFont;

	[SerializeField]
	private TMP_FontAsset m_CustomKoreanFont;

	[SerializeField]
	private TMP_FontAsset m_CustomLatinFont;

	[SerializeField]
	protected bool m_UseCustomFonts;

	[SerializeField]
	protected bool m_UseDefaultFont;

	public bool isDebug;

	private void Awake()
	{
	}

	public virtual void RefreshLocalization()
	{
	}

	protected void ApplyFontSettings()
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

	public void SetCustomFont(TMP_FontAsset _font)
	{
	}

	public void SetLanguageSpecificFonts(TMP_FontAsset _chineseFont, TMP_FontAsset _koreanFont, TMP_FontAsset _latinFont)
	{
	}

	protected void UpdateHeight()
	{
	}

	[IteratorStateMachine(typeof(_003CRefresh_003Ed__23))]
	private IEnumerator Refresh()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
