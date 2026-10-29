using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class SelectUI : BasePanelUI
{
	public sealed class OptionItem
	{
		public string Key;

		public string Display;

		public bool IsDisplayLocalizationKey;

		public OptionItem(string _key, string _display, bool _isDisplayLocalizationKey = false)
		{
		}
	}

	public sealed class DropdownRequest
	{
		public string Id;

		public string LabelKey;

		public string PlaceholderKey;

		public string TooltipKey;

		public bool IsRequired;

		public string DefaultKey;

		public bool SortByDisplayText;

		public Func<List<OptionItem>> OptionsProvider;

		public DropdownRequest(string _id, string _labelKey, string _placeholderKey, Func<List<OptionItem>> _optionsProvider, string _tooltipKey = "", string _defaultKey = "", bool _isRequired = true, bool _sortByDisplayText = true)
		{
		}
	}

	private sealed class DropdownRuntime
	{
		public GameObject DropdownGO;

		public DropdownInfo DropdownInfo;

		public DropdownRequest Request;

		public string SelectedKey;

		public readonly Dictionary<int, string> IndexToKey;
	}

	private static SelectUI s_Instance;

	[Header("References（可留空，运行时自动查找）")]
	[SerializeField]
	private Transform m_ContentContainer;

	[SerializeField]
	private Button m_ActionButtonPrefab;

	private const string c_ActionButtonPrefabResourcesPath = "Prefabs/WarningPanelButton";

	private const string c_ActionButtonPrefabAssetPath = "Assets/Prefabs/WarningPanelButton.prefab";

	private static readonly Color s_CancelButtonColor;

	private static readonly Color s_SecondaryActionButtonColor;

	private static readonly Color s_TertiaryActionButtonColor;

	private readonly List<DropdownRuntime> m_RuntimeDropdowns;

	private Button m_ConfirmButton;

	private Button m_CancelButton;

	private Button m_SecondaryActionButton;

	private Button m_TertiaryActionButton;

	private LocalizationTmpButton m_ConfirmLocButton;

	private LocalizationTmpButton m_CancelLocButton;

	private LocalizationTmpButton m_SecondaryActionLocButton;

	private LocalizationTmpButton m_TertiaryActionLocButton;

	private TextMeshProUGUI m_ConfirmButtonText;

	private TextMeshProUGUI m_CancelButtonText;

	private TextMeshProUGUI m_SecondaryActionButtonText;

	private TextMeshProUGUI m_TertiaryActionButtonText;

	private List<DropdownRequest> m_LastDropdownRequests;

	private Action<Dictionary<string, string>> m_OnConfirm;

	private Action m_OnCancel;

	private bool m_IsCustomContentMode;

	private Action m_OnCustomConfirm;

	private Func<bool> m_OnCustomConfirmBeforeClose;

	private Action m_OnCustomCancel;

	private Action m_OnCustomSecondaryAction;

	private Action m_OnCustomTertiaryAction;

	private string m_CustomSecondaryButtonKey;

	private string m_CustomTertiaryButtonKey;

	private bool m_IsHidingByAction;

	public static SelectUI Instance => null;

	protected override void Awake()
	{
	}

	protected override void Update()
	{
	}

	public override void Show(Action _onComplete = null)
	{
	}

	private void CenterOnScreen()
	{
	}

	public void ShowSelector(List<DropdownRequest> _dropdownRequests, Action<Dictionary<string, string>> _onConfirm, Action _onCancel = null)
	{
	}

	public void ShowCustomContent(Action<Transform> _buildContent, Action _onConfirm = null, Action _onCancel = null, Action _onSecondaryAction = null, string _secondaryButtonKey = "Reset", Action _onTertiaryAction = null, string _tertiaryButtonKey = "Reset", Func<bool> _onConfirmBeforeClose = null)
	{
	}

	public void ShowCultureAndReligionSelector(string _defaultCultureId, string _defaultReligionId, Action<string, string> _onConfirm, Action _onCancel = null)
	{
	}

	private void ResolveReferences()
	{
	}

	private void EnsureUI()
	{
	}

	private void CreateButtons()
	{
	}

	private Color GetConfirmButtonColor()
	{
		return default;
	}

	private bool TryGetWarningWithActionButtonColors(out List<Color> _colors)
	{
		_colors = null;
		return false;
	}

	private Button CreateActionButton(Transform _parent, string _name, string _localizationKey, Color _bgColor, out LocalizationTmpButton _locButton, out TextMeshProUGUI _label)
	{
		_locButton = null;
		_label = null;
		return null;
	}

	private void DestroyExistingButtons()
	{
	}

	private void ClearDynamicChildrenExceptActionButtons()
	{
	}

	private void BringButtonsToEnd()
	{
	}

	private Button GetOrFindActionButtonPrefab()
	{
		return null;
	}

	private void RebuildDropdowns(List<DropdownRequest> _dropdownRequests)
	{
	}

	private void EnsureDropdownCount(int _requiredCount)
	{
	}

	private void BuildOneDropdown(DropdownRuntime _runtime)
	{
	}

	private string GetDisplayText(OptionItem _item)
	{
		return null;
	}

	private int GetDropdownIndexByValue(Dictionary<int, string> _map, string _value)
	{
		return 0;
	}

	private void OnAnyDropdownValueChanged(DropdownRuntime _runtime, int _index)
	{
	}

	private void UpdateConfirmInteractable()
	{
	}

	private void SetSecondaryActionButtonVisible(bool _isVisible)
	{
	}

	private void SetTertiaryActionButtonVisible(bool _isVisible)
	{
	}

	private void OnSecondaryActionClicked()
	{
	}

	private void OnTertiaryActionClicked()
	{
	}

	private void OnConfirmClicked()
	{
	}

	private void OnCancelClicked()
	{
	}

	private void ClearCallbacks()
	{
	}

	private void UpdateButtonTexts()
	{
	}

	protected override void RefreshLocalization()
	{
	}

	protected override void OnPanelHide()
	{
	}

	protected override void OnCloseButtonClicked()
	{
	}

	private List<OptionItem> BuildCultureOptions()
	{
		return null;
	}

	private List<OptionItem> BuildReligionOptions()
	{
		return null;
	}
}
