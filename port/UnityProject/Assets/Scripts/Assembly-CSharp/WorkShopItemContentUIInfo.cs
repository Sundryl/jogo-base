using System;
using System.Collections.Generic;
using MPUIKIT;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WorkShopItemContentUIInfo : BasePanelUI
{
	private enum WorkshopUploadType
	{
		Map = 0,
		CultureSet = 1,
		Religion = 2,
		Military = 3
	}

	private sealed class LocalizedBinding
	{
		public TextMeshProUGUI Text;

		public string Key;
	}

	private sealed class SourceView
	{
		public Button Button;

		public Image Background;

		public TextMeshProUGUI Title;

		public TextMeshProUGUI Subtitle;
	}

	private sealed class SourceDescriptor
	{
		public WorkshopUploadType Type;

		public string Id;

		public string DisplayName;

		public string Subtitle;

		public string Path;

		public string TitleSeed;
	}

	public const string RuntimePanelObjectName = "WorkshopUploadRuntimePanel";

	public TMP_InputField itemNameInputField;

	public TMP_InputField itemIDInputField;

	public TMP_InputField itemDescriptionInputField;

	public TMP_InputField itemImagePathField;

	private static WorkShopItemContentUIInfo s_Instance;

	private static readonly Vector2 s_DefaultPanelSize;

	private static readonly Color s_PanelColor;

	private static readonly Color s_PanelOutlineColor;

	private static readonly Color s_BodyColor;

	private static readonly Color s_CardColor;

	private static readonly Color s_SubtleCardColor;

	private static readonly Color s_ButtonColor;

	private static readonly Color s_ButtonSelectedBaseColor;

	private static readonly Color s_ButtonDisabledColor;

	private static readonly Color s_TextColor;

	private static readonly Color s_MutedTextColor;

	private static readonly Color s_HintTextColor;

	private static readonly Color s_InputColor;

	private static readonly Color s_InputOutlineColor;

	private static readonly Color s_InputTextColor;

	private static readonly Color s_NormalBannerColor;

	private static readonly Color s_NormalBannerOutlineColor;

	private static readonly Color s_BlockedBannerColor;

	private static readonly Color s_BlockedBannerOutlineColor;

	private static readonly Color s_ImportActionColor;

	private static readonly Color s_RemoveActionColor;

	private static readonly Color s_CallToActionColor;

	private const string c_ActionButtonPrefabResourcesPath = "Prefabs/WarningPanelButton";

	private const string c_ActionButtonPrefabAssetPath = "Assets/Prefabs/WarningPanelButton.prefab";

	private const float c_ButtonHeight = 36f;

	private const float c_ToolbarButtonWidth = 118f;

	private const float c_ToolbarButtonHeight = 32f;

	private const float c_TypeDropdownWidth = 244f;

	private const float c_TypeDropdownHeight = 32f;

	private const float c_TypeDropdownFontSize = 16f;

	private const float c_FontScaleMultiplier = 1.1f;

	private const float c_MinPanelHeight = 560f;

	private const float c_FieldLabelWidth = 172f;

	private const float c_PanelCornerRadius = 8f;

	private const float c_BodyCornerRadius = 8f;

	private const float c_CardCornerRadius = 6f;

	private const float c_PanelShadowSize = 32f;

	private const float c_PanelShadowSpread = 0f;

	private const float c_PanelShadowOffsetAngle = 90f;

	private const float c_PanelShadowOffsetDistance = 9.5f;

	private readonly Dictionary<string, SourceView> m_SourceButtons;

	private readonly List<LocalizedBinding> m_LocalizedBindings;

	private readonly List<TextMeshProUGUI> m_AllTexts;

	private readonly List<TMP_InputField> m_AllInputs;

	private Button m_ActionButtonPrefab;

	private bool m_IsInitialized;

	private WorkshopUploadType m_SelectedType;

	private List<SourceDescriptor> m_CurrentSources;

	private SourceDescriptor m_SelectedSource;

	private RectTransform m_SourceListContent;

	private Image m_BannerBackground;

	private Image m_TypeCardBackground;

	private Image m_SourceCardBackground;

	private Image m_DetailCardBackground;

	private TextMeshProUGUI m_BannerText;

	private TextMeshProUGUI m_SourceHintText;

	private TextMeshProUGUI m_FormHintText;

	private DropdownInfo m_TypeDropdownInfo;

	private TMP_Dropdown m_TypeDropdown;

	private Button m_RefreshButton;

	private TextMeshProUGUI m_RefreshButtonText;

	private Button m_BrowseButton;

	private TextMeshProUGUI m_BrowseButtonText;

	private Button m_OpenWorkshopButton;

	private TextMeshProUGUI m_OpenWorkshopButtonText;

	private Button m_UploadButton;

	private TextMeshProUGUI m_UploadButtonText;

	public static WorkShopItemContentUIInfo Instance => null;

	public CanvasGroup PanelCanvasGroup => null;

	public static WorkShopItemContentUIInfo TryGetExistingInstance()
	{
		return null;
	}

	public static WorkShopItemContentUIInfo EnsureInstance(Transform parent = null)
	{
		return null;
	}

	private static void EnsureRuntimeParent(WorkShopItemContentUIInfo panel, Transform parent)
	{
	}

	protected override void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnPanelInitialize()
	{
	}

	protected override void OnPanelShow()
	{
	}

	protected override void Update()
	{
	}

	protected override void RefreshLocalization()
	{
	}

	public void TogglePanel()
	{
	}

	public void Open()
	{
	}

	public void OpenForType(string itemType)
	{
	}

	public void Init(string itemString, string itemType)
	{
	}

	public void UpLoadWorkshopItem()
	{
	}

	public void OnWorkshopItemContentUICloseButtonClicked()
	{
	}

	public override void Hide(Action _onComplete = null)
	{
	}

	public override void BringToFront()
	{
	}

	public void OnSelectPreviewImageButtonClicked()
	{
	}

	private void HandlePreviewImageSelected(bool selected, string filePath, string[] files)
	{
	}

	private void DetachFileBrowserHandlers()
	{
	}

	private void EnsurePanelStructure()
	{
	}

	private void BuildPanelUI()
	{
	}

	private void RefreshPanelSize()
	{
	}

	private void RefreshPanelData(string preferredSourceId, bool preserveFormValues)
	{
	}

	private SourceDescriptor ResolveSelectedSource(string preferredSourceId)
	{
		return null;
	}

	private List<SourceDescriptor> BuildSources(WorkshopUploadType type)
	{
		return null;
	}

	private List<SourceDescriptor> BuildMapSources()
	{
		return null;
	}

	private List<SourceDescriptor> BuildCultureSources()
	{
		return null;
	}

	private List<SourceDescriptor> BuildReligionSources()
	{
		return null;
	}

	private List<SourceDescriptor> BuildMilitarySources()
	{
		return null;
	}

	private void RebuildSourceButtons()
	{
	}

	private SourceView CreateSourceButton(Transform parent, SourceDescriptor source)
	{
		return null;
	}

	private void OnSourceSelected(SourceDescriptor source)
	{
	}

	private void PopulateFormFromSelection()
	{
	}

	private void RefreshBanner()
	{
	}

	private void RefreshSourceHint()
	{
	}

	private void RefreshFormHint()
	{
	}

	private void RefreshTypeDropdown()
	{
	}

	private void RefreshSourceButtonStyles()
	{
	}

	private void RefreshSectionCardStyles()
	{
	}

	private void RefreshActionStates()
	{
	}

	public void RefreshUploadState()
	{
	}

	private void OnTypeDropdownValueChanged(int value)
	{
	}

	private GameObject CreateCard(string name, Transform parent, bool subtle)
	{
		return null;
	}

	private void ApplyCardColor(Image image, Color fill, Color outline)
	{
	}

	private GameObject CreateRow(string name, Transform parent, float spacing)
	{
		return null;
	}

	private GameObject CreateColumn(string name, Transform parent, float spacing)
	{
		return null;
	}

	private GameObject CreateFieldRow(Transform parent, string labelKey)
	{
		return null;
	}

	private void CreateInputRow(Transform parent, string labelKey, string inputObjectName, out TMP_InputField inputField, string placeholderKey, bool numeric)
	{
		inputField = null;
	}

	private void CreateInputRowWithHint(Transform parent, string labelKey, string inputObjectName, out TMP_InputField inputField, string placeholderKey, bool numeric, string hintKey)
	{
		inputField = null;
	}

	private void CreateMultilineInputRow(Transform parent, string labelKey, string inputObjectName, out TMP_InputField inputField, string placeholderKey, float height)
	{
		inputField = null;
	}

	private TMP_InputField CreateInput(string name, Transform parent, float height, string placeholderKey, bool numeric, bool multiLine)
	{
		return null;
	}

	private TextMeshProUGUI CreateInputText(string name, Transform parent, bool placeholder, bool multiLine)
	{
		return null;
	}

	private static float ScaleFontSize(float fontSize)
	{
		return 0f;
	}

	private GameObject CreateScrollView(Transform parent, out RectTransform content)
	{
		content = null;
		return null;
	}

	private TextMeshProUGUI CreateText(string name, Transform parent, float fontSize, FontStyles fontStyle, Color color, TextAlignmentOptions alignment)
	{
		return null;
	}

	private void ConfigureWrappingTextBlock(TextMeshProUGUI text, float minHeight = 0f)
	{
	}

	private DropdownInfo CreateDropdown(string objectName, Transform parent, string labelText, float width, float dropdownHeight, float fontSize, bool showLabel)
	{
		return null;
	}

	private Button CreateButton(string name, Transform parent, out TextMeshProUGUI label, string text, float width, float height)
	{
		label = null;
		return null;
	}

	private static Color GetSelectedButtonColor(Color accentColor)
	{
		return default;
	}

	private static Color GetSourceButtonBaseColor(Color accentColor)
	{
		return default;
	}

	private static Color GetSourceButtonOutlineColor(Color accentColor, bool isSelected)
	{
		return default;
	}

	private void ApplyActionButton(Button button, TextMeshProUGUI label, bool interactable, Color activeColor, Color disabledColor, Color activeTextColor, Color disabledTextColor)
	{
	}

	private void SetInputState(TMP_InputField input, bool interactable)
	{
	}

	private LayoutElement GetOrAddLayout(GameObject target)
	{
		return null;
	}

	private void RegisterLocalized(TextMeshProUGUI text, string key)
	{
	}

	private void RefreshLocalizedBindings()
	{
	}

	private void ClearChildren()
	{
	}

	private static void ConfigureRoundedRectangle(MPImage image, Color fill, float radius, float outlineWidth, Color outline, bool raycast)
	{
	}

	private void ConfigurePanelShadow()
	{
	}

	private Button GetActionButtonPrefab()
	{
		return null;
	}

	private static WorkshopUploadType ParseUploadType(string itemType)
	{
		return WorkshopUploadType.Map;
	}

	private static string GetUploadTypeKey(WorkshopUploadType type)
	{
		return null;
	}

	private string GetUploadTypeOptionLabel(WorkshopUploadType type)
	{
		return null;
	}

	private string GetEmptyText(WorkshopUploadType type)
	{
		return null;
	}

	private static Color GetAccentColor(WorkshopUploadType type)
	{
		return default;
	}

	private static string T(string key)
	{
		return null;
	}

	private static string TF(string key, params object[] args)
	{
		return null;
	}

	private void ShowMessage(string message)
	{
	}

	private void HideImmediate()
	{
	}

	protected override void OnCloseButtonClicked()
	{
	}
}
