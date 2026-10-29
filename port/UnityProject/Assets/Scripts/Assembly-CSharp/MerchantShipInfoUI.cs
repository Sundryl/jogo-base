using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class MerchantShipInfoUI : BasePanelUI, IPointerDownHandler, IEventSystemHandler
{
	private static MerchantShipInfoUI s_Instance;

	private static GameObject s_InstanceObject;

	[Header("Merchant Ship Name Controls")]
	[SerializeField]
	private TMP_InputField m_MerchantShipNameInputField;

	[SerializeField]
	private TextMeshProUGUI m_MerchantShipNameText;

	[Header("Collapsible Sections")]
	[SerializeField]
	private CollapsibleSectionUI m_BasicInfoSection;

	[SerializeField]
	private CollapsibleSectionUI m_BehaviorSection;

	[SerializeField]
	private CollapsibleSectionUI m_HistorySection;

	private MerchantShipSnapshot m_CurrentSnapshot;

	private bool m_HasSnapshot;

	private LocalizationToggleButton m_FollowToggleButton;

	private LocalizationToggleButton m_DebugToggleButton;

	private readonly List<string> m_InfoKeysBuffer;

	private readonly List<string> m_InfoValuesBuffer;

	private readonly List<UnityAction> m_InfoClickActionsBuffer;

	private float m_UpdateInterval;

	private float m_LastUpdateTime;

	private const bool c_ShowDebugToggleInCurrentBuild = false;

	public static MerchantShipInfoUI Instance => null;

	public int CurrentHomePortProvinceId { get; private set; }

	public static void HideIfExists()
	{
	}

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	public void Display(int _homePortProvinceId)
	{
	}

	protected override void OnPanelHide()
	{
	}

	private void FixedUpdate()
	{
	}

	private void InitializeMerchantShipNameField()
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

	private void RefreshSnapshot()
	{
	}

	private void RefreshMerchantShipNameDisplay()
	{
	}

	private string BuildMerchantShipDisplayName()
	{
		return null;
	}

	private void UpdateBasicInfoSection()
	{
	}

	private void UpdateBehaviorSection()
	{
	}

	private void InitializeBehaviorButtons()
	{
	}

	private void KeepOnlyBehaviorButtons(Transform _contentRoot, Transform _followToggle, Transform _debugToggle)
	{
	}

	private static Transform GetDirectChildUnder(Transform _target, Transform _root)
	{
		return null;
	}

	private void InitializeFollowToggleButton(Transform _followToggleTransform)
	{
	}

	private void InitializeDebugToggleButton(Transform _debugToggleTransform)
	{
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

	private int GetOwnerStateId()
	{
		return 0;
	}

	private int GetTargetPortProvinceId()
	{
		return 0;
	}

	private int GetTradePartnerStateId(int _targetPortProvinceId)
	{
		return 0;
	}

	private static Province GetProvinceSafe(int _provinceId)
	{
		return null;
	}

	private static string GetProvinceDisplayName(int _provinceId)
	{
		return null;
	}

	private static string GetStateDisplayName(int _stateId)
	{
		return null;
	}

	private static void TryOpenProvince(int _provinceId)
	{
	}

	private string GetTargetPortSummary(int _targetPortProvinceId)
	{
		return null;
	}

	private int GetMissionProvinceId(int _targetPortProvinceId)
	{
		return 0;
	}

	private string BuildMissionSummary(int _targetPortProvinceId)
	{
		return null;
	}

	private static string BuildTradeType(int _ownerStateId, int _partnerStateId)
	{
		return null;
	}

	private static string BuildCargoSummary(Province _homePortProvince)
	{
		return null;
	}

	private static string BuildCargoValueSummary(Province _homePortProvince)
	{
		return null;
	}

	private string BuildTransportStatus(int _targetPortProvinceId)
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
