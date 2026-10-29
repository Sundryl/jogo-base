using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using FantasyWorld.CharacterSystem;
using Michsky.MUIP;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

internal class StateInfoUI : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CRefreshLayout_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RectTransform rectTransform;

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
		public _003CRefreshLayout_003Ed__78(int _003C_003E1__state)
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
	private sealed class _003CSmoothFocusCamera_003Ed__193 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Camera camera;

		public StateInfoUI _003C_003E4__this;

		public Vector3 targetPosition;

		private Vector3 _003CstartPosition_003E5__2;

		private float _003Celapsed_003E5__3;

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
		public _003CSmoothFocusCamera_003Ed__193(int _003C_003E1__state)
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
	private sealed class _003CRefreshAllSectionsLayout_003Ed__197 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StateInfoUI _003C_003E4__this;

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
		public _003CRefreshAllSectionsLayout_003Ed__197(int _003C_003E1__state)
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
	private sealed class _003CDelayedRefreshLayoutCoroutine_003Ed__222 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int count;

		public RectTransform rectTransform;

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
		public _003CDelayedRefreshLayoutCoroutine_003Ed__222(int _003C_003E1__state)
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

	private const string c_LeaderCandidateSelectBackItemKey = "__LeaderCandidateSelectBack__";

	private const int c_ManualLeaderSelectionMinAge = 12;

	private static readonly Color s_MaleLeaderCandidateButtonColor;

	private static readonly Color s_FemaleLeaderCandidateButtonColor;

	public TMP_InputField stateNameInputField;

	public Image colorPickerImage;

	public SwitchManager cameraFollowToggle;

	public SwitchManager autoDiplomacyToggle;

	public TMP_InputField armyPlaceCountInputField;

	public GameObject WarPanelPrefab;

	private List<SinglePanel> WarPanels;

	private List<SinglePanel> HistoryPanels;

	public GameObject HistoryPanelContainer;

	[HideInInspector]
	public SinglePanel HistoryPanel;

	[SerializeField]
	[Header("History Pagination")]
	private PaginationComponent m_AllHistoryPagination;

	private List<SinglePanel> m_AllHistoryPanels;

	private const int c_HistoryItemsPerPage = 6;

	private List<(int year, HistoryEvent historyEvent)> m_CachedAllHistoryEvents;

	private int m_TotalHistoryEvents;

	[Header("Leader History Pagination")]
	[SerializeField]
	private PaginationComponent m_LeaderHistoryPagination;

	private List<SinglePanel> m_LeaderHistoryPanels;

	private const int c_LeaderItemsPerPage = 5;

	private List<LeaderHistoryRecord> m_CachedLeaderHistoryRecords;

	private int m_TotalLeaderRecords;

	public GameObject DropDownPrefab;

	private List<SinglePanel> DiplomacyPanels;

	public GameObject DiplomacyPanelContainer;

	private List<SinglePanel> FamilyPanels;

	public GameObject WarPanelContainer;

	public GameObject TraitPanelContainer;

	public Image ClickGenTips;

	public Image TryRebelTips;

	public GameObject TraitButtonPrefab;

	public Image PlaceArmyTips;

	public Button PlaceArmyButton;

	public Button MakeVassalButton;

	public Button StartWarButton;

	public Button StopWarButton;

	public Button AnnexButton;

	public Button StartAllianceButton;

	public Button ClickToExpandButton;

	public Button AutoDiplomacyButton;

	public Button RTSModeButton;

	public Button FamilyDistributionButton;

	public SwitchManager FamilyDistributionToggle;

	public CollapsibleSectionUI BasicInfoSection;

	public CollapsibleSectionUI ResourceSection;

	public CollapsibleSectionUI AffinitySection;

	public CollapsibleSectionUI WarSection;

	public CollapsibleSectionUI DiplomacySection;

	public CollapsibleSectionUI HistorySection;

	public CollapsibleSectionUI MainHistorySection;

	public CollapsibleSectionUI TraitSection;

	public CollapsibleSectionUI FamilySection;

	public CollapsibleSectionUI LeaderHistorySection;

	private GameObject m_PoliticalSystemDropdown;

	private GameObject m_ReligionDropdown;

	private GameObject m_EthnicAttributeDropdown;

	private GameObject m_CultureDropdown;

	private bool m_DropdownsInitialized;

	[Header("特性编辑")]
	[SerializeField]
	private GameObject m_TraitDropdown;

	private Dictionary<string, TraitButton> traitButtons;

	private Dictionary<int, string> religionDropdownMapping;

	private Dictionary<int, string> cultureDropdownMapping;

	public TranslationUIPanel m_TranslationUIPanel;

	private Button m_CustomNamingActionButton;

	private LocalizationTmpButton m_CustomNamingActionLocalization;

	private Button m_MilitaryProfileActionButton;

	private LocalizationTmpButton m_MilitaryProfileActionLocalization;

	private Button m_OfficialTitleActionButton;

	private LocalizationTmpButton m_OfficialTitleActionLocalization;

	private Button m_GovernmentOfficeActionButton;

	private LocalizationTmpButton m_GovernmentOfficeActionLocalization;

	private Coroutine m_CameraFocusCoroutine;

	private const float c_CameraFocusDuration = 0.4f;

	private readonly StateRelationsHighlighter m_StateRelationsHighlighter;

	private List<WarClaimAnimationData> m_ShownWarClaims;

	private static StateInfoUI _instance;

	public State currentState;

	private bool isInitTraitPanel;

	private bool m_WasBasicInfoSectionExpanded;

	private static readonly Color s_LeaderActionButtonColor;

	private Dictionary<string, int> corruptionDestinyLevel;

	private float updateInterval;

	private float lastUpdateTime;

	public static StateInfoUI Instance => null;

	public void RefreshLocalization()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshLayout_003Ed__78))]
	private IEnumerator RefreshLayout(RectTransform rectTransform)
	{
		return null;
	}

	private void Awake()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void BringToFront()
	{
	}

	private void InitTraitPanel()
	{
	}

	private void InitTraitPanel(State _state)
	{
	}

	public void OnSelectLeaderButtonClicked()
	{
	}

	private void ShowLeaderFamilySelection(State _state)
	{
	}

	private void ShowLeaderCandidateSelection(State _state, Family _selectedFamily)
	{
	}

	private List<Character> GetEligibleLeaderCandidatesFromFamily(State _state, Family _family)
	{
		return null;
	}

	private bool IsEligibleForManualLeaderSelection(State _state, Character _candidate)
	{
		return false;
	}

	private void ConfirmAndAppointLeader(State _state, Family _family, Character _candidate)
	{
	}

	private void AppointLeaderInternal(State _state, Character _candidate)
	{
	}

	private string BuildLeaderCandidateTooltip(State _state, Family _family, Character _candidate)
	{
		return null;
	}

	private void EnsureSelectContainerPanelVisible()
	{
	}

	private void OnTraitButtonStateChanged(string _traitKey, bool _isActive)
	{
	}

	private void Start()
	{
	}

	private void RegisterSectionEventHandlers()
	{
	}

	private void OnBasicInfoSectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnResourceSectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnAffinitySectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnWarSectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnDiplomacySectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnHistorySectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnTraitSectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnFamilySectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnMainHistorySectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnLeaderHistorySectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void Update()
	{
	}

	public void InitializeDropdowns(bool isForceReInit = false)
	{
	}

	private void EnsureTranslationPanel()
	{
	}

	private Transform FindDeepChildByName(Transform parent, string name)
	{
		return null;
	}

	private void EnsureCustomNamingActionButton()
	{
	}

	private void EnsureMilitaryProfileActionButton()
	{
	}

	private void EnsureGovernmentOfficeActionButton()
	{
	}

	private void EnsureOfficialTitleActionButton()
	{
	}

	private static void ApplyLeaderActionButtonColor(Button _button)
	{
	}

	private void RefreshHeaderActionButtonTexts()
	{
	}

	private string GetMilitaryProfileActionButtonText()
	{
		return null;
	}

	private string GetGovernmentOfficeActionButtonText()
	{
		return null;
	}

	private string GetOfficialTitleActionButtonText()
	{
		return null;
	}

	private void SetButtonPreferredWidth(Button button, float width)
	{
	}

	private void OnCustomNamingActionButtonClicked()
	{
	}

	private void OnMilitaryProfileActionButtonClicked()
	{
	}

	private void OnGovernmentOfficeActionButtonClicked()
	{
	}

	private void OnOfficialTitleActionButtonClicked()
	{
	}

	private void CloseCustomNamingPanel()
	{
	}

	private void ApplyButtonText(Button button, LocalizationTmpButton localizationButton, string text)
	{
	}

	private void InitTraitDropdown()
	{
	}

	private void UpdateTraitDropdown(State _state)
	{
	}

	private void UpdateDropdownValues(State _state)
	{
	}

	private void OnPoliticalSystemDropdownValueChanged(int value)
	{
	}

	private void OnReligionDropdownValueChanged(int value)
	{
	}

	private void OnEthnicAttributeDropdownValueChanged(int value)
	{
	}

	private void OnCultureDropdownValueChanged(int value)
	{
	}

	public void OnClickGenButtonHover()
	{
	}

	public void OnClickGenButtonLeave()
	{
	}

	public void OnPlayArmyButtonHover()
	{
	}

	public void OnPlaceArmyButtonLeave()
	{
	}

	public void OnTryRebelButtonHover()
	{
	}

	public void OnTryRebelButtonLeave()
	{
	}

	public void InitStateInfo(int stateID)
	{
	}

	public void OnEnableAllTraitsButtonClicked()
	{
	}

	public void OnDisableAllTraitsButtonClicked()
	{
	}

	public void SetClickToGen()
	{
	}

	public void UpdateStateName(string name)
	{
	}

	public void UpdateStateColor(Color color)
	{
	}

	public void OnRTSModeButtonClicked()
	{
	}

	private void UpdateRTSModeButton()
	{
	}

	private void UpdateFamilyDistributionToggleState()
	{
	}

	private void UpdateFamilyDistributionToggleState(GameObject _buttonOverride)
	{
	}

	public void OnFamilyDistributionToggle(bool isOn)
	{
	}

	public void OnFamilyDistributionButtonClick()
	{
	}

	private void RefreshFamilyDistributionView()
	{
	}

	public void SetCameraFollow(bool isFollow)
	{
	}

	public void RandomRebel()
	{
	}

	public void Disintegrate()
	{
	}

	public void TryStartWar()
	{
	}

	public void TryAnnexState()
	{
	}

	public void TryStartAlliance()
	{
	}

	public void ForceLeaveAlliance()
	{
	}

	public void ForceVassalRebellion()
	{
	}

	public void TryStopWar()
	{
	}

	public void OnStateInfoPanelButtonClose()
	{
	}

	private void RefreshWarClaimMarkers(bool force = false)
	{
	}

	private bool AreClaimsUnchanged(List<WarClaimAnimationData> claims)
	{
		return false;
	}

	private void ClearWarClaimMarkers()
	{
	}

	public void OnReduceCorruptionButtonClicked()
	{
	}

	public void OnIncreaseCorruptionButtonClicked()
	{
	}

	public void OnTriggerCivilWarButtonClicked()
	{
	}

	public void OnTriggerFamilyRebellionButtonClicked()
	{
	}

	public void OnShowRebellionInfoButtonClicked()
	{
	}

	public void RegenerateFamilies()
	{
	}

	public string ReduceCorruption(int stateId)
	{
		return null;
	}

	public void UpdateLeaderHistorySection(State _state, bool _forceRefresh = false)
	{
	}

	private void BuildLeaderHistoryIndex(State _state)
	{
	}

	private void OnLeaderHistoryPageChanged(int page, int startIndex, int endIndex)
	{
	}

	private void AdjustLeaderHistoryPanelsCount(int requiredCount)
	{
	}

	private void ClearLeaderHistoryPanels()
	{
	}

	private void CreateLeaderHistoryPanel(string content)
	{
	}

	private void CreateSingleLeaderHistoryPanel(string content)
	{
	}

	private string GetLeaderTitle(State state, Character leader)
	{
		return null;
	}

	private void OnCharacterClicked(int characterId)
	{
	}

	private void OnProvinceClicked(int provinceId)
	{
	}

	private void FocusCameraOnProvince(int provinceId)
	{
	}

	[IteratorStateMachine(typeof(_003CSmoothFocusCamera_003Ed__193))]
	private IEnumerator SmoothFocusCamera(Camera camera, Vector3 targetPosition)
	{
		return null;
	}

	public string GetCorruptionLevelKey(float corruption)
	{
		return null;
	}

	private void FixedUpdate()
	{
	}

	public void UpdateAllSections(State _state, bool isForceRefresh = false)
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshAllSectionsLayout_003Ed__197))]
	private IEnumerator RefreshAllSectionsLayout()
	{
		return null;
	}

	public void UpdateBasicInfoSection(State _state)
	{
	}

	public void UpdateResourceSection(State _state)
	{
	}

	public void UpdateWarSection(State _state)
	{
	}

	private string BuildOldWarInfo(War war, State _state)
	{
		return null;
	}

	private string BuildV2WarInfo(WarV2 war, State _state)
	{
		return null;
	}

	private void AppendWarCommanderLine(StringBuilder _warInfo, State _state, int _warId, GovernmentOfficeWarSystemKind _warSystemKind)
	{
	}

	private string ResolveStateNameV2(int stateId)
	{
		return null;
	}

	private int GoalScopeSizeV2(WarGoalInstanceV2 goal)
	{
		return 0;
	}

	private float CalculateTotalPanelHeight(List<SinglePanel> panels)
	{
		return 0f;
	}

	private bool ShouldRefreshLayout(List<SinglePanel> panels)
	{
		return false;
	}

	private void AdjustWarPanelsCount(int requiredCount)
	{
	}

	public void UpdateDiplomacySection(State _state)
	{
	}

	public void UpdateFamilySection(State _state, bool isForceRefresh = false)
	{
	}

	private void OnFamilyPanelClicked(int familyId)
	{
	}

	private void AdjustFamilyPanelsCount(int requiredCount)
	{
	}

	private void AdjustDiplomacyPanelsCount(int requiredCount)
	{
	}

	public void UpdateHistorySection(State _state)
	{
	}

	private HashSet<HistoryEventType> GetStateHistoryFilterEventTypes()
	{
		return null;
	}

	public void UpdateMainHistorySection(State _state)
	{
	}

	private void BuildAllHistoryIndex(State _state, double historyTime, HashSet<HistoryEventType> allowedEventTypes)
	{
	}

	private void OnAllHistoryPageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private string FormatHistoryEvent(HistoryEvent historyEvent, int year)
	{
		return null;
	}

	private void DisplayAllHistoryPage(List<string> pageTexts)
	{
	}

	private void DelayedRefreshLayout(RectTransform rectTransform, int count = 2)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedRefreshLayoutCoroutine_003Ed__222))]
	private IEnumerator DelayedRefreshLayoutCoroutine(RectTransform rectTransform, int count = 2)
	{
		return null;
	}

	private void AdjustAllHistoryPanelsCount(int requiredCount)
	{
	}

	private void ClearAllHistoryPanels()
	{
	}

	private void CreateSingleAllHistoryPanel(string text)
	{
	}

	private void AdjustHistoryPanelsCount(int requiredCount)
	{
	}

	public void UpdateTraitSection(State _state, bool isForceUpdate = false)
	{
	}

	public void RefreshLayout()
	{
	}

	public string GetNameInfo(State currentState)
	{
		return null;
	}

	public string GetStateAgeInfo(State currentState)
	{
		return null;
	}

	public string GetCapitalInfo(State currentState)
	{
		return null;
	}

	public string GetReligionInfo(State currentState)
	{
		return null;
	}

	public string GetPoplutionInfo(State currentState)
	{
		return null;
	}

	public string GetCurrentPopulationInfo(State currentState)
	{
		return null;
	}

	public string GetMaxPopulationInfo(State currentState)
	{
		return null;
	}

	public string GetCorruptionInfo(State currentState)
	{
		return null;
	}

	public string GetTreasuryInfo(State currentState)
	{
		return null;
	}

	public string GetPoliticalSystemInfo(State currentState)
	{
		return null;
	}

	public string GetEthnicAttributeInfo(State currentState, bool isNeedDefaultFont = true)
	{
		return null;
	}

	public string GetArmyCountInfo(State currentState)
	{
		return null;
	}

	public string GetWarshipCountInfo(State currentState)
	{
		return null;
	}

	public string GetProvinceCountInfo(State currentState)
	{
		return null;
	}

	public string GetDistrictCountInfo(State currentState)
	{
		return null;
	}

	private int GetWarshipCount(State currentState)
	{
		return 0;
	}

	private TooltipContentProvider CreateArmyCountTooltipProvider(State state)
	{
		return null;
	}

	private string BuildArmyUnitBreakdownTooltip(State state)
	{
		return null;
	}

	private string GetUnitDisplayName(MilitaryProfile profile, string unitKey)
	{
		return null;
	}

	public string GetFamilyInfo(State currentState)
	{
		return null;
	}

	private string GetCharacterRoleInfo(Character character)
	{
		return null;
	}

	public string GetEnemyStateListInfo(State currentState)
	{
		return null;
	}

	public string GetAllyStatesInfo(State currentState)
	{
		return null;
	}

	public string GetVassalsOrOverlordInfo(State currentState)
	{
		return null;
	}

	public void TryMakeVassal()
	{
	}

	public void PlaceArmy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnAutoDiplomacyToggle(bool isOn)
	{
	}

	public void OnAutoDiplomacyButtonClick()
	{
	}

	private void OnTraitDropdownValueChanged(int value)
	{
	}

	public void OnTranslateStateNameButtonClick()
	{
	}

	public void OnTranslationPanelClosed(string _key, Dictionary<string, string> _translations)
	{
	}

	public void ShowCurrentStateHistoryTimeline()
	{
	}

	private string GetWarTypeLocalizationKey(WarType warType)
	{
		return null;
	}
}
