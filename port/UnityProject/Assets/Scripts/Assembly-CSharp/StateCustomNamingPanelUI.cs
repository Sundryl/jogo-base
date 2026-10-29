using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StateCustomNamingPanelUI : BasePanelUI
{
	private const string c_CustomFormatTranslationKeyPrefix = "state_custom_format_";

	private const string c_StateNameTranslationKeyPrefix = "state_name_";

	private const string c_ActionButtonPrefabResourcesPath = "Prefabs/WarningPanelButton";

	private const string c_ActionButtonPrefabAssetPath = "Assets/Prefabs/WarningPanelButton.prefab";

	private const string c_LocalizationTextPrefabAssetPath = "Assets/Prefabs/LocalizationText.prefab";

	private const float c_PanelWidth = 760f;

	private const float c_RowSpacing = 10f;

	private const float c_TitleFontSize = 24f;

	private const float c_LabelFontSize = 16.6f;

	private const float c_InputFontSize = 18f;

	private const float c_ButtonFontSize = 16f;

	private const float c_BodyFontSize = 16.6f;

	private const float c_HintFontSize = 14f;

	private const float c_LabelWidth = 184f;

	private const float c_CloseButtonWidth = 96f;

	private const float c_ToggleButtonWidth = 244f;

	private const float c_ActionButtonWidth = 92f;

	private const float c_CopyNameButtonWidth = 132f;

	private const float c_CopyRestorationOrdinalButtonWidth = 244f;

	private const float c_ButtonHeight = 40f;

	private const float c_CopyButtonHeight = 34f;

	private const float c_StateNameInputWidth = 420f;

	private const float c_StateNameInputHeight = 48f;

	private const float c_TemplateInputWidth = 420f;

	private const float c_TemplateInputHeight = 56f;

	private const string c_NameRichColor = "#D84E4E";

	private const string c_RestorationOrdinalRichColor = "#4F7DFF";

	private static readonly Color s_CardBackgroundColor;

	private static readonly Color s_SubtleCardBackgroundColor;

	private static readonly Color s_ValidationColor;

	private static readonly Color s_HintColor;

	private static StateCustomNamingPanelUI s_Instance;

	private static GameObject s_InstanceObject;

	[Header("翻译面板")]
	[SerializeField]
	private TranslationUIPanel m_TranslationUIPanel;

	[SerializeField]
	private Button m_ActionButtonPrefab;

	[SerializeField]
	private LocalizationText m_LocalizationTextPrefab;

	private State m_CurrentState;

	private RectTransform m_ContentRoot;

	private TMP_InputField m_StateNameInputField;

	private TMP_InputField m_CustomFullNameFormatInputField;

	private Button m_ToggleCustomNamingButton;

	private LocalizationToggleButton m_ToggleCustomNamingToggle;

	private Button m_TranslateStateNameButton;

	private LocalizationTmpButton m_TranslateStateNameLocalization;

	private Button m_TranslateFullNameFormatButton;

	private LocalizationTmpButton m_TranslateFullNameFormatLocalization;

	private TextMeshProUGUI m_StateNameLabel;

	private TextMeshProUGUI m_FullNameFormatLabel;

	private TextMeshProUGUI m_PlaceholderLabel;

	private TextMeshProUGUI m_ValidationText;

	private TextMeshProUGUI m_PreviewText;

	private TextMeshProUGUI m_PlaceholderHintText;

	private TextMeshProUGUI m_HintText;

	private TextMeshProUGUI m_InheritanceText;

	private string m_ValidationLocalizationKey;

	private bool m_IsEditingFullNameFormat;

	private bool m_IsInitialized;

	public static StateCustomNamingPanelUI Instance => null;

	public static StateCustomNamingPanelUI ExistingInstance => null;

	private static StateCustomNamingPanelUI FindExistingInstance()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Display(State state)
	{
	}

	public void RefreshIfShowing(State state)
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

	private void InitializeComponents()
	{
	}

	private void HideImmediate()
	{
	}

	public void ForceHideImmediate()
	{
	}

	private void EnsureTranslationPanel()
	{
	}

	private void BuildPanelUI()
	{
	}

	private void EnsurePanelStructure()
	{
	}

	private GameObject CreateRow(string rowName, Transform parent)
	{
		return null;
	}

	private void CreateSpacer(string objectName, Transform parent, float width)
	{
	}

	private GameObject CreateColumn(string objectName, Transform parent, float spacing)
	{
		return null;
	}

	private GameObject CreateCard(string objectName, Transform parent, int paddingLeft, int paddingRight, int paddingTop, int paddingBottom, bool isSubtle)
	{
		return null;
	}

	private LayoutElement GetOrAddLayoutElement(GameObject target)
	{
		return null;
	}

	private TextMeshProUGUI CreateText(string objectName, Transform parent, float fontSize, FontStyles fontStyle, Color color)
	{
		return null;
	}

	private TextMeshProUGUI CreateLabel(string objectName, Transform parent)
	{
		return null;
	}

	private TMP_InputField CreateInput(string objectName, Transform parent, UnityAction<string> onEndEdit)
	{
		return null;
	}

	private GameObject CreateFallbackInput(string objectName, Transform parent, out TMP_InputField inputField)
	{
		inputField = null;
		return null;
	}

	private void ConfigureFullNameFormatInputField(TMP_InputField inputField)
	{
	}

	private Button CreateActionButton(string objectName, Transform parent, out LocalizationTmpButton localizationButton, string defaultText)
	{
		localizationButton = null;
		return null;
	}

	private Button GetOrFindActionButtonPrefab()
	{
		return null;
	}

	private Button CreateFallbackButton(string objectName, Transform parent, out LocalizationTmpButton localizationButton, string defaultText)
	{
		localizationButton = null;
		return null;
	}

	private TMP_FontAsset GetTemplateFont()
	{
		return null;
	}

	private void ConfigureToggleCustomNamingButton(LocalizationTmpButton localizationButton)
	{
	}

	private void ConfigurePlaceholderCopyButton(Button button, LocalizationTmpButton localizationButton)
	{
	}

	private LocalizationText GetLocalizationTextTemplate()
	{
		return null;
	}

	private void ConfigureTextAppearance(TextMeshProUGUI text, float fontSize, FontStyles fontStyle, Color color)
	{
	}

	private void ConfigureLocalizationText(LocalizationText localizationText, string key, float fontSize)
	{
	}

	private void SetTextContent(TextMeshProUGUI text, string localizationKey, string customText = null)
	{
	}

	private void ApplyCurrentLanguageInputAppearance(TMP_InputField inputField)
	{
	}

	private void RefreshPanel()
	{
	}

	private void OnStateNameEndEdit(string value)
	{
	}

	private void OnTranslateStateNameClicked()
	{
	}

	private void OnCopyNamePlaceholderClicked()
	{
	}

	private void OnCopyRestorationOrdinalPlaceholderClicked()
	{
	}

	private void CopyTemplatePlaceholderToClipboard(string placeholder)
	{
	}

	private void SetPlaceholder(TMP_InputField inputField, string placeholderText)
	{
	}

	private void ApplyButtonText(Button button, LocalizationTmpButton localizationButton, string text)
	{
	}

	private void SetButtonSize(Button button, float width, float height)
	{
	}

	private void SetInputSize(TMP_InputField inputField, float preferredWidth, float minHeight)
	{
	}

	private string FormatTemplateForDisplay(string template)
	{
		return null;
	}

	private string GetDefaultCustomFullNameTemplate()
	{
		return null;
	}

	private string GetDisplayableCustomFullNameTemplate(string language)
	{
		return null;
	}

	private void OnCustomFullNameFormatSelected(string _)
	{
	}

	private void OnCustomFullNameFormatDeselected(string _)
	{
	}

	private void UpdateFullNameFormatInputDisplay()
	{
	}

	private void ShowTemplateValidationWarning(string localizationKey)
	{
	}

	private void SetValidationMessage(string localizationKey)
	{
	}

	private void ClearValidationMessage()
	{
	}

	private void OnToggleCustomNamingClicked()
	{
	}

	private void OnCustomFullNameFormatEndEdit(string value)
	{
	}

	private void OnTranslateCustomFullNameFormatClicked()
	{
	}

	private void OnCustomFullNameFormatTranslationsCompleted(int stateId, Dictionary<string, string> translations, string fallbackTemplate)
	{
	}

	private void OnStateNameTranslationsCompleted(string key, Dictionary<string, string> translations)
	{
	}

	private Dictionary<string, string> BuildTranslationSeed(Dictionary<string, string> sourceTranslations, string fallbackValue)
	{
		return null;
	}

	private State GetStateById(int stateId)
	{
		return null;
	}

	private void RefreshStateNamePresentation()
	{
	}
}
