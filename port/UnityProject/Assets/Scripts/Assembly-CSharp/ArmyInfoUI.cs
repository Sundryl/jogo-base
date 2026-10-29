using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ArmyInfoUI : BasePanelUI, IPointerDownHandler, IEventSystemHandler
{
	private static ArmyInfoUI s_Instance;

	private static GameObject s_InstanceObject;

	[Header("军团名称控件")]
	[SerializeField]
	private TMP_InputField m_ArmyNameInputField;

	[SerializeField]
	private TextMeshProUGUI ArmyNameText;

	[Header("军队颜色")]
	[SerializeField]
	private Image armyColor;

	[Header("Collapsible Sections")]
	[SerializeField]
	private CollapsibleSectionUI m_BasicInfoSection;

	[SerializeField]
	private CollapsibleSectionUI m_ControlSection;

	[SerializeField]
	private CollapsibleSectionUI m_HistorySection;

	[Header("旧版控件引用（将被弃用）")]
	public TextMeshProUGUI HistoryText;

	public TextMeshProUGUI CurrentStateText;

	public TextMeshProUGUI HomeLandText;

	public TextMeshProUGUI CurrentProvince;

	private LocalizationToggleButton m_FollowToggleButton;

	private LocalizationToggleButton m_DebugToggleButton;

	private List<SinglePanel> m_HistoryPanels;

	private readonly List<Army.BasicInfoRow> m_BasicInfoRowsBuffer;

	private float m_UpdateInterval;

	private float m_LastUpdateTime;

	public static ArmyInfoUI Instance => null;

	public Army currentArmy { get; private set; }

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	public new void OnPointerDown(PointerEventData eventData)
	{
	}

	public new void BringToFront()
	{
	}

	private void InitializeArmyNameField()
	{
	}

	private void InitializeSections()
	{
	}

	private void RegisterSectionEventHandlers()
	{
	}

	private void OnBasicInfoSectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnControlSectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private void OnHistorySectionExpanded(CollapsibleSectionUI _section)
	{
	}

	private CollapsibleSectionUI GetOrFindSection(CollapsibleSectionUI serializedSection, string sectionName)
	{
		return null;
	}

	public void InitArmyInfo(Army army)
	{
	}

	public void Display(Army army)
	{
	}

	public void OnArmyInfoPanelClosed()
	{
	}

	private void UpdateAllSections()
	{
	}

	private void UpdateLegacyUI()
	{
	}

	private void UpdateBasicInfoSection()
	{
	}

	private void UpdateControlSection()
	{
	}

	private void InitializeControlButtons()
	{
	}

	private void UpdateHistorySection()
	{
	}

	private string GetLocalizedWarName(Campaign campaign)
	{
		return null;
	}

	private void RefreshArmyNameDisplay()
	{
	}

	private void AdjustHistoryPanelsCount(int requiredCount)
	{
	}

	private void OnFollowToggleChanged(bool isOn)
	{
	}

	private void OnDebugToggleChanged(bool isOn)
	{
	}

	public void OnFollowArmyToggleValueChanged(bool isOn)
	{
	}

	public void OnDebugToggleValueChanged(bool isOn)
	{
	}

	private void UpdateArmyName(string newName)
	{
	}

	private int GetCurrentProvinceId()
	{
		return 0;
	}

	private void OnProvinceClicked(int provinceId)
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

	private void FixedUpdate()
	{
	}
}
