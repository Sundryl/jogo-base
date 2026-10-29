using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DistrictInfoUI : BasePanelUI
{
	[CompilerGenerated]
	private sealed class _003CRefreshLayoutDelayed_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DistrictInfoUI _003C_003E4__this;

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
		public _003CRefreshLayoutDelayed_003Ed__62(int _003C_003E1__state)
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

	private static DistrictInfoUI s_Instance;

	private static GameObject s_InstanceObject;

	[SerializeField]
	[Header("区域名称控件")]
	private TMP_InputField m_DistrictNameInputField;

	[SerializeField]
	[Header("翻译面板")]
	private TranslationUIPanel m_TranslationUIPanel;

	[SerializeField]
	[Header("折叠区域")]
	private CollapsibleSectionUI m_BasicInfoSection;

	[SerializeField]
	private CollapsibleSectionUI m_ActionsSection;

	[SerializeField]
	private CollapsibleSectionUI m_TerritorySection;

	private District m_CurrentDistrict;

	private float m_UpdateInterval;

	private float m_LastUpdateTime;

	private Button m_TranslateDistrictNameButton;

	private Button m_SetDistrictCustomPopulationButton;

	private Button m_SetDistrictCustomDefenseButton;

	private int m_CachedDistrictId;

	private const string c_SetDistrictCustomPopulationButtonKey = "btn_SetDistrictCustomPopulation";

	private const string c_SetDistrictCustomPopulationTooltipKey = "SetDistrictCustomPopulationTooltip";

	private const string c_SetDistrictCustomPopulationTitleKey = "SetDistrictCustomPopulationTitle";

	private const string c_DistrictCurrentPopulationKey = "DistrictCurrentPopulation";

	private const string c_DistrictMaxPopulationKey = "DistrictMaxPopulation";

	private const string c_LockDistrictMaxPopulationKey = "LockDistrictMaxPopulation";

	private const string c_LockDistrictMaxPopulationTooltipOnKey = "LockDistrictMaxPopulationTooltipOn";

	private const string c_LockDistrictMaxPopulationTooltipOffKey = "LockDistrictMaxPopulationTooltipOff";

	private const string c_SetDistrictCustomPopulationInvalidKey = "SetDistrictCustomPopulationInvalid";

	private const int c_DistrictCustomPopulationMaxDigits = 18;

	private const string c_SetDistrictCustomDefenseButtonKey = "btn_SetDistrictCustomDefense";

	private const string c_SetDistrictCustomDefenseTooltipKey = "SetDistrictCustomDefenseTooltip";

	private const string c_SetDistrictCustomDefenseTitleKey = "SetDistrictCustomDefenseTitle";

	private const string c_CurrentCityDefenseKey = "CurrentCityDefense";

	private const string c_MaxCityDefenseKey = "MaxCityDefense";

	private const string c_LockMaxCityDefenseKey = "LockMaxCityDefense";

	private const string c_LockMaxCityDefenseTooltipOnKey = "LockMaxCityDefenseTooltipOn";

	private const string c_LockMaxCityDefenseTooltipOffKey = "LockMaxCityDefenseTooltipOff";

	private const string c_LockHomeFieldAdvantageKey = "LockHomeFieldAdvantage";

	private const string c_LockHomeFieldAdvantageTooltipOnKey = "LockHomeFieldAdvantageTooltipOn";

	private const string c_LockHomeFieldAdvantageTooltipOffKey = "LockHomeFieldAdvantageTooltipOff";

	private const string c_SetCustomDefenseInvalidKey = "SetCustomDefenseInvalid";

	private const int c_DistrictCustomDefenseValueMaxDigits = 10;

	private const int c_DistrictCustomDefenseModifierMaxDigits = 5;

	public static DistrictInfoUI Instance => null;

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

	private void FindTitleText()
	{
	}

	private void FindDistrictNameInputField()
	{
	}

	private void FindCollapsibleSections()
	{
	}

	private void InitializeSections()
	{
	}

	private void FindTranslationPanel()
	{
	}

	private void FindAndBindActionButtons()
	{
	}

	private void RefreshTranslateDistrictButtonLocalization()
	{
	}

	private void ConfigureLocalizedActionButton(Button button, string buttonKey, string tooltipKey)
	{
	}

	private Transform FindActionButtonSlot(Transform contentArea, string buttonName)
	{
		return null;
	}

	public void Display(int districtId)
	{
	}

	public void InitDistrictInfo(int districtId)
	{
	}

	public void OnDistrictInfoPanelButtonClose()
	{
	}

	protected override void OnPanelInitialize()
	{
	}

	protected override void OnPanelShow()
	{
	}

	protected override void OnPanelHide()
	{
	}

	protected override void RefreshLocalization()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshLayoutDelayed_003Ed__62))]
	private IEnumerator RefreshLayoutDelayed()
	{
		return null;
	}

	private void UpdateDistrictInfo()
	{
	}

	private void OnBasicInfoSectionExpanded(CollapsibleSectionUI section)
	{
	}

	private void OnActionsSectionExpanded(CollapsibleSectionUI section)
	{
	}

	private void OnTerritorySectionExpanded(CollapsibleSectionUI section)
	{
	}

	private void UpdateBasicInfoSection()
	{
	}

	private void UpdateTerritorySection()
	{
	}

	private void UpdateActionsSection()
	{
	}

	private void UpdateColorPickerDisplay()
	{
	}

	private void UpdateDistrictBorderHighlight()
	{
	}

	private void ClearDistrictBorderHighlight()
	{
	}

	private void UpdateDistrictName(string inputName)
	{
	}

	private void OnTranslateDistrictNameButtonClick()
	{
	}

	private void OnSetDistrictCustomPopulationButtonClicked()
	{
	}

	private void ShowSetDistrictCustomPopulationPanel()
	{
	}

	private void OnSetDistrictCustomDefenseButtonClicked()
	{
	}

	private void ShowSetDistrictCustomDefensePanel()
	{
	}

	private GameObject FindTranslationInputPrefab()
	{
		return null;
	}

	private TMP_InputField CreateDistrictValueInputField(Transform parent, string labelKey, string defaultValue, GameObject translationInputPrefab, TMP_InputField.ContentType contentType, int characterLimit)
	{
		return null;
	}

	private void BindDistrictValueInputField(TMP_InputField inputField, Action<string> onValueChanged, Func<string, string> normalizeOnEndEdit = null)
	{
	}

	private void CreateDistrictValueToggle(Transform parent, string localizationKey, bool currentValue, Action<bool> onValueChanged, string tooltipKeyOn, string tooltipKeyOff)
	{
	}

	private static void ApplyCustomLockToggleStyle(LocalizationToggleButton toggleButton)
	{
	}

	private static string FormatDistrictDefenseValue(float value)
	{
		return null;
	}

	private static string FormatDistrictDefenseModifier(float value)
	{
		return null;
	}

	private static float ParseDistrictDefenseFloatOrDefault(string text, float fallback)
	{
		return 0f;
	}

	private static string NormalizeDistrictDefenseCurrentText(string currentDefenseText, string maxDefenseText)
	{
		return null;
	}

	private static string NormalizeDistrictDefenseMaxText(string maxDefenseText, string currentDefenseText)
	{
		return null;
	}

	private static string NormalizeDistrictDefenseModifierText(string modifierText)
	{
		return null;
	}

	private static bool TryParseDistrictDefenseInputs(string currentDefenseText, string maxDefenseText, string homeFieldAdvantageText, out float currentDefense, out float maxDefense, out float homeFieldAdvantage)
	{
		currentDefense = default;
		maxDefense = default;
		homeFieldAdvantage = default;
		return false;
	}

	private static string NormalizeDistrictPopulationCurrentText(string currentPopulationText, string maxPopulationText, int provinceCount)
	{
		return null;
	}

	private static string NormalizeDistrictPopulationMaxText(string maxPopulationText, string currentPopulationText, int provinceCount)
	{
		return null;
	}

	private static bool TryParseDistrictPopulationInputs(string currentPopulationText, string maxPopulationText, int provinceCount, out long currentPopulation, out long maxPopulation)
	{
		currentPopulation = default;
		maxPopulation = default;
		return false;
	}

	private static void ApplyDistrictPopulationByPotential(List<Province> districtProvinces, long displayPopulation, long displayMaxPopulation, bool lockMaxPopulation)
	{
	}

	private static int[] DistributePopulationByPotential(List<Province> provinces, long totalPopulation, long minPopulationPerProvince, long[] caps)
	{
		return null;
	}

	private static double GetProvincePopulationDistributionWeight(Province province)
	{
		return 0.0;
	}

	private static long ToInternalDistrictPopulation(long displayPopulation, bool requirePositive)
	{
		return 0L;
	}

	private static long GetDistrictInternalPopulationCapacity(int provinceCount)
	{
		return 0L;
	}

	private static long GetMaxDistrictDisplayPopulation(int provinceCount)
	{
		return 0L;
	}

	private static long GetMinDistrictMaxDisplayPopulation(int provinceCount)
	{
		return 0L;
	}

	private static long ClampLong(long value, long min, long max)
	{
		return 0L;
	}

	private static long AddLongClamped(long left, long right)
	{
		return 0L;
	}

	private static long ParseDisplayPopulationOrDefault(string text, long fallback)
	{
		return 0L;
	}

	private void ShowDistrictValidationMessage(string localizationKey)
	{
	}

	private void OnDistrictTranslationPanelClosed(string key, Dictionary<string, string> translations)
	{
	}

	private void OnDistrictColorChanged(Color color)
	{
	}

	private void OnCultureClicked(string cultureId)
	{
	}

	private void OnReligionClicked(string religionId)
	{
	}

	private void OnFamilyClicked(int familyId)
	{
	}

	private void OnCharacterClicked(int characterId)
	{
	}

	private void OnProvinceClicked(int provinceId)
	{
	}

	private static List<Province> CollectDistrictProvinces(District district)
	{
		return null;
	}

	private static Province ResolveCenterProvince(District district, List<Province> districtProvinces)
	{
		return null;
	}

	private static string GetDominantCultureId(List<Province> districtProvinces)
	{
		return null;
	}

	private static string GetDominantReligionId(List<Province> districtProvinces)
	{
		return null;
	}

	private static int GetDominantFamilyId(List<Province> districtProvinces)
	{
		return 0;
	}

	private static string GetProvinceDisplayName(Province province)
	{
		return null;
	}
}
