using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HistoryInfoPanel : BasePanelUI
{
	[Serializable]
	private class FontSetting
	{
		[SerializeField]
		internal TMP_FontAsset Font;

		[SerializeField]
		internal float HistoryYearFontSize;

		[SerializeField]
		internal float HistoryTextFontSize;
	}

	[CompilerGenerated]
	private sealed class _003CReviewHistoryCoroutine_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HistoryInfoPanel _003C_003E4__this;

		private List<double> _003ChistoryPoints_003E5__2;

		private int _003CtotalPoints_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CReviewHistoryCoroutine_003Ed__50(int _003C_003E1__state)
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

	private static HistoryInfoPanel s_Instance;

	[SerializeField]
	[Header("历史文本组件")]
	private TextMeshProUGUI m_HistoryYear;

	[SerializeField]
	private TMP_InputField m_TimeInputField;

	[SerializeField]
	private TextMeshProUGUI m_HistoryText;

	[Header("时间滑条组件")]
	[SerializeField]
	private Slider m_HistoryTimeSlider;

	[Header("历史导航按钮")]
	[SerializeField]
	private LocalizationTmpButton m_PreviousHalfYearButton;

	[SerializeField]
	private LocalizationTmpButton m_NextHalfYearButton;

	[Header("字体设置")]
	[SerializeField]
	private FontSetting m_ChineseFontSetting;

	[SerializeField]
	private FontSetting m_KoreanFontSetting;

	[SerializeField]
	private FontSetting m_LatinFontSetting;

	private bool m_IsUpdatingInputField;

	private bool m_HasLoggedMissingHistoryText;

	private bool m_HasLoggedMissingHistoryManager;

	private bool m_HasLoggedMissingTimeInput;

	private HashSet<HistoryEventType> m_WorldHistoryFilterEventTypes;

	private string m_LastWorldHistoryFilterSignature;

	private const float c_MinSliderOffset = 1E-07f;

	private const string c_PreviousHalfYearKey = "HistoryHalfYearPrev";

	private const string c_NextHalfYearKey = "HistoryHalfYearNext";

	private Button m_PreviousHalfYearUnityButton;

	private Button m_NextHalfYearUnityButton;

	public static HistoryInfoPanel Instance => null;

	public TextMeshProUGUI HistoryYear => null;

	public TextMeshProUGUI HistoryText => null;

	public Slider HistoryTimeSlider => null;

	public TMP_InputField TimeInputField => null;

	public bool IsDuringReviewingMode { get; set; }

	public Coroutine reviewHistoryCoroutine { get; private set; }

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	private void EnsureComponentReferences()
	{
	}

	private void ConfigureTimeInputField()
	{
	}

	private void InitializeVisibility()
	{
	}

	public void InitHistoryInfo(int _stateID)
	{
	}

	public void OnHistoryInfoPanelButtonClose()
	{
	}

	public void OnViewFullHistoryButtonClicked()
	{
	}

	public void OnReviewHistoryButtonClicked()
	{
	}

	[IteratorStateMachine(typeof(_003CReviewHistoryCoroutine_003Ed__50))]
	public IEnumerator ReviewHistoryCoroutine()
	{
		return null;
	}

	public void OnBackToCurrentButtonClicked()
	{
	}

	public void UpdateHistoryTimeLine(float value)
	{
	}

	public double GetHistoryTime()
	{
		return 0.0;
	}

	private void FixedUpdate()
	{
	}

	private void EnsureWorldHistoryFilterInitialized()
	{
	}

	private HashSet<HistoryEventType> BuildWorldHistoryFilterFromConfig(List<string> configuredList)
	{
		return null;
	}

	protected override void RefreshLocalization()
	{
	}

	private FontSetting GetFontSettingForCurrentLanguage()
	{
		return null;
	}

	private void ApplyFontSize(TMP_Text _target, float _fontSize)
	{
	}

	private void OnTimeInputEndEdit(string input)
	{
	}

	private void SyncTimeInputField(double time)
	{
	}

	private string FormatYearValue(double time)
	{
		return null;
	}

	private int CalculateYearValue(double time)
	{
		return 0;
	}

	private void JumpToYear(int targetYear)
	{
	}

	private float GetSliderValueForIndex(int index, int totalCount)
	{
		return 0f;
	}

	private void StopReviewHistoryIfNeeded()
	{
	}

	private double GetCurrentDisplayTime()
	{
		return 0.0;
	}

	private void ConfigureHalfYearButtons()
	{
	}

	private void CleanupHalfYearButtons()
	{
	}

	private void SetupHalfYearButton(LocalizationTmpButton _localizationButton, ref Button _button, string _key, UnityAction _callback)
	{
	}

	private void RefreshHalfYearButtonTranslations()
	{
	}

	private void UpdateHalfYearButtonTranslation(LocalizationTmpButton _button)
	{
	}

	private void OnPreviousHalfYearClicked()
	{
	}

	private void OnNextHalfYearClicked()
	{
	}

	private void MoveHalfYear(bool _isForward)
	{
	}

	private int GetCurrentHistoryIndex(List<double> _historyPoints)
	{
		return 0;
	}

	private void OnDestroy()
	{
	}
}
