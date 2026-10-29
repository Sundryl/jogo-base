using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FantasyWorld.CharacterSystem;
using Michsky.MUIP;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

internal class EditPanelUI : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	private enum FamilyEditLevel
	{
		StateList = 0,
		FamilyList = 1
	}

	private class StateDisplayItem
	{
		public State State;

		public string Name;

		public bool IsDrawn;

		public int StateID;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass502_0
	{
		public Dictionary<string, Dictionary<string, string>> allTranslationsForProvinces;

		internal void _003CTranslateAllProvinceNamesCoroutine_003Eb__1(string targetLang, Dictionary<string, string> translatedMap)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CTranslateAllProvinceNamesCoroutine_003Ed__502 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool showIntermediateMessages;

		private _003C_003Ec__DisplayClass502_0 _003C_003E8__1;

		public EditPanelUI _003C_003E4__this;

		private string _003CsourceLanguage_003E5__2;

		private List<string> _003CtargetLanguages_003E5__3;

		private Dictionary<string, List<Province>> _003CprovincesByName_003E5__4;

		private List<string> _003CuniqueProvinceNamesToTranslate_003E5__5;

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
		public _003CTranslateAllProvinceNamesCoroutine_003Ed__502(int _003C_003E1__state)
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
	private sealed class _003C_003Ec__DisplayClass503_0
	{
		public Dictionary<string, Dictionary<string, string>> allTranslationsForStates;

		internal void _003CTranslateAllStateNamesCoroutine_003Eb__1(string targetLang, Dictionary<string, string> translatedMap)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CTranslateAllStateNamesCoroutine_003Ed__503 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool showIntermediateMessages;

		private _003C_003Ec__DisplayClass503_0 _003C_003E8__1;

		public EditPanelUI _003C_003E4__this;

		private string _003CsourceLanguage_003E5__2;

		private List<string> _003CtargetLanguages_003E5__3;

		private Dictionary<string, List<State>> _003CstatesByName_003E5__4;

		private List<string> _003CuniqueStateNamesToTranslate_003E5__5;

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
		public _003CTranslateAllStateNamesCoroutine_003Ed__503(int _003C_003E1__state)
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
	private sealed class _003CTranslateAllProvinceAndStateCombinedCoroutine_003Ed__505 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EditPanelUI _003C_003E4__this;

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
		public _003CTranslateAllProvinceAndStateCombinedCoroutine_003Ed__505(int _003C_003E1__state)
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

	private const string c_DistrictEditPanelCloneName = "EditDistrict";

	private const string c_DistrictAddButtonName = "AddDistrict";

	private const string c_DistrictAddButtonSearchName = "AddNew";

	private const string c_DistrictRegenerateButtonName = "RegenerateDistricts";

	[SerializeField]
	private PaginationComponent m_BlankAreaPaginationComponent;

	public GameObject BlankAreaButtonPrefab;

	public GameObject BlankAreaButtonContainer;

	private List<GameObject> m_BlankAreaButtonsList;

	private Dictionary<int, LocalizationTmpButton> m_BlankAreaButtons;

	private Dictionary<int, State> m_UndrawnBlankAreas;

	private Dictionary<int, bool> m_IsUndrawnBlankAreaButton;

	private static int s_NextUndrawnBlankAreaID;

	[Header("空白区域编辑相关")]
	public Button DrawBlankAreaButton;

	public Button EraseBlankAreaButton;

	public Button AddUndrawnBlankAreaButton;

	public TMP_InputField blankAreaNameInputField;

	public SliderValueConnector BlankAreaBrushRadiusSlider;

	private Dictionary<int, State> m_BlankAreaStates;

	public Dictionary<int, BiomeSelection> BiomeSelections;

	private readonly List<EditPanelUIState> m_EditModeDropdownValueToMode;

	[Header("单例")]
	private static EditPanelUI _instance;

	public bool isEnabled;

	[Header("面板控制")]
	public EditPanelUIState m_CurrentEditMode;

	private Dictionary<EditPanelUIState, GameObject> m_ModePanelMap;

	public GameObject EditHeightPanel;

	public GameObject EditStatePanel;

	public GameObject EditBiomPanel;

	public GameObject EditCulturePanel;

	public GameObject EditReligionPanel;

	public GameObject EditCustomLabelPanel;

	public GameObject EditFamilyPanel;

	public GameObject GlobalCommandsPanel;

	public GameObject EditProvincePanel;

	public GameObject EditDistrictPanel;

	public GameObject EditBlankAreaPanel;

	public GameObject MapSizePanel;

	[Header("编辑模式选择")]
	public GameObject EditModeDropdown;

	public Dictionary<EnumBrushHeightModifyMode, string> brushModeTranslationKeys;

	[Header("高度编辑相关")]
	public Button EditHeightButton;

	public Button EraseContinentButton;

	public Button PlaceContinentButton;

	public SliderValueConnector BrushHeightSlider;

	public SliderValueConnector DecayFactor;

	public SliderValueConnector HeightBrushRadiusSlider;

	[Header("地图设置相关")]
	private List<int> PolyCount;

	public int polyCountIndex;

	[SerializeField]
	private DropdownInfo m_MapSizeDropdown;

	public float UseHeightmapBackgroundDisplaySetting;

	public float StateMapTransparency;

	[Header("国家编辑相关")]
	public TMP_InputField stateNameInputField;

	public TMP_InputField stateNameInputFieldForBlankState;

	public State randomNewBlankState;

	public TMP_Text StateInfoText;

	public SliderValueConnector StateCountSlider;

	public SliderValueConnector StateBrushRadiusSlider;

	public LocalizationTextWithAdditionalText StateCountText;

	public int currentDrawStateID;

	public int currentDrawDistrictID;

	public Button DrawStateButton;

	public Button EraseStateButton;

	public SwitchManager PlaceStateInSeaToggle;

	[Header("省份编辑相关")]
	public Button DrawProvinceButton;

	public Button PlaceProvinceButton;

	public TMP_InputField provinceNameInputField;

	public SliderValueConnector ProvinceBrushRadiusSlider;

	public int currentDrawProvinceID;

	public SliderValueConnector AverageProvinceCellCountSlider;

	[Header("生物群系编辑相关")]
	public int currentDrawBiomID;

	public SliderValueConnector PrecipitationFactor;

	public SliderValueConnector TemperatureModifier;

	public SliderValueConnector biomBrushSizeSlider;

	public LocalizationTextWithAdditionalText BiomText;

	[Header("文化编辑相关")]
	public GameObject CultureButtonPrefab;

	public GameObject CultureButtonContainer;

	public SliderValueConnector cultureSliderConnector;

	public Dictionary<string, LocalizationTmpButton> m_CultureButtons;

	private string m_CurrentSelectedCulture;

	[SerializeField]
	private PaginationComponent m_CulturePaginationComponent;

	private List<GameObject> m_CultureButtonsList;

	[SerializeField]
	private AddItemUIComponent m_AddNewCultureUI;

	public Button DrawCultureButton;

	public Button EraseCultureButton;

	[Header("宗教编辑相关")]
	public GameObject ReligionButtonPrefab;

	public GameObject ReligionButtonContainer;

	public SliderValueConnector religionSliderConnector;

	private Dictionary<string, LocalizationTmpButton> m_ReligionButtons;

	private string m_CurrentSelectedReligion;

	[SerializeField]
	private PaginationComponent m_ReligionPaginationComponent;

	private List<GameObject> m_ReligionButtonsList;

	[SerializeField]
	private AddItemUIComponent m_AddNewReligionUI;

	public Button DrawReligionButton;

	public Button EraseReligionButton;

	[Header("家族编辑相关")]
	[SerializeField]
	private PaginationComponent m_FamilyPaginationComponent;

	public GameObject FamilyButtonPrefab;

	public GameObject FamilyButtonContainer;

	public SliderValueConnector FamilyBrushRadiusSlider;

	[SerializeField]
	private AddItemUIComponent m_AddNewFamilyUI;

	public Button DrawFamilyButton;

	public Button EraseFamilyButton;

	public Button EditFamilyButton;

	public Button DeleteFamilyButton;

	public Button FamilyBackToStateListButton;

	[Header("自定义标签相关")]
	[SerializeField]
	private PaginationComponent m_CustomLabelPaginationComponent;

	public GameObject CustomLabelButtonPrefab;

	public GameObject CustomLabelButtonContainer;

	private List<GameObject> m_CustomLabelButtonsList;

	private Dictionary<string, LocalizationTmpButton> m_CustomLabelButtons;

	[SerializeField]
	private AddItemUIComponent m_AddNewCustomLabelUI;

	private string m_CurrentSelectedCustomLabelId;

	[Header("经纬度输入")]
	[SerializeField]
	private TMP_InputField m_NorthLatitudeInputField;

	[SerializeField]
	private TMP_InputField m_SouthLatitudeInputField;

	[SerializeField]
	private TMP_InputField m_EastLongitudeInputField;

	[SerializeField]
	private TMP_InputField m_WestLongitudeInputField;

	private float m_CurrentNorthLatitude;

	private float m_CurrentSouthLatitude;

	private float m_CurrentEastLongitude;

	private float m_CurrentWestLongitude;

	public bool isEnableSnowCoveredLandAndDesert;

	public bool isEnableMapEditDescription;

	public bool isEnableTooltips;

	public bool isShowRiverEditWarning;

	[Header("编辑面板暂停设置")]
	public bool isPauseWhenEditing;

	[Header("地图绘制相关")]
	public Button DrawRiverButton;

	public Button ClearRiverButton;

	[Header("游戏规则与外交相关")]
	public Button AllowRebelButton;

	public Button AllowDiplomacyButton;

	public Button AllowAutoAbandonIsolatedProvincesButton;

	public Button AssistAlliesOccupyLandButton;

	public Button AllowVassalRebelButton;

	public Button GenerateDesertAndSnowButton;

	public Button AllowAllianceButton;

	public Button EnableVassalButton;

	public Button AllowCivilWarButton;

	public Button AllowFamilyRebellionButton;

	public Button RegenerateDistrictsButton;

	public Button AutoSaveButton;

	public Button ClearHistoryButton;

	public Button RebelIntervalSettingsButton;

	public Button SetCustomTimeButton;

	public Button EnableMapEditDescriptionButton;

	public Button EnableTooltipsButton;

	public Button PauseWhenEditingButton;

	[Header("国家列表相关")]
	[SerializeField]
	private PaginationComponent m_StatePaginationComponent;

	public GameObject StateButtonPrefab;

	public GameObject StateButtonContainer;

	private List<GameObject> m_StateButtonsList;

	private Dictionary<int, LocalizationTmpButton> m_StateButtons;

	private Dictionary<int, State> m_UndrawnStates;

	private Dictionary<int, bool> m_IsUndrawnStateButton;

	private static int s_NextUndrawnStateID;

	private FamilyEditLevel m_FamilyEditLevel;

	private int m_FamilyEditSelectedStateId;

	private int m_CurrentSelectedFamilyId;

	private int m_FamilyEditHighlightedFamilyId;

	private int m_FamilyEditHighlightedStateId;

	private int m_DistrictEditHighlightedDistrictId;

	private readonly List<GameObject> m_FamilyButtonsList;

	private readonly Dictionary<int, LocalizationTmpButton> m_FamilyButtons;

	private readonly Dictionary<int, bool> m_FamilyEditDistributionBackup;

	private bool m_IsFamilyDistributionBackupValid;

	private const string c_FamilyEditStateBorderHighlightContextKey = "EditPanelUI.FamilyEdit.StateBorder";

	private const string c_EnableVassalButtonKey = "EnableVassal";

	private const string c_AutoSaveButtonKey = "AutoSave";

	private const string c_ClearHistoryButtonKey = "ClearAllHistory";

	private const string c_ClearHistoryConfirmKey = "ClearAllHistoryConfirm";

	private const string c_ClearHistoryCompletedKey = "ClearAllHistoryCompleted";

	private const string c_AutoSaveSettingsTitleKey = "AutoSaveSettings";

	private const string c_AutoSaveIntervalMinutesKey = "AutoSaveIntervalMinutes";

	private const string c_AutoSaveEnabledKey = "AutoSaveEnabled";

	private const int c_AutoSaveIntervalSliderMinMinutes = 5;

	private const int c_AutoSaveIntervalSliderMaxMinutes = 60;

	private const string c_RebelIntervalSettingsButtonKey = "AIGlobalConfig";

	private const string c_SetCustomTimeButtonObjectName = "SetCustomTime";

	private const string c_SetCustomTimeButtonKey = "SetCustomTime";

	private const string c_SetCustomTimeEraLabelKey = "Era";

	private const string c_SetCustomTimeADOptionKey = "ADEra";

	private const string c_SetCustomTimeBCOptionKey = "BCEra";

	private const string c_SetCustomTimeInputInvalidKey = "SetCustomTimeInputInvalid";

	private const string c_SetCustomTimeDateInvalidKey = "SetCustomTimeDateInvalid";

	private const int c_SetCustomTimeMinYear = 1;

	private const int c_SetCustomTimeMaxYear = 5000;

	private const int c_SetCustomTimeMinMonth = 1;

	private const int c_SetCustomTimeMaxMonth = 12;

	private const int c_SetCustomTimeMinDay = 1;

	private const int c_SetCustomTimeMaxDay = 31;

	private const string c_AIGlobalOptionsResetButtonKey = "ResetAIOptions";

	private const string c_AIGlobalParametersResetButtonKey = "ResetAIParameters";

	private const string c_WarSystemSwitchForcePeaceWarningKey = "WarSystemSwitchForcePeaceWarning";

	private const string c_ProvinceRebelMinMonthsKey = "ProvinceRebelMinMonths";

	private const string c_FamilyRebelMinMonthsKey = "FamilyRebelMinMonths";

	private const string c_CivilWarMinMonthsKey = "CivilWarMinMonths";

	private const string c_MinMonthToBeginAnotherWarKey = "MinMonthToBeginAnotherWar";

	private const string c_MinMonthAfterPassiveWarToBeginNewKey = "MinMonthAfterPassiveWarToBeginNew";

	private const string c_MaxMonthBeforeForceEndWarKey = "MaxMonthBeforeForceEndWar";

	private const int c_RebelIntervalSliderMinMonths = 0;

	private const int c_RebelIntervalSliderMaxMonths = 240;

	private const int c_MaxWarDurationSliderMaxMonths = 480;

	private static readonly Color s_AIGlobalConfigButtonBaseColor;

	private static readonly Color s_AIGlobalOptionsResetButtonBaseColor;

	private static readonly Color s_AIGlobalParametersResetButtonBaseColor;

	private static readonly Color s_ClearHistoryButtonBaseColor;

	[SerializeField]
	private PaginationComponent m_DistrictPaginationComponent;

	public GameObject DistrictButtonPrefab;

	public GameObject DistrictButtonContainer;

	[Header("区域编辑相关")]
	public Button DrawDistrictButton;

	public Button EraseDistrictButton;

	public Button AddDistrictButton;

	public Button CreateDistrictButton;

	public Button RegenerateDistrictsInDistrictPanelButton;

	public TMP_InputField districtNameInputField;

	public SliderValueConnector DistrictBrushRadiusSlider;

	private Button m_EditDistrictButton;

	private Button m_DeleteDistrictButton;

	private readonly List<GameObject> m_DistrictButtonsList;

	private readonly Dictionary<int, LocalizationTmpButton> m_DistrictButtons;

	private GameObject EditCustomImagePanel;

	private GameObject m_CustomImageButtonContainer;

	private GameObject m_CustomImageButtonPrefab;

	private PaginationComponent m_CustomImagePaginationComponent;

	private AddItemUIComponent m_AddNewCustomImageUI;

	private readonly List<GameObject> m_CustomImageButtonsList;

	private readonly Dictionary<string, LocalizationTmpButton> m_CustomImageButtons;

	private string m_CurrentSelectedCustomImageId;

	private Button m_EditCustomImageButton;

	private Button m_CopyCustomImageButton;

	private Button m_DeleteCustomImageButton;

	private string m_PendingCustomImageName;

	private string m_PendingReplaceCustomImageId;

	public static EditPanelUI Instance => null;

	private void InitializeBlankAreaEditing()
	{
	}

	private void EnsureDistrictEditingUI()
	{
	}

	private bool IsDistrictEditingUIReady()
	{
		return false;
	}

	private void ArrangeDistrictPanelLayout(Transform actionPanel)
	{
	}

	private static void TightenDistrictListSectionSpacing(Transform districtListSection)
	{
	}

	private void BindDistrictButton(Button button, UnityAction action)
	{
	}

	private Button FindDistrictRegenerateTemplateButton()
	{
		return null;
	}

	private void ApplyDistrictPrimaryActionButtonStyle(Button targetButton, Button templateButton)
	{
	}

	private static Transform FindSharedVerticalLayoutAncestor(Transform first, Transform second)
	{
		return null;
	}

	private static Transform GetDirectChildUnderAncestor(Transform child, Transform ancestor)
	{
		return null;
	}

	private static Button FindDistrictAddButton(GameObject panelRoot, TMP_InputField inputField)
	{
		return null;
	}

	private static Button FindDistrictActionButton(GameObject panelRoot, string persistentMethodName, string fallbackObjectName)
	{
		return null;
	}

	private static Transform FindChildByNameRecursive(Transform parent, string targetName)
	{
		return null;
	}

	private static Button FindInputFieldCompanionButton(TMP_InputField inputField)
	{
		return null;
	}

	private static GameObject CloneMappedGameObject(GameObject sourceRoot, GameObject clonedRoot, GameObject sourceObject)
	{
		return null;
	}

	private static T CloneMappedComponent<T>(GameObject sourceRoot, GameObject clonedRoot, Component sourceComponent) where T : Component
	{
		return null;
	}

	private static Transform CloneMappedTransform(GameObject sourceRoot, GameObject clonedRoot, Transform sourceTransform)
	{
		return null;
	}

	private static string GetRelativePath(Transform target, Transform root)
	{
		return null;
	}

	private static void ResetButtonClickEvents(Button button)
	{
	}

	private static Button EnsureDistrictActionButton(Button existingButton, Button templateButton, Transform parent, string objectName, string localizationKey)
	{
		return null;
	}

	public void RefreshBlankAreaButtons()
	{
	}

	private void ClearBlankAreaButtons()
	{
	}

	private void OnBlankAreaPageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private void DisplayBlankAreaPage(int startIndex, int endIndex, List<State> displayItems)
	{
	}

	private void CreateBlankAreaButton(State item)
	{
	}

	private void OnBlankAreaButtonClicked(int stateID)
	{
	}

	private void UpdateBlankAreaButtonSelectionState()
	{
	}

	public void OnNewRandomBlankAreaClicked()
	{
	}

	public void UpdateBlankAreaName(string name)
	{
	}

	public void OnDrawBlankAreaButtonClicked()
	{
	}

	public void OnPlaceBlankAreaButtonClicked()
	{
	}

	public void OnEraseBlankAreaButtonClicked()
	{
	}

	public void OnEditBlankAreaButtonClicked()
	{
	}

	public void OnDeleteBlankAreaButtonClicked()
	{
	}

	public void EditRemoveBlankArea()
	{
	}

	public void OnBlankAreaNameInputEndEdit(string name)
	{
	}

	public void SwitchToBlankAreaEditMode()
	{
	}

	public void AddUndrawnBlankAreaName(string areaName)
	{
	}

	public void OnAddUndrawnBlankAreaButtonClicked()
	{
	}

	public void ClearUndrawnBlankAreas()
	{
	}

	public State GetBlankAreaForDrawing(int areaID)
	{
		return null;
	}

	internal bool IsUndrawnBlankArea(int _areaID)
	{
		return false;
	}

	internal State GetUndrawnBlankArea(int _areaID)
	{
		return null;
	}

	internal void RemoveUndrawnBlankArea(int _areaID)
	{
	}

	private T FindSiblingComponent<T>(Transform target) where T : Component
	{
		return null;
	}

	public void UpdateBiomeRelatedText()
	{
	}

	public float GetNorthLatitude()
	{
		return 0f;
	}

	public float GetSouthLatitude()
	{
		return 0f;
	}

	public float GetEastLongitude()
	{
		return 0f;
	}

	public float GetWestLongitude()
	{
		return 0f;
	}

	private void RefreshCoordinateInputFields()
	{
	}

	private void ApplyMapCoordinateChanges()
	{
	}

	private void ShowCoordinateAdjustedWarning_Range(string _coordinateNameKey, float _min, float _max, float _adjustedValue)
	{
	}

	private void ShowCoordinateAdjustedWarning_NotBelow(string _coordinateNameKey, string _otherCoordinateNameKey, float _adjustedValue)
	{
	}

	private void ShowCoordinateAdjustedWarning_NotAbove(string _coordinateNameKey, string _otherCoordinateNameKey, float _adjustedValue)
	{
	}

	private void OnNorthLatitudeInputFieldValueChanged(string _value)
	{
	}

	private void OnSouthLatitudeInputFieldValueChanged(string _value)
	{
	}

	private void OnEastLongitudeInputFieldValueChanged(string _value)
	{
	}

	private void OnWestLongitudeInputFieldValueChanged(string _value)
	{
	}

	public bool IsPlaceStateInSea()
	{
		return false;
	}

	public void Awake()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void BringToFront()
	{
	}

	private void FindAdditionalButtons()
	{
	}

	private void HideMergedAIGlobalCommandButtons()
	{
	}

	private static void SetGlobalCommandButtonVisibility(Button button, bool isVisible)
	{
	}

	private void FindOrCreateAutoSaveButton()
	{
	}

	private void FindOrCreateRebelIntervalSettingsButton()
	{
	}

	private void FindOrCreateClearHistoryButton()
	{
	}

	private void FindOrCreateSetCustomTimeButton()
	{
	}

	private void ApplyAIGlobalConfigButtonStyleAndOrder()
	{
	}

	private void ApplyClearHistoryButtonStyleAndOrder()
	{
	}

	private static void ApplyButtonBaseColor(Button button, Color baseColor)
	{
	}

	private void Start()
	{
	}

	private void BindButtonIfNoPersistentListener(Button _button, UnityAction _action)
	{
	}

	private void InitializeModePanelMap()
	{
	}

	private void SwitchToEditMode(EditPanelUIState mode)
	{
	}

	private void UpdateDropdownValue()
	{
	}

	private void OnEditModeDropdownValueChanged(int value)
	{
	}

	public void OpenGlobalCommandsPanel()
	{
	}

	public void UpdateBlankStateName(string name)
	{
	}

	public void ResetProvinceInputField()
	{
	}

	public void SetClickToGen()
	{
	}

	public void ClearMap()
	{
	}

	public void OnClearMapButtonClicked()
	{
	}

	public void WorldClearMap()
	{
	}

	public void ReDrawRelief()
	{
	}

	public void OnDrawProvicneButtonClicked()
	{
	}

	public void OnDrawStateButtonClicked()
	{
	}

	public void OnAddProvinceButtonClicked()
	{
	}

	public void OnMapSizeSwitchButtonClicked(int index)
	{
	}

	public void ChangeMapSize(int index)
	{
	}

	public void OnNewRandomStateClicked()
	{
	}

	public void OnRandomStateNameButtonClicked()
	{
	}

	public void OnRandomProvinceNameButtonClicked()
	{
	}

	public void OnNewRandomUnConquerableBlankStateClicked()
	{
	}

	public void OnDisableAllAllianceButtonClicked()
	{
	}

	public void OnAutoSaveButtonClick()
	{
	}

	public void OnClearHistoryButtonClicked()
	{
	}

	private void ClearAllHistoryData()
	{
	}

	public void SetAutoSaveIntervalMinutes(int _minutes)
	{
	}

	public int GetAutoSaveIntervalMinutes()
	{
		return 0;
	}

	private void ShowAutoSaveSettingsPanel()
	{
	}

	private void CreateAutoSaveEnabledToggle(Transform parent, bool currentValue, Action<bool> onValueChanged)
	{
	}

	private void CreateAutoSaveIntervalSlider(Transform parent, int currentValue, Action<int> onValueChanged)
	{
	}

	public void OnAllowCivilWarButtonClicked()
	{
	}

	public void OnAllowFamilyRebellionButtonClicked()
	{
	}

	public void OnSetCustomTimeButtonClicked()
	{
	}

	private void ShowSetCustomTimePanel()
	{
	}

	private DropdownInfo CreateSetCustomTimeEraDropdown(Transform parent, bool defaultIsAD)
	{
		return null;
	}

	private TMP_InputField CreateSetCustomTimeInputField(Transform parent, string labelKey, int defaultValue, int maxCharacterCount, GameObject translationInputPrefab)
	{
		return null;
	}

	private void BindSetCustomTimeEraDropdown(DropdownInfo dropdownInfo, Action<bool> onValueChanged)
	{
	}

	private void BindSetCustomTimeInputField(TMP_InputField inputField, Action<string> onValueChanged)
	{
	}

	private TMP_InputField CreateSetCustomTimeInputFieldFromTranslationPrefab(Transform parent, string labelKey, GameObject translationInputPrefab)
	{
		return null;
	}

	private TMP_InputField CreateSetCustomTimeInputFieldFromTemplate(Transform parent, string labelKey)
	{
		return null;
	}

	private void ConfigureSetCustomTimeInputField(TMP_InputField inputField, int defaultValue, int maxCharacterCount, string labelKey)
	{
	}

	private GameObject FindTranslationInputPrefab()
	{
		return null;
	}

	private bool TryParseSetCustomTimeInputs(string yearText, string monthText, string dayText, out int year, out int month, out int day)
	{
		year = default;
		month = default;
		day = default;
		return false;
	}

	private void ShowSetCustomTimeValidationMessage(string localizationKey)
	{
	}

	public void OnRebelIntervalSettingsButtonClicked()
	{
	}

	private void ShowRebelIntervalSettingsPanel()
	{
	}

	private LocalizationToggleButton CreateAIGlobalConfigToggle(Transform parent, string localizationKey, bool currentValue, Action<bool> onValueChanged)
	{
		return null;
	}

	private void RequestWarSystemSwitch(bool targetUseV2, LocalizationToggleButton toggleButton)
	{
	}

	private Button CreateAIGlobalConfigActionButton(Transform parent, string localizationKey, Color baseColor, Action onClick)
	{
		return null;
	}

	private Button GetAIGlobalActionButtonTemplate(Transform parent)
	{
		return null;
	}

	private Button GetAIGlobalConfigToggleTemplateButton()
	{
		return null;
	}

	private static int ClampRebelIntervalMonthValue(int _value)
	{
		return 0;
	}

	private static bool ApplyRebelIntervalSettingsAndSaveIfNeeded(int _provinceRebelMinMonths, int _familyRebelMinMonths, int _civilWarMinMonths, int _minMonthToBeginAnotherWar, int _minMonthAfterPassiveWarToBeginNew, int _maxMonthBeforeForceEndWar)
	{
		return false;
	}

	private bool ApplyAIGlobalSettingsAndSaveIfNeeded(bool allowAutoDiplomacy, bool allowRebel, bool allowVassalRebel, bool allowAlliance, bool assistAlliesOccupyLand, bool autoAbandonIsolatedProvinces, bool allowCivilWar, bool allowFamilyRebellion, bool enableVassal)
	{
		return false;
	}

	private SliderValueConnector CreateRebelIntervalSlider(Transform parent, string titleKey, int currentValue, Action<int> onValueChanged)
	{
		return null;
	}

	private SliderValueConnector CreateRebelIntervalSlider(Transform parent, string titleKey, int currentValue, int minValue, int maxValue, Action<int> onValueChanged)
	{
		return null;
	}

	private static void SaveConfigImmediately()
	{
	}

	public void OnPlaceStateButtonClicked()
	{
	}

	public void OnEditPanelClose()
	{
	}

	public void OnGenerateStateButtonClicked()
	{
	}

	public void OnShowRegenerateBiomWarningPanel()
	{
	}

	private void WorldRegenerateBiom()
	{
	}

	public void GenerateState()
	{
	}

	public void OnRegenerateStateButtonClicked(bool isRegenerateProvinceName = true)
	{
	}

	private static DistrictRuntimeSnapshot CaptureDistrictSnapshotForStateGeneration(bool shouldPreserveDistricts)
	{
		return null;
	}

	private void RestoreDistrictSnapshotAfterStateGeneration(DistrictRuntimeSnapshot snapshot)
	{
	}

	private static ReligionRuntimeSnapshot CaptureReligionSnapshotForStateGeneration(bool shouldPreserveReligions)
	{
		return null;
	}

	private void RestoreReligionSnapshotAfterStateGeneration(ReligionRuntimeSnapshot snapshot)
	{
	}

	public void OnDrawHeightButtonClicked()
	{
	}

	public void OnEraseHeightButtonClicked()
	{
	}

	public void OnRenameProvinceBasedOnCultureButtonClicked()
	{
	}

	public void RenameProvinceBasedOnCulture()
	{
	}

	public void OnClickGenContinentButtonClicked()
	{
	}

	public void OnGenHeightMapButtonClicked()
	{
	}

	public void WorldGenerateHeightMap()
	{
	}

	public void RefreshLocalization()
	{
	}

	private void InitToggleButtons()
	{
	}

	private void InitStart()
	{
	}

	private void InitializeSliders()
	{
	}

	public void OnShowAddExitingCultureSetPanelButtonClicked()
	{
	}

	private void AddExistingCultureToMapManager(string _cultureNameID)
	{
	}

	public void OnCulturePanelButtonClicked()
	{
	}

	public void OnShowAddExitingReligionSetPanelButtonClicked()
	{
	}

	private void AddExistingReligionToMapManager(string _religionId)
	{
	}

	public void OnReligionPanelButtonClicked()
	{
	}

	public void OnMapSizePanelButtonClicked()
	{
	}

	internal void InitEditPanel()
	{
	}

	public void NotifyUserToggledPauseState()
	{
	}

	private void CaptureAndForcePauseOnEditPanelOpen()
	{
	}

	private void RestorePauseStateAfterEditPanelClose()
	{
	}

	public void RefreshAllPaginationButtons()
	{
	}

	private void UpdateDisplaySetting()
	{
	}

	private void EnsureTerrainOverlayReady()
	{
	}

	public void OnEndAllWarButtonClicked()
	{
	}

	public void OnEndAllAllianceButtonClicked()
	{
	}

	public void OnDrawBiomButtonClicked()
	{
	}

	public void OnDrawCultureButtonClicked()
	{
	}

	public void OnEraseCultureButtonClicked()
	{
	}

	public void OnDrawReligionButtonClicked()
	{
	}

	public void OnEraseReligionButtonClicked()
	{
	}

	public void OnDrawFamilyButtonClicked()
	{
	}

	public void OnEraseFamilyButtonClicked()
	{
	}

	public void OnEditFamilyButtonClicked()
	{
	}

	public void OnDeleteFamilyButtonClicked()
	{
	}

	public void OnFamilyBackToStateListButtonClicked()
	{
	}

	public void OnEditReligionButtonClicked()
	{
	}

	public void OnDeleteReligionButtonClicked()
	{
	}

	public void OnEraseStateButtonClicked()
	{
	}

	public void OnRegenerateSeaRouteAndRiverButtonClicked()
	{
	}

	public void RegenerateSeaRouteAndRiver(bool isGenerateRiver, bool isGenerateRoute)
	{
	}

	[Obsolete("暂时废弃，保留以兼容旧的绑定。")]
	public void OnDrawRiverButtonClicked()
	{
	}

	private void OnDrawRiverButtonClickedNew()
	{
	}

	public void OnClearRiverButtonClicked()
	{
	}

	public void OnDrawBlankUnConquerableStateButtonClicked()
	{
	}

	public int GetCurrentDrawProvinceMode()
	{
		return 0;
	}

	private void ShowRiverEditWarningIfNeeded()
	{
	}

	public void OnGenerateProvinceButtonClicked()
	{
	}

	public void GenerateProvince()
	{
	}

	public float GetAverageProvinceCellCount()
	{
		return 0f;
	}

	public void InitializeEditModeDropdown()
	{
	}

	private string GetEditModeTranslation(EditPanelUIState mode)
	{
		return null;
	}

	public void InitializeProvinceEditing()
	{
	}

	public void OnPrecipationFactorChanged(float value)
	{
	}

	public void OnTemperatureModifierChanged(float value)
	{
	}

	private void RefreshCultureButtons()
	{
	}

	private void ClearCultureButtons()
	{
	}

	private void OnCulturePageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private void DisplayCulturePage(int startIndex, int endIndex)
	{
	}

	private void CreateCultureButton(string cultureName)
	{
	}

	private void OnCultureButtonClicked(string _cultureName)
	{
	}

	private void UpdateCultureButtonSelectionState()
	{
	}

	public string GetSelectedCultureNameID()
	{
		return null;
	}

	private void RefreshReligionButtons()
	{
	}

	private void OnReligionPageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private void DisplayReligionPage(int startIndex, int endIndex)
	{
	}

	private void CreateReligionButton(string religionId)
	{
	}

	private void OnReligionButtonClicked(string _religionId)
	{
	}

	private void UpdateReligionButtonSelectionState()
	{
	}

	private void ClearReligionButtons()
	{
	}

	public string GetSelectedReligionID()
	{
		return null;
	}

	public void SetSelectedReligionID(string religionId)
	{
	}

	private PaginationComponent GetFamilyPaginationComponent()
	{
		return null;
	}

	private GameObject GetFamilyButtonPrefab()
	{
		return null;
	}

	private GameObject GetFamilyButtonContainer()
	{
		return null;
	}

	private void ClearFamilyButtons()
	{
	}

	private void UpdateFamilyButtonSelectionState()
	{
	}

	private void UpdateFamilyEditSelectionHighlight()
	{
	}

	private void ClearFamilyEditSelectionHighlight()
	{
	}

	private void UpdateFamilyEditStateBorderHighlight()
	{
	}

	private void ClearFamilyEditStateBorderHighlight()
	{
	}

	private void UpdateFamilyEditNavigationUI()
	{
	}

	private bool IsFamilyEditReadyForPaint()
	{
		return false;
	}

	private void CacheFamilyDistributionViewState()
	{
	}

	private void RestoreFamilyDistributionViewState()
	{
	}

	private void ApplyFamilyDistributionViewForEditState(int stateId)
	{
	}

	private void RefreshFamilyDistributionViewForStates(List<State> states)
	{
	}

	private void RefreshFamilyLayout()
	{
	}

	public bool TryHandleFamilyEditAltClick(int cellIndex)
	{
		return false;
	}

	public bool TryHandleFamilyEditShiftClick(int cellIndex)
	{
		return false;
	}

	private void InitializeFamilyEditing()
	{
	}

	private void EnterFamilyEditStateList()
	{
	}

	private void EnterFamilyEditFamilyList(int stateId)
	{
	}

	public int GetFamilyEditFocusedStateId()
	{
		return 0;
	}

	public int GetSelectedFamilyId()
	{
		return 0;
	}

	public void SetSelectedFamilyId(int familyId)
	{
	}

	public void RefreshFamilyButtons()
	{
	}

	private void OnFamilyEditStatePageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private void DisplayFamilyEditStatePage(int startIndex, int endIndex, List<State> aliveStates)
	{
	}

	private void CreateFamilyEditStateButton(State state)
	{
	}

	private void OnFamilyEditFamilyPageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private void DisplayFamilyPage(int startIndex, int endIndex, List<Family> families)
	{
	}

	private void CreateFamilyButton(Family family)
	{
	}

	public void SetSelectedCultureNameID(string cultureName)
	{
	}

	public void OnEditCultureButtonClicked()
	{
	}

	public void OnShowEditMapCulturePanelButtonClicked(string _cultureName)
	{
	}

	private void HandleAddCultureRequest(string cultureName)
	{
	}

	private void HandleAddFamilyRequest(string familyNameRaw)
	{
	}

	private void AddNewFamily(string familyName, string cultureId, string religionId, int stateId, int homeProvinceId)
	{
	}

	private void AddNewMapCulture(string newCultureNameRaw)
	{
	}

	private void RefreshLayout()
	{
	}

	private void TryAssignAddNewFamilyUI()
	{
	}

	private string ConvertToIdFormat(string input)
	{
		return null;
	}

	private void HandleAddReligionRequest(string religionName)
	{
	}

	private void AddNewMapReligion(string newReligionNameRaw)
	{
	}

	public void DeleteSelectedCulture()
	{
	}

	public void OnDeleteCultureButtonClicked()
	{
	}

	public void RefreshStateButtons()
	{
	}

	private void ClearStateButtons()
	{
	}

	private void OnStatePageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private void DisplayStatePage(int startIndex, int endIndex, List<StateDisplayItem> displayItems)
	{
	}

	private void CreateStateButton(StateDisplayItem item)
	{
	}

	private void OnStateButtonClicked(int stateID)
	{
	}

	private void UpdateStateButtonSelectionState()
	{
	}

	public void SetSelectedStateID(int stateID)
	{
	}

	private void InitializeMapSizeDropdown()
	{
	}

	private void OnMapSizeDropdownValueChanged(int selectedIndex)
	{
	}

	public void AddUndrawnStateName(string stateName)
	{
	}

	public void OnAddUndrawnStateNameButtonClicked()
	{
	}

	public void ClearUndrawnStateNames()
	{
	}

	public void OnEditStateButtonClicked()
	{
	}

	public void DeleteCurrentState()
	{
	}

	public void OnDeleteStateButtonClicked()
	{
	}

	public State GetStateForDrawing(int stateID)
	{
		return null;
	}

	public void SetCurrentDrawStateID(int stateID)
	{
	}

	internal bool IsUndrawState(int _stateID)
	{
		return false;
	}

	internal State GetUndrawState(int _stateID)
	{
		return null;
	}

	internal void RemoveUndrawState(int _stateID)
	{
	}

	public void OnAllowAutoDiplomacyButtonClick()
	{
	}

	public void OnAllowAutoAbandonIsolatedProvincesButtonClick()
	{
	}

	public void OnEnableRebellionsButtonClick()
	{
	}

	public void OnAssistAlliesOccupyLandButtonClick()
	{
	}

	public void OnAllowVassalRebelButtonClick()
	{
	}

	public void OnGenerateDesertAndSnowButtonClick()
	{
	}

	public void OnAllowAllianceButtonClick()
	{
	}

	public void OnEnableMapEditDescriptionButtonClick()
	{
	}

	public void OnEnableTooltipsButtonClick()
	{
	}

	public void OnPauseWhenEditingButtonClick()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnRegenerateDistrictsButtonClicked()
	{
	}

	public void TranslateAllProvince()
	{
	}

	public void TranslateAllState()
	{
	}

	public void OnTranslateMapButtonClick()
	{
	}

	[IteratorStateMachine(typeof(_003CTranslateAllProvinceNamesCoroutine_003Ed__502))]
	private IEnumerator TranslateAllProvinceNamesCoroutine(bool showIntermediateMessages = true)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTranslateAllStateNamesCoroutine_003Ed__503))]
	private IEnumerator TranslateAllStateNamesCoroutine(bool showIntermediateMessages = true)
	{
		return null;
	}

	public void TranslateAllProvinceAndState()
	{
	}

	[IteratorStateMachine(typeof(_003CTranslateAllProvinceAndStateCombinedCoroutine_003Ed__505))]
	private IEnumerator TranslateAllProvinceAndStateCombinedCoroutine()
	{
		return null;
	}

	public void OnShowTipsButtonClick()
	{
	}

	private void InitializeCustomLabelEditing()
	{
	}

	private void RefreshCustomLabelButtons()
	{
	}

	private void OnCustomLabelPageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private void DisplayCustomLabelPage(int startIndex, int endIndex, List<CustomLabelData> labels)
	{
	}

	private void ClearCustomLabelButtons()
	{
	}

	private void CreateCustomLabelButton(CustomLabelData data)
	{
	}

	private void OnCustomLabelItemClicked(string id)
	{
	}

	private void UpdateCustomLabelSelectionState()
	{
	}

	public void RefreshCustomLabelLocalizationView()
	{
	}

	private void HandleAddCustomLabelRequest(string text)
	{
	}

	public void OnEditCustomLabelButtonClicked()
	{
	}

	private void SyncCustomLabelInfoPanel()
	{
	}

	public void OnCustomLabelsCleared()
	{
	}

	public void OnDeleteCustomLabelButtonClicked()
	{
	}

	private void InitializeDistrictEditing()
	{
	}

	public void RefreshDistrictButtons(bool forceRefreshWhenHidden = false)
	{
	}

	private void OnDistrictPageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private void DisplayDistrictPage(int startIndex, int endIndex, List<District> districtItems)
	{
	}

	private void ClearDistrictButtons()
	{
	}

	private void CreateDistrictListButton(District district)
	{
	}

	private void OnDistrictListButtonClicked(int districtId)
	{
	}

	public void SetCurrentDrawDistrictID(int districtId)
	{
	}

	public void RefreshVisibleDistrictButtonStates()
	{
	}

	public void RefreshVisibleDistrictButtonColor(int districtId)
	{
	}

	private void UpdateDistrictButtonSelectionState()
	{
	}

	private void UpdateDistrictEditSelectionHighlight()
	{
	}

	private void ClearDistrictEditSelectionHighlight()
	{
	}

	private void ResetDistrictNameInputField()
	{
	}

	public void OnCreateDistrictButtonClicked()
	{
	}

	public void OnAddDistrictButtonClicked()
	{
	}

	public void OnEditDistrictButtonClicked()
	{
	}

	public void OnDeleteDistrictButtonClicked()
	{
	}

	private void DeleteCurrentDistrict()
	{
	}

	public void OnDistrictNameInputEndEdit(string name)
	{
	}

	public void OnDrawDistrictButtonClicked()
	{
	}

	public void OnEraseDistrictButtonClicked()
	{
	}

	public void OnRegenerateDistrictsForEditButtonClicked()
	{
	}

	private void ShowRegenerateDistrictsWarning(bool clearCurrentSelection, bool refreshStateInfoPanel)
	{
	}

	private bool TryRegenerateDistricts(bool clearCurrentSelection, bool refreshStateInfoPanel)
	{
		return false;
	}

	private bool HasAvailableProvinceForDistrictRegeneration()
	{
		return false;
	}

	private void ShowDistrictRegenerationUnavailableWarning()
	{
	}

	private static void UpdateActionButtonLocalization(Button button, bool isActive, string inactiveKey)
	{
	}

	public void RefreshDistrictEditButtonLocalization()
	{
	}

	private void EnsureCustomImageEditingUI()
	{
	}

	private void ApplyCustomImagePanelLocalization()
	{
	}

	private static void ApplyActionButtonLocalization(Button button, string localizationKey)
	{
	}

	private void InitializeCustomImageEditing()
	{
	}

	public void RefreshCustomImageLocalizationView()
	{
	}

	private void RefreshCustomImageButtons()
	{
	}

	private void OnCustomImagePageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private void DisplayCustomImagePage(int startIndex, int endIndex, List<CustomMapImageData> images)
	{
	}

	private void ClearCustomImageButtons()
	{
	}

	private void CreateCustomImageButton(CustomMapImageData data)
	{
	}

	private void OnCustomImageItemClicked(string imageId)
	{
	}

	private void UpdateCustomImageSelectionState()
	{
	}

	private void HandleAddCustomImageRequest(string displayName)
	{
	}

	public void BeginReplaceCustomImage(string imageId)
	{
	}

	private void OpenCustomImageFileDialog()
	{
	}

	private void DetachCustomImageFileBrowserHandlers()
	{
	}

	private void HandleCustomImageSelected(bool selected, string filePath, string[] files)
	{
	}

	private void ResetPendingCustomImageImport()
	{
	}

	private static bool TryValidateCustomImage(byte[] imageBytes)
	{
		return false;
	}

	public void OnEditCustomImageButtonClicked()
	{
	}

	public void OnCopyCustomImageButtonClicked()
	{
	}

	public void SelectCustomImageForEditing(string _imageId)
	{
	}

	private void OpenCustomImageInfoPanel(string _imageId)
	{
	}

	private void SyncCustomImageInfoPanel()
	{
	}

	public void OnDeleteCustomImageButtonClicked()
	{
	}

	public void OnCustomImagesCleared()
	{
	}
}
