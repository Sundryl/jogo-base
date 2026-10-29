using System.Collections.Generic;
using ColorPickerUtil;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AllianceInfoUI : BasePanelUI
{
	[Header("基础折叠区组件")]
	[SerializeField]
	private CollapsibleSectionUI m_BasicInfoSection;

	[SerializeField]
	private CollapsibleSectionUI m_MembersSection;

	[SerializeField]
	private CollapsibleSectionUI m_ActionsSection;

	[Header("成员列表设置")]
	[SerializeField]
	private Transform m_MemberListContainer;

	[Header("输入组件")]
	[SerializeField]
	private TMP_InputField m_AllianceNameInput;

	[Header("翻译组件")]
	[SerializeField]
	private Button m_TranslateNameButton;

	[SerializeField]
	private TranslationUIPanel m_TranslationUIPanel;

	[Header("操作组件")]
	[SerializeField]
	private Button m_DisbandAllianceButton;

	[SerializeField]
	private LocalizationToggleButton m_UnbreakableLocalizationButton;

	private Button m_UnbreakableToggleButtonComponent;

	private Button m_KickMemberButton;

	private Button m_JoinAllianceButton;

	private Alliance m_CurrentAlliance;

	private State m_HighlightSourceState;

	private readonly StateRelationsHighlighter m_StateRelationsHighlighter;

	private ColorPickingButton m_ColorPickerButton;

	private Image m_ColorPickerImage;

	private Button m_ColorPickerUnityButton;

	private readonly List<SinglePanel> m_MemberPanels;

	private static AllianceInfoUI s_Instance;

	private static GameObject s_InstanceObject;

	private const string c_PrefabPath = "UI/Base/AllianceInfoPanel";

	public static AllianceInfoUI Instance => null;

	private static void CreateRuntimeInstance()
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

	protected override void Update()
	{
	}

	public override void BringToFront()
	{
	}

	public void ShowAlliance(Alliance _alliance, State _sourceState = null)
	{
	}

	public void SetAlliance(Alliance _alliance, State _sourceState = null)
	{
	}

	private void SetHighlightSourceState(State sourceState)
	{
	}

	private void RefreshAll()
	{
	}

	protected override void OnPanelHide()
	{
	}

	private void OnColorPickerColorChanged(Color newColor)
	{
	}

	private void UpdateColorPickerDisplay()
	{
	}

	private void EnsureColorPickerSupport()
	{
	}

	private void OnColorPickerButtonClicked()
	{
	}

	private void OnColorPickerInteractionEnded(Color color)
	{
	}

	private void UpdateKickMemberButtonState()
	{
	}

	private void UpdateJoinAllianceButtonState()
	{
	}

	private void OnKickMemberButtonClicked()
	{
	}

	private void OnJoinAllianceButtonClicked()
	{
	}

	private State GetStrongestAllianceState()
	{
		return null;
	}

	private void OnAllianceMemberSelectedForKick(string stateKey)
	{
	}

	private Color GetStateButtonColor(State state)
	{
		return default;
	}

	private void CachePrefabReferences()
	{
	}

	private void UpdateBasicInfoSection(Alliance _alliance)
	{
	}

	private void UpdateAllianceName(Alliance _alliance)
	{
	}

	private void UpdateMembersSection(Alliance _alliance)
	{
	}

	private static long GetStateInternalPopulation(State _state)
	{
		return 0L;
	}

	private string GetLocalizedStateName(State _state)
	{
		return null;
	}

	private void BindAllianceNameInput()
	{
	}

	private void OnAllianceNameEdited(string _newName)
	{
	}

	public void OnTranslateAllianceNameButtonClick()
	{
	}

	private void OnAllianceTranslationPanelClosed(string _key, Dictionary<string, string> _translations)
	{
	}

	private void EnsureTranslationPanel()
	{
	}

	private Transform GetActionsRoot()
	{
		return null;
	}

	private Transform FindActionElement(params string[] _names)
	{
		return null;
	}

	private Transform FindActionElementWithComponent<T>(params string[] _names) where T : Component
	{
		return null;
	}

	private T GetComponentFromTransform<T>(Transform _source, Transform _scopeRoot) where T : Component
	{
		return null;
	}

	private void ApplyButtonLocalization(Transform _target, string _key)
	{
	}

	private void EnsureUnbreakableToggle()
	{
	}

	private void EnsureTranslateButton()
	{
	}

	private void EnsureDisbandButton()
	{
	}

	private void EnsureKickMemberButton()
	{
	}

	private void EnsureJoinAllianceButton()
	{
	}

	private Dictionary<string, string> BuildAllianceTranslations()
	{
		return null;
	}

	private void UpdateUnbreakableUI(Alliance _alliance)
	{
	}

	private void OnUnbreakableLocalizationButtonClicked()
	{
	}

	private void ApplyUnbreakableState(bool _value)
	{
	}

	private void ResetButtonOnClick(Button _button)
	{
	}

	private void OnDisbandAllianceButtonClick()
	{
	}

	private void DeactivateUnusedActionButton(string _buttonName)
	{
	}

	private void EnsureMemberPanels(Transform _container, int _count)
	{
	}
}
