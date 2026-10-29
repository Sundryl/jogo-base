using System.Collections.Generic;
using FantasyWorld.CharacterSystem;
using TMPro;
using UnityEngine;

public class FamilyPanelUI : BasePanelUI
{
	private static FamilyPanelUI s_Instance;

	[Header("Overview Section References")]
	[SerializeField]
	private TMP_InputField m_FamilyNameInputField;

	[SerializeField]
	private TextMeshProUGUI m_CultureText;

	[SerializeField]
	private TextMeshProUGUI m_StateStatusText;

	[Header("Collapsible Sections")]
	[SerializeField]
	private CollapsibleSectionUI m_OverviewSection;

	[SerializeField]
	private CollapsibleSectionUI m_MembersSection;

	[SerializeField]
	private CollapsibleSectionUI m_TerritorySection;

	[SerializeField]
	private CollapsibleSectionUI m_RelationsSection;

	[SerializeField]
	private CollapsibleSectionUI m_EventSection;

	[SerializeField]
	private CollapsibleSectionUI m_HistorySection;

	[SerializeField]
	private PaginationComponent m_HistoryPagination;

	private Family m_CurrentFamily;

	private int m_CachedFamilyId;

	private List<SinglePanel> m_TerritoryPanels;

	private List<SinglePanel> m_EventPanels;

	private List<SinglePanel> m_HistoryPanels;

	private List<SinglePanel> m_HistoryInfoPanels;

	private Dictionary<GameObject, int> m_MemberButtonMap;

	private Dictionary<GameObject, int> m_ProvinceButtonMap;

	private GameObject m_ReligionDropdown;

	private GameObject m_CultureDropdown;

	public GameObject m_ViewFamilyTreeButton;

	private bool m_DropdownsInitialized;

	private Dictionary<int, string> religionDropdownMapping;

	private Dictionary<int, string> cultureDropdownMapping;

	private float updateInterval;

	private float lastUpdateTime;

	private const int c_HistoryItemsPerPage = 5;

	private List<int> m_SortedYears;

	private Dictionary<int, int> m_YearEventCounts;

	private int m_TotalHistoryEvents;

	public static FamilyPanelUI Instance => null;

	protected override void Awake()
	{
	}

	protected override void OnPanelInitialize()
	{
	}

	public void OnColorPickerColorChanged(Color arg0)
	{
	}

	private void InitializeSections()
	{
	}

	private void RegisterSectionEventHandlers()
	{
	}

	private void OnOverviewSectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnMembersSectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnTerritorySectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnRelationsSectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnEventSectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnHistorySectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private CollapsibleSectionUI GetOrFindSection(CollapsibleSectionUI serializedSection, string sectionName)
	{
		return null;
	}

	public void SetFamily(Family family)
	{
	}

	public void Display(int familyId)
	{
	}

	private void UpdateAllSections()
	{
	}

	private void UpdateOverviewSection()
	{
	}

	private void UpdateOverviewHeader()
	{
	}

	public void InitializeOverviewDropdowns(bool forceReinitialize = false)
	{
	}

	private void UpdateDropdownValues()
	{
	}

	private void OnCultureDropdownValueChanged(int value)
	{
	}

	private void OnReligionDropdownValueChanged(int value)
	{
	}

	public void OnViewFamilyTreeClicked()
	{
	}

	private void AdjustPanelCount(List<SinglePanel> panels, int requiredCount, Transform parent)
	{
	}

	private void ClearPanels(List<SinglePanel> panels)
	{
	}

	private void UpdateMembersSection()
	{
	}

	private int GetMemberPriority(Character character)
	{
		return 0;
	}

	private string GetMemberRole(Character character)
	{
		return null;
	}

	private void UpdateTerritorySection()
	{
	}

	private void AdjustTerritoryPanelsCount(int requiredCount)
	{
	}

	private void UpdateRelationsSection()
	{
	}

	private void UpdateEventSection()
	{
	}

	private void AdjustEventPanelsCount(int requiredCount)
	{
	}

	private void UpdateHistorySection()
	{
	}

	private void BuildHistoryIndex()
	{
	}

	private void OnHistoryPageChanged(int currentPage, int startIndex, int endIndex)
	{
	}

	private List<string> GetHistoryTextsForRange(int startIndex, int endIndex)
	{
		return null;
	}

	private string FormatHistoryEvent(HistoryEvent historyEvent, int year = -1)
	{
		return null;
	}

	private List<string> GetBasicFamilyInfo()
	{
		return null;
	}

	private void DisplayHistoryPage(List<string> pageTexts)
	{
	}

	private void DisplayAllHistory()
	{
	}

	private void AdjustHistoryPanelsCount(int requiredCount)
	{
	}

	private void ClearSection(Transform content)
	{
	}

	private GameObject CreateInfoRow(Transform parent, string label, string value)
	{
		return null;
	}

	private GameObject CreateClickableInfoRow(Transform parent, string label, string value, int targetId, bool isProvince = false)
	{
		return null;
	}

	private GameObject CreateSinglePanel(Transform parent, string text)
	{
		return null;
	}

	private string GetProvinceName(int provinceId)
	{
		return null;
	}

	private void OnCharacterClicked(int characterId)
	{
	}

	private void OnProvinceClicked(int provinceId)
	{
	}

	private void OnCultureClicked(string cultureName)
	{
	}

	private void OnReligionClicked(string religionId)
	{
	}

	protected override void OnPanelShow()
	{
	}

	protected override void OnPanelHide()
	{
	}

	protected override void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	private void UpdateFamilyName(string newName)
	{
	}

	private void CleanupDropdowns()
	{
	}

	public void StartCurrentFamilyRebellion()
	{
	}
}
