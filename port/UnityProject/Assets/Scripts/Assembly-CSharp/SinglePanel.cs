using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MPUIKIT;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SinglePanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayedRefreshHeight_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SinglePanel _003C_003E4__this;

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
		public _003CDelayedRefreshHeight_003Ed__25(int _003C_003E1__state)
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

	public TMP_Text content;

	[SerializeField]
	private float m_OffsetHeight;

	[SerializeField]
	private bool m_AdjustHeightToText;

	[SerializeField]
	private bool m_UpdateParentRect;

	[SerializeField]
	private float m_ParentExtraHeight;

	private float m_PreviousHeight;

	[Header("Width Settings")]
	[SerializeField]
	private bool m_EnableCustomWidth;

	[SerializeField]
	private float m_CustomWidth;

	[Header("Font Settings")]
	[SerializeField]
	[Range(10f, 40f)]
	private float m_ChineseFontSize;

	[SerializeField]
	[Range(10f, 40f)]
	private float m_KoreanFontSize;

	[SerializeField]
	[Range(10f, 40f)]
	private float m_LatinFontSize;

	[SerializeField]
	[Range(0.1f, 5f)]
	private float m_FontScale;

	[SerializeField]
	private TMP_FontAsset m_CustomChineseFont;

	[SerializeField]
	private TMP_FontAsset m_CustomKoreanFont;

	[SerializeField]
	private TMP_FontAsset m_CustomLatinFont;

	[SerializeField]
	private bool m_UseCustomFonts;

	public bool heightChanged;

	public MPImage background;

	private void Awake()
	{
	}

	private void Start()
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

	public void SetText(string _text, TextAlignmentOptions _alignment = TextAlignmentOptions.Left, float _fontScale = 1f, bool _enableTrueShadow = true)
	{
	}

	public void SetPanelColor(Color _color)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedRefreshHeight_003Ed__25))]
	private IEnumerator DelayedRefreshHeight()
	{
		return null;
	}

	public void RefreshHeight()
	{
	}

	public void SetWidth(float _width, bool _enable = true)
	{
	}

	private void ApplyWidth()
	{
	}

	public float GetHeight()
	{
		return 0f;
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

	public void SetFontScale(float _scale)
	{
	}

	public void SetButtonTargetGraphic(Button _button)
	{
	}

	public void SetupButtonTargetGraphic()
	{
	}
}
