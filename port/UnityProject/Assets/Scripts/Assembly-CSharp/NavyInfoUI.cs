using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class NavyInfoUI : BasePanelUI, IPointerDownHandler, IEventSystemHandler
{
	private static NavyInfoUI s_Instance;

	private static GameObject s_InstanceObject;

	[Header("Ship Name Controls")]
	[SerializeField]
	private TMP_InputField m_NavyNameInputField;

	[SerializeField]
	private TextMeshProUGUI m_NavyNameText;

	[SerializeField]
	[Header("Collapsible Sections")]
	private CollapsibleSectionUI m_BasicInfoSection;

	[SerializeField]
	private CollapsibleSectionUI m_DebugInfoSection;

	[SerializeField]
	private CollapsibleSectionUI m_HistorySection;

	private readonly List<string> m_InfoKeysBuffer;

	private readonly List<string> m_InfoValuesBuffer;

	private readonly List<UnityAction> m_InfoClickActionsBuffer;

	private LocalizationToggleButton m_FollowToggleButton;

	private LocalizationToggleButton m_DebugToggleButton;

	private float m_UpdateInterval;

	private float m_LastUpdateTime;

	private const bool c_ShowDebugToggleInCurrentBuild = false;

	public static NavyInfoUI Instance => null;

	public Navy currentNavy { get; private set; }

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	public void Display(Navy _navy)
	{
	}

	protected override void OnPanelHide()
	{
	}

	private void FixedUpdate()
	{
	}

	private void InitializeNavyNameField()
	{
	}

	private void InitializeSections()
	{
	}

	private CollapsibleSectionUI GetOrFindSection(CollapsibleSectionUI _serializedSection, string _sectionName)
	{
		return null;
	}

	private void UpdateAllSections()
	{
	}

	private void UpdateBasicInfoSection()
	{
	}

	private void RefreshNavyNameDisplay()
	{
	}

	private void UpdateBehaviorSection()
	{
	}

	private void InitializeBehaviorButtons()
	{
	}

	private void InitializeFollowToggleButton(Transform _followToggleTransform)
	{
	}

	private void InitializeDebugToggleButton(Transform _debugToggleTransform)
	{
	}

	private void KeepOnlyBehaviorButtons(Transform _contentRoot, Transform _followToggle, Transform _debugToggle)
	{
	}

	private static Transform GetDirectChildUnder(Transform _target, Transform _root)
	{
		return null;
	}

	private void OnFollowToggleChanged(bool _isOn)
	{
	}

	private static void OnDebugToggleChanged(bool _isOn)
	{
	}

	protected override void RefreshLocalization()
	{
	}

	private void AddInfoRow(string _key, string _value, UnityAction _clickAction = null)
	{
	}

	private static void TryOpenProvince(int _provinceId)
	{
	}

	private string BuildStateSummary()
	{
		return null;
	}

	private static int GetFeatureIdSafe(int _cell)
	{
		return 0;
	}

	private static int GetProvinceIdSafe(int _cell)
	{
		return 0;
	}

	private string BuildMissionSummary()
	{
		return null;
	}

	private int GetPrimaryMissionProvinceId()
	{
		return 0;
	}

	private string BuildExpectedDestinationSummary()
	{
		return null;
	}

	private int GetExpectedDestinationProvinceId()
	{
		return 0;
	}

	private int GetBestPortAnchorCell(int _portProvinceId)
	{
		return 0;
	}

	private bool IsReclaimTarget(int _portProvinceId)
	{
		return false;
	}

	private static string GetPortDisplayName(int _portProvinceId)
	{
		return null;
	}

	private static string GetProvinceDisplayName(int _provinceId)
	{
		return null;
	}

	private static string GetLoc(string _key)
	{
		return null;
	}

	private static string GetLocFormat(string _key, params object[] _args)
	{
		return null;
	}

	private static Transform FindMainCanvasTransform()
	{
		return null;
	}
}
