using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProvinceInfoUI : BasePanelUI
{
	[CompilerGenerated]
	private sealed class _003CRefreshLayoutDelayed_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProvinceInfoUI _003C_003E4__this;

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
		public _003CRefreshLayoutDelayed_003Ed__68(int _003C_003E1__state)
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
	private sealed class _003CDelayedLayoutRefresh_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProvinceInfoUI _003C_003E4__this;

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
		public _003CDelayedLayoutRefresh_003Ed__79(int _003C_003E1__state)
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

	private static ProvinceInfoUI s_Instance;

	private static GameObject s_InstanceObject;

	[Header("行省名称控件")]
	[SerializeField]
	private TMP_InputField m_ProvinceNameInputField;

	[Header("翻译面板")]
	public TranslationUIPanel m_TranslationUIPanel;

	[Header("信息显示")]
	[SerializeField]
	private CollapsibleSectionUI m_BasicInfoSection;

	[SerializeField]
	private CollapsibleSectionUI m_ActionsSection;

	[SerializeField]
	private CollapsibleSectionUI m_CampaignInfoSection;

	private Province m_CurrentProvince;

	private float m_UpdateInterval;

	private float m_LastUpdateTime;

	private Button m_StartRebellionButton;

	private Button m_SetAsCapitalButton;

	private Button m_SetAsFortressButton;

	private Button m_SetAsCityButton;

	private Button m_SetAsRegionCenterButton;

	private Button m_TranslateProvinceNameButton;

	private Button m_SetCustomPopulationButton;

	private Button m_SetCustomDefenseButton;

	private const string c_SetCustomPopulationButtonKey = "btn_SetCustomPopulation";

	private const string c_SetCustomPopulationTooltipKey = "SetCustomPopulationTooltip";

	private const string c_SetCustomPopulationTitleKey = "SetCustomPopulationTitle";

	private const string c_CurrentPopulationKey = "CurrentPopulation";

	private const string c_MaxPopulationKey = "MaxPopulation";

	private const string c_LockMaxPopulationKey = "LockMaxPopulation";

	private const string c_LockMaxPopulationTooltipOnKey = "LockMaxPopulationTooltipOn";

	private const string c_LockMaxPopulationTooltipOffKey = "LockMaxPopulationTooltipOff";

	private const string c_SetCustomPopulationInvalidKey = "SetCustomPopulationInvalid";

	private const int c_CustomPopulationMaxDigits = 10;

	private const string c_SetCustomDefenseButtonKey = "btn_SetCustomDefense";

	private const string c_SetCustomDefenseTooltipKey = "SetCustomDefenseTooltip";

	private const string c_SetCustomDefenseTitleKey = "SetCustomDefenseTitle";

	private const string c_CurrentCityDefenseKey = "CurrentCityDefense";

	private const string c_MaxCityDefenseKey = "MaxCityDefense";

	private const string c_LockMaxCityDefenseKey = "LockMaxCityDefense";

	private const string c_LockMaxCityDefenseTooltipOnKey = "LockMaxCityDefenseTooltipOn";

	private const string c_LockMaxCityDefenseTooltipOffKey = "LockMaxCityDefenseTooltipOff";

	private const string c_LockHomeFieldAdvantageKey = "LockHomeFieldAdvantage";

	private const string c_LockHomeFieldAdvantageTooltipOnKey = "LockHomeFieldAdvantageTooltipOn";

	private const string c_LockHomeFieldAdvantageTooltipOffKey = "LockHomeFieldAdvantageTooltipOff";

	private const string c_SetCustomDefenseInvalidKey = "SetCustomDefenseInvalid";

	private const int c_CustomDefenseValueMaxDigits = 10;

	private const int c_CustomDefenseModifierMaxDigits = 5;

	private List<SinglePanel> m_BiomePanels;

	private List<SinglePanel> m_ResourcePanels;

	private List<SinglePanel> m_EthnicityPanels;

	private List<SinglePanel> m_CampaignPanels;

	public static ProvinceInfoUI Instance => null;

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	private void InitializeComponents()
	{
	}

	private void FindTranslationPanel()
	{
	}

	private void FindProvinceNameInputField()
	{
	}

	private void FindCollapsibleSections()
	{
	}

	private void InitializeSections()
	{
	}

	private void FindAndBindActionButtons()
	{
	}

	private void ConfigureLocalizedActionButton(Button button, string buttonKey, string tooltipKey)
	{
	}

	public void Display(int provinceID)
	{
	}

	public void InitProvinceInfo(int provinceID)
	{
	}

	public override void Show(Action _onComplete = null)
	{
	}

	public override void Hide(Action _onComplete = null)
	{
	}

	public void OnProvinceInfoPanelButtonClose()
	{
	}

	protected override void OnPanelInitialize()
	{
	}

	protected override void OnPanelShow()
	{
	}

	protected override void RefreshLocalization()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshLayoutDelayed_003Ed__68))]
	private IEnumerator RefreshLayoutDelayed()
	{
		return null;
	}

	private void UpdateProvinceInfo()
	{
	}

	private void OnBasicInfoSectionExpanded(CollapsibleSectionUI section)
	{
	}

	private void OnActionsSectionExpanded(CollapsibleSectionUI section)
	{
	}

	private void OnCampaignInfoSectionExpanded(CollapsibleSectionUI section)
	{
	}

	private void UpdateBasicInfoSection()
	{
	}

	private void UpdateEthnicityPanels()
	{
	}

	private void UpdateBiomePanels()
	{
	}

	private void UpdateResourcePanels()
	{
	}

	private void RefreshBasicInfoSectionLayout()
	{
	}

	private void ScheduleDelayedLayoutRefresh()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedLayoutRefresh_003Ed__79))]
	private IEnumerator DelayedLayoutRefresh()
	{
		return null;
	}

	private void UpdateActionsSection()
	{
	}

	private void UpdateCampaignInfoSection()
	{
	}

	private void AdjustPanelCount(List<SinglePanel> panels, int requiredCount, Transform parent)
	{
	}

	private void ClearPanels(List<SinglePanel> panels)
	{
	}

	private void UpdateProvinceName(string inputName)
	{
	}

	private void OnSetAsCapitalButtonClicked()
	{
	}

	private void OnSetAsFortressButtonClicked()
	{
	}

	private void OnSetAsCityButtonClicked()
	{
	}

	private void OnSetAsRegionCenterButtonClicked()
	{
	}

	private void RefreshRegionCenterCityIcon(int _provinceID)
	{
	}

	private void OnProvinceRebellionButtonClicked()
	{
	}

	private void OnStateClicked(int stateId)
	{
	}

	private void OnCharacterClicked(int characterId)
	{
	}

	private void OnCultureClicked(string cultureName)
	{
	}

	private void OnDistrictClicked(int districtId)
	{
	}

	private void OnFamilyClicked(int familyId)
	{
	}

	private void OnReligionClicked(string religionId)
	{
	}

	public void OnTranslateProvinceNameButtonClick()
	{
	}

	private void OnSetCustomPopulationButtonClicked()
	{
	}

	private void ShowSetCustomPopulationPanel()
	{
	}

	private void OnSetCustomDefenseButtonClicked()
	{
	}

	private void ShowSetCustomDefensePanel()
	{
	}

	private GameObject FindTranslationInputPrefab()
	{
		return null;
	}

	private void CreateCustomPopulationToggle(Transform parent, string localizationKey, bool currentValue, Action<bool> onValueChanged, string tooltipKeyOn = null, string tooltipKeyOff = null)
	{
	}

	private static void ApplyCustomLockToggleStyle(LocalizationToggleButton toggleButton)
	{
	}

	private TMP_InputField CreateCustomPopulationInputField(Transform parent, string labelKey, long defaultValue, GameObject translationInputPrefab)
	{
		return null;
	}

	private TMP_InputField CreateCustomValueInputField(Transform parent, string labelKey, string defaultValue, GameObject translationInputPrefab, TMP_InputField.ContentType contentType, int characterLimit)
	{
		return null;
	}

	private void BindCustomPopulationInputField(TMP_InputField inputField, Action<string> onValueChanged, Func<string, string> normalizeOnEndEdit = null)
	{
	}

	private static long ClampLong(long value, long min, long max)
	{
		return 0L;
	}

	private static long ParseDisplayPopulationOrDefault(string text, long fallback)
	{
		return 0L;
	}

	private static string NormalizeCustomPopulationCurrentText(string currentPopulationText, string maxPopulationText)
	{
		return null;
	}

	private static string NormalizeCustomPopulationMaxText(string maxPopulationText, string currentPopulationText)
	{
		return null;
	}

	private bool TryParseCustomPopulationInputs(string currentPopulationText, string maxPopulationText, out long currentPopulation, out long maxPopulation)
	{
		currentPopulation = default;
		maxPopulation = default;
		return false;
	}

	private static string FormatCustomDefenseValue(float value)
	{
		return null;
	}

	private static string FormatCustomDefenseModifier(float value)
	{
		return null;
	}

	private static float ParseCustomDefenseFloatOrDefault(string text, float fallback)
	{
		return 0f;
	}

	private static string NormalizeCustomDefenseCurrentText(string currentDefenseText, string maxDefenseText)
	{
		return null;
	}

	private static string NormalizeCustomDefenseMaxText(string maxDefenseText, string currentDefenseText)
	{
		return null;
	}

	private static string NormalizeCustomDefenseModifierText(string modifierText)
	{
		return null;
	}

	private bool TryParseCustomDefenseInputs(string currentDefenseText, string maxDefenseText, string homeFieldAdvantageText, out float currentDefense, out float maxDefense, out float homeFieldAdvantage)
	{
		currentDefense = default;
		maxDefense = default;
		homeFieldAdvantage = default;
		return false;
	}

	private void ShowCustomPopulationValidationMessage(string localizationKey)
	{
	}

	public void OnProvinceTranslationPanelClosed(string _key, Dictionary<string, string> _translations)
	{
	}
}
