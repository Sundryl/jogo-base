using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FantasyWorld.CharacterSystem;
using MPUIKIT;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public sealed class OfficialTitleEditorPanelUI : BasePanelUI
{
	private enum TitleVariant
	{
		General = 0,
		Male = 1,
		Female = 2
	}

	private enum EditorContextType
	{
		Culture = 0,
		State = 1,
		MapDefault = 2
	}

	private sealed class TitleImportDescriptor
	{
		public string Key;

		public string DisplayName;

		public Func<OfficialTitleProfile> LoadProfile;
	}

	private sealed class SimpleButtonView
	{
		public Button Button;

		public Image Background;

		public TextMeshProUGUI Label;
	}

	private sealed class OfficeCardView
	{
		public string OfficeId;

		public TextMeshProUGUI FunctionLabel;

		public TextMeshProUGUI FunctionHint;

		public TextMeshProUGUI SourceLabel;

		public TextMeshProUGUI EffectiveTitle;

		public TMP_InputField Input;

		public Button TranslateButton;

		public TextMeshProUGUI TranslateButtonLabel;

		public Button RestoreButton;

		public TextMeshProUGUI RestoreButtonLabel;
	}

	private sealed class StaticLocalizedTextBinding
	{
		public TextMeshProUGUI Text;

		public string LocalizationKey;
	}

	private readonly struct CardTheme
	{
		public readonly Color BackgroundColor;

		public readonly Color OutlineColor;

		public CardTheme(Color _backgroundColor, Color _outlineColor)
		{
			BackgroundColor = default;
			OutlineColor = default;
		}
	}

	[CompilerGenerated]
	private sealed class _003CTranslateOfficialTitlesCoroutine_003Ed__153 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OfficialTitleEditorPanelUI _003C_003E4__this;

		public int _sessionVersion;

		public OfficialTitleProfile _sessionProfile;

		public List<string> _sourceTexts;

		public PoliticalSystem? _scope;

		public List<string> _officeIds;

		public Gender? _gender;

		public List<string> _targetLanguages;

		public string _sourceLanguage;

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
		public _003CTranslateOfficialTitlesCoroutine_003Ed__153(int _003C_003E1__state)
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

	private const string c_AnyScopeKey = "Any";

	private const string c_ActionButtonPrefabResourcesPath = "Prefabs/WarningPanelButton";

	private const string c_ActionButtonPrefabAssetPath = "Assets/Prefabs/WarningPanelButton.prefab";

	private const float c_ButtonHeight = 36f;

	private const float c_RowSpacing = 10f;

	private const float c_LabelWidth = 172f;

	private const float c_FontScaleMultiplier = 1.1f;

	private const float c_PanelCornerRadius = 8f;

	private const float c_BodyCornerRadius = 8f;

	private const float c_CardCornerRadius = 6f;

	private const float c_PanelShadowSize = 32f;

	private const float c_PanelShadowOffsetDistance = 9.5f;

	private static readonly Vector2 s_PanelSize;

	private static readonly Color s_PanelBackgroundColor;

	private static readonly Color s_BodyBackgroundColor;

	private static readonly Color s_CardBackgroundColor;

	private static readonly Color s_SubtleCardBackgroundColor;

	private static readonly Color s_ButtonNormalColor;

	private static readonly Color s_ButtonSelectedColor;

	private static readonly Color s_ButtonDisabledColor;

	private static readonly Color s_ButtonTextColor;

	private static readonly Color s_MutedTextColor;

	private static readonly Color s_HintTextColor;

	private static readonly Color s_DisabledButtonTextColor;

	private static readonly Color s_ReadOnlyHintColor;

	private static readonly Color s_InputBackgroundColor;

	private static readonly Color s_InputTextColor;

	private static readonly Color s_PanelOutlineColor;

	private static readonly Color s_ConfirmActionColor;

	private static readonly Color s_RemoveActionColor;

	private static readonly Color s_SecondaryActionColor;

	private static readonly Color s_EditableAccentColor;

	private static readonly string[] s_OfficeIds;

	private static OfficialTitleEditorPanelUI s_Instance;

	private EditorContextType m_ContextType;

	private MapCulture m_CurrentCulture;

	private State m_CurrentState;

	private OfficialTitleProfile m_WorkingProfile;

	private StateOfficialTitleBinding m_WorkingStateBinding;

	private bool m_OriginalStateHadCustomProfile;

	private PoliticalSystem? m_SelectedPoliticalSystem;

	private TitleVariant m_SelectedVariant;

	private string m_SelectedLanguage;

	private bool m_IsInitialized;

	private bool m_IsRefreshing;

	private bool m_IsDirty;

	private bool m_IsAutoTranslating;

	private int m_SessionVersion;

	private Coroutine m_AutoTranslateCoroutine;

	private RectTransform m_ScrollContent;

	private TextMeshProUGUI m_HeaderTitleText;

	private GameObject m_TopReadOnlyHintHost;

	private GameObject m_TopReadOnlyHintCard;

	private TextMeshProUGUI m_TopReadOnlyHintText;

	private TextMeshProUGUI m_ContextSummaryText;

	private TextMeshProUGUI m_ContextHintText;

	private TextMeshProUGUI m_OverrideSummaryText;

	private GameObject m_ModeCard;

	private TextMeshProUGUI m_ModeHintText;

	private RectTransform m_ModeButtonRoot;

	private TextMeshProUGUI m_PresetHintText;

	private TextMeshProUGUI m_ScopeHintText;

	private TextMeshProUGUI m_TranslationHelpText;

	private TextMeshProUGUI m_StatusText;

	private GameObject m_PresetCard;

	private OfficialTitleProfile m_MapDefaultPreviewPlaceholder;

	private Button m_OpenMapDefaultButton;

	private TextMeshProUGUI m_OpenMapDefaultButtonLabel;

	private Button m_ImportTitlesButton;

	private TextMeshProUGUI m_ImportTitlesButtonLabel;

	private readonly Dictionary<string, TitleImportDescriptor> m_TitleImportDescriptors;

	private DropdownInfo m_PresetDropdownInfo;

	private TMP_Dropdown m_PresetDropdown;

	private DropdownInfo m_LanguageDropdownInfo;

	private TMP_Dropdown m_LanguageDropdown;

	private RectTransform m_ScopeButtonRoot;

	private RectTransform m_VariantButtonRoot;

	private Button m_RestoreScopeButton;

	private TextMeshProUGUI m_RestoreScopeButtonLabel;

	private Button m_RestoreRecommendedButton;

	private TextMeshProUGUI m_RestoreRecommendedButtonLabel;

	private Button m_AutoTranslateScopeButton;

	private TextMeshProUGUI m_AutoTranslateScopeButtonLabel;

	private Button m_RecopyCultureButton;

	private TextMeshProUGUI m_RecopyCultureButtonLabel;

	private Button m_SaveButton;

	private TextMeshProUGUI m_SaveButtonLabel;

	private Button m_CancelButton;

	private TextMeshProUGUI m_CancelButtonLabel;

	[SerializeField]
	private Button m_ActionButtonPrefab;

	private readonly List<string> m_PresetOptions;

	private readonly List<string> m_LanguageOptions;

	private readonly Dictionary<string, OfficeCardView> m_OfficeViews;

	private readonly Dictionary<string, SimpleButtonView> m_ScopeButtons;

	private readonly Dictionary<TitleVariant, SimpleButtonView> m_VariantButtons;

	private readonly Dictionary<StateOfficialTitleBindingMode, SimpleButtonView> m_ModeButtons;

	private readonly List<StaticLocalizedTextBinding> m_StaticLocalizedTextBindings;

	public static OfficialTitleEditorPanelUI Instance => null;

	private static Canvas FindRootCanvas()
	{
		return null;
	}

	private static OfficialTitleEditorPanelUI FindExistingInstance()
	{
		return null;
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

	protected override void OnPanelHide()
	{
	}

	protected override void OnCloseButtonClicked()
	{
	}

	protected override void RefreshLocalization()
	{
	}

	private void HideImmediate()
	{
	}

	public void Display(MapCulture _culture, PoliticalSystem? _initialPoliticalSystem = null)
	{
	}

	public void DisplayMapDefault(PoliticalSystem? _initialPoliticalSystem = null)
	{
	}

	public void Display(State _state, PoliticalSystem? _initialPoliticalSystem = null)
	{
	}

	private static MapCulture GetStateCulture(State _state)
	{
		return null;
	}

	private static PoliticalSystem? GetInitialPoliticalSystem(MapCulture _culture)
	{
		return null;
	}

	private void EnsurePanelStructure()
	{
	}

	private void BuildPanelUI()
	{
	}

	private void BuildModeButtons()
	{
	}

	private void BuildScopeButtons()
	{
	}

	private void CreateScopeButton(PoliticalSystem? _politicalSystem)
	{
	}

	private void BuildVariantButtons()
	{
	}

	private void BuildOfficeCard(Transform _parent, string _officeId)
	{
	}

	private void RefreshPanel()
	{
	}

	private void RefreshPresetDropdown(OfficialTitleProfile _displayedProfile, bool _editable)
	{
	}

	private void RefreshLanguageDropdown()
	{
	}

	private void RefreshScopeButtons()
	{
	}

	private void RefreshModeButtons(bool _configurable)
	{
	}

	private void RefreshVariantButtons()
	{
	}

	private void RefreshOfficeViews(bool _editable)
	{
	}

	private void RefreshActions(bool _editable)
	{
	}

	private void OnPresetDropdownValueChanged(int _index)
	{
	}

	private void OnStateModeSelected(StateOfficialTitleBindingMode _mode)
	{
	}

	private void OnRecopyCultureClicked()
	{
	}

	private void RecopyCultureProfileConfirmed(int _sessionVersion, StateOfficialTitleBinding _sessionBinding)
	{
	}

	private OfficialTitleProfile CloneCurrentCultureProfileForState()
	{
		return null;
	}

	private void OnLanguageDropdownValueChanged(int _index)
	{
	}

	private void OnScopeSelected(PoliticalSystem? _politicalSystem)
	{
	}

	private void OnVariantSelected(TitleVariant _variant)
	{
	}

	private void OnTitleEndEdit(string _officeId, string _value)
	{
	}

	private void OnTitleValueChanged(string _officeId, string _value)
	{
	}

	private void FlushVisibleInputs()
	{
	}

	private void SetDirectTranslation(string _officeId, Gender? _gender, string _language, string _value)
	{
	}

	private void OnAutoTranslateOfficeClicked(string _officeId)
	{
	}

	private void OnAutoTranslateScopeClicked()
	{
	}

	private void StartOfficialTitleTranslation(OfficialTitleProfile _editableProfile, List<string> _officeIds, List<string> _sourceTexts, PoliticalSystem? _scope, Gender? _gender, string _sourceLanguage)
	{
	}

	private static bool SeedSourceLanguageTranslations(OfficialTitleProfile _editableProfile, List<string> _officeIds, List<string> _sourceTexts, PoliticalSystem? _scope, Gender? _gender, string _sourceLanguage)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CTranslateOfficialTitlesCoroutine_003Ed__153))]
	private IEnumerator TranslateOfficialTitlesCoroutine(int _sessionVersion, OfficialTitleProfile _sessionProfile, List<string> _officeIds, List<string> _sourceTexts, List<string> _targetLanguages, PoliticalSystem? _scope, Gender? _gender, string _sourceLanguage)
	{
		return null;
	}

	private bool IsAutoTranslationSessionValid(int _sessionVersion, OfficialTitleProfile _sessionProfile)
	{
		return false;
	}

	private void CancelAutoTranslation()
	{
	}

	private void RestoreOffice(string _officeId)
	{
	}

	private void OnRestoreScopeClicked()
	{
	}

	private void OnRestoreRecommendedClicked()
	{
	}

	private void OnSaveClicked()
	{
	}

	private void RequestSaveAsInheritedConfirmation()
	{
	}

	private void CommitStateBinding()
	{
	}

	private void CancelAndHide()
	{
	}

	private void OnOpenMapDefaultClicked()
	{
	}

	private void OnImportTitlesClicked()
	{
	}

	private List<TitleImportDescriptor> BuildTitleImportDescriptors()
	{
		return null;
	}

	private void AppendCultureTitleImportDescriptor(List<TitleImportDescriptor> _descriptors, string _cultureNameId)
	{
	}

	private void OnTitleImportOptionSelected(string _selectedKey)
	{
	}

	private OfficialTitleProfile EnsureEditableProfileForImport()
	{
		return null;
	}

	private static void EnsureSelectContainerPanelVisible()
	{
	}

	private OfficialTitleResolution ResolveWorkingTitle(string _officeId, Gender? _gender, string _language)
	{
		return null;
	}

	private OfficialTitleResolution ResolveInheritedTitle(string _officeId, Gender? _gender, string _language)
	{
		return null;
	}

	private string GetDirectTranslation(string _officeId, Gender? _gender, string _language)
	{
		return null;
	}

	private int CountScopeOverrides(PoliticalSystem? _politicalSystem)
	{
		return 0;
	}

	private void EnsureSelectedLanguageInitialized()
	{
	}

	private string GetSelectedLanguage()
	{
		return null;
	}

	private void PopulateLanguageOptions()
	{
	}

	private Gender? GetSelectedGender()
	{
		return null;
	}

	private static Dictionary<string, string> GetVariantTranslations(OfficialTitleEntry _entry, Gender? _gender)
	{
		return null;
	}

	private static string TryGetTranslation(Dictionary<string, string> _translations, string _language)
	{
		return null;
	}

	private static bool IsEmpty(OfficialTitleEntry _entry)
	{
		return false;
	}

	private static PoliticalSystem? ParseScopeKey(string _key)
	{
		return null;
	}

	private string GetCurrentScopeDisplayName(PoliticalSystem? _politicalSystem)
	{
		return null;
	}

	private static string GetVariantLocalizationKey(TitleVariant _variant)
	{
		return null;
	}

	private static string GetLocalizedLanguageDisplayName(string _language)
	{
		return null;
	}

	private static string GetPresetDisplayName(string _presetId)
	{
		return null;
	}

	private string GetSourceDisplayName(OfficialTitleResolution _resolution)
	{
		return null;
	}

	private static Color GetSourceColor(OfficialTitleSourceKind _sourceKind)
	{
		return default;
	}

	private bool HasValidContext()
	{
		return false;
	}

	private OfficialTitleProfile GetDisplayedProfile()
	{
		return null;
	}

	private OfficialTitleProfile GetEditableProfile()
	{
		return null;
	}

	private StateOfficialTitleBindingMode GetWorkingStateMode()
	{
		return StateOfficialTitleBindingMode.InheritCulture;
	}

	private bool IsEditingStateCustomProfile()
	{
		return false;
	}

	private string GetContextDisplayName()
	{
		return null;
	}

	private bool CanConfigure()
	{
		return false;
	}

	private bool CanEdit()
	{
		return false;
	}

	private static CardTheme GetCardTheme(string _objectName, bool _subtle)
	{
		return default;
	}

	private static void ApplyChoiceButtonStyle(SimpleButtonView _view, bool _selected, bool _interactable)
	{
	}

	private static void ApplyActionButtonStyle(Button _button, TextMeshProUGUI _label, bool _interactable, Color _activeColor)
	{
	}

	private GameObject CreateCard(string _objectName, Transform _parent, bool _subtle)
	{
		return null;
	}

	private GameObject CreateRow(string _objectName, Transform _parent)
	{
		return null;
	}

	private GameObject CreateFlexibleRow(string _objectName, Transform _parent, float _spacing)
	{
		return null;
	}

	private GameObject CreateButtonGrid(string _objectName, Transform _parent, float _cellWidth, float _cellHeight, int _columnCount)
	{
		return null;
	}

	private GameObject CreateColumn(string _objectName, Transform _parent, float _spacing)
	{
		return null;
	}

	private TextMeshProUGUI CreateFixedLabel(string _objectName, Transform _parent, string _text)
	{
		return null;
	}

	private TextMeshProUGUI CreateLocalizedFixedLabel(string _objectName, Transform _parent, string _localizationKey)
	{
		return null;
	}

	private TextMeshProUGUI CreateText(string _objectName, Transform _parent, float _fontSize, FontStyles _fontStyle, Color _color, TextAlignmentOptions _alignment)
	{
		return null;
	}

	private TextMeshProUGUI CreateLocalizedText(string _objectName, Transform _parent, float _fontSize, FontStyles _fontStyle, Color _color, TextAlignmentOptions _alignment, string _localizationKey)
	{
		return null;
	}

	private void RegisterStaticLocalizedText(TextMeshProUGUI _text, string _localizationKey)
	{
	}

	private void RefreshStaticLocalizedTexts()
	{
	}

	private Button CreateButton(string _objectName, Transform _parent, out TextMeshProUGUI _textComponent, string _text, float _width, float _height)
	{
		_textComponent = null;
		return null;
	}

	private DropdownInfo CreateDropdown(string _objectName, Transform _parent, string _labelLocalizationKey, float _width, float _dropdownHeight, bool _showLabel)
	{
		return null;
	}

	private TMP_InputField CreateInput(string _objectName, Transform _parent, UnityAction<string> _onEndEdit, float _width, string _placeholderText, bool _flexibleWidth)
	{
		return null;
	}

	private static TextMeshProUGUI CreateInputText(string _objectName, Transform _parent, Color _color, FontStyles _style)
	{
		return null;
	}

	private static GameObject CreateFlexibleSpacer(string _name, Transform _parent)
	{
		return null;
	}

	private static LayoutElement GetOrAddLayoutElement(GameObject _target)
	{
		return null;
	}

	private static void ConfigureRoundedRectangle(MPImage _image, Color _fillColor, float _cornerRadius, float _outlineWidth, Color _outlineColor, bool _raycastTarget)
	{
	}

	private void ConfigurePanelShadow()
	{
	}

	private Button GetOrFindActionButtonPrefab()
	{
		return null;
	}

	private static void ApplyCurrentFontToAllTexts(Transform _root)
	{
	}

	private static string T(string _localizationKey)
	{
		return null;
	}
}
