using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MPUIKIT;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MilitaryProfileEditorPanelUI : BasePanelUI
{
	private enum EditorContextType
	{
		State = 0,
		Culture = 1
	}

	private enum ModifierViewType
	{
		Recruitment = 0,
		Attack = 1,
		Defense = 2
	}

	private enum TerrainFieldType
	{
		Mountain = 0,
		Biome = 1
	}

	private enum TerrainModifierDetailLevel
	{
		Simple = 0,
		Detailed = 1
	}

	private enum MilitaryImportSourceType
	{
		LocalMod = 0,
		Workshop = 1,
		Culture = 2
	}

	private sealed class MilitaryImportDescriptor
	{
		public string Key;

		public string DisplayName;

		public string TooltipText;

		public string SuccessLabel;

		public Func<MilitaryProfile> LoadProfile;
	}

	private sealed class SimpleButtonView
	{
		public Button Button;

		public Image Background;

		public TextMeshProUGUI Label;

		public Image Icon;

		public bool PreserveIconColors;
	}

	private sealed class TerrainInputBinding
	{
		public TerrainFieldType FieldType;

		public string Key;

		public TextMeshProUGUI Label;

		public TMP_InputField Input;

		public GameObject Row;

		public bool ShowInSimpleView;

		public bool ShowInDetailedView;
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

		public CardTheme(Color backgroundColor, Color outlineColor)
		{
			BackgroundColor = default;
			OutlineColor = default;
		}
	}

	[CompilerGenerated]
	private sealed class _003CShowMilitaryImportOptionsNextFrame_003Ed__228 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MilitaryProfileEditorPanelUI _003C_003E4__this;

		public MilitaryImportSourceType sourceType;

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
		public _003CShowMilitaryImportOptionsNextFrame_003Ed__228(int _003C_003E1__state)
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
	private sealed class _003CTranslateUnitNameCoroutine_003Ed__253 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MilitaryProfileEditorPanelUI _003C_003E4__this;

		public string unitKey;

		public string sourceText;

		public string sourceLanguage;

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
		public _003CTranslateUnitNameCoroutine_003Ed__253(int _003C_003E1__state)
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
	private sealed class _003CTranslateProfileNamesCoroutine_003Ed__254 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MilitaryProfileEditorPanelUI _003C_003E4__this;

		public List<string> sourceTexts;

		public List<string> unitKeys;

		public string sourceLanguage;

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
		public _003CTranslateProfileNamesCoroutine_003Ed__254(int _003C_003E1__state)
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

	private const string c_RecruitmentPreviewMountainKey = "__Mountain__";

	private static readonly string[] s_SimpleBiomeGroupKeys;

	private static readonly string[] s_DetailedBiomeKeys;

	private static readonly Dictionary<string, string[]> s_SimpleBiomeGroupMembers;

	private static readonly Color s_PanelBackgroundColor;

	private static readonly Color s_BodyBackgroundColor;

	private static readonly Color s_CardBackgroundColor;

	private static readonly Color s_SubtleCardBackgroundColor;

	private static readonly Color s_ButtonNormalColor;

	private static readonly Color s_ButtonSelectedBaseColor;

	private static readonly Color s_ButtonDisabledColor;

	private static readonly Color s_VisualLibraryButtonColor;

	private static readonly Color s_VisualLibraryIconColor;

	private static readonly Color s_ButtonTextColor;

	private static readonly Color s_MutedTextColor;

	private static readonly Color s_HintTextColor;

	private static readonly Color s_ReadOnlyHintColor;

	private static readonly Color s_InputBackgroundColor;

	private static readonly Color s_InputTextColor;

	private static readonly Color s_PanelOutlineColor;

	private static readonly Color s_EditableAccentColor;

	private static readonly Color s_LockedAccentColor;

	private static readonly Color s_ImportActionColor;

	private static readonly Color s_RemoveActionColor;

	private static readonly Color s_CallToActionColor;

	private static readonly Color s_LockedButtonColor;

	private static readonly Vector2 s_PanelSize;

	private const float c_ButtonHeight = 36f;

	private const float c_RowSpacing = 10f;

	private const float c_LabelWidth = 172f;

	private const float c_NumericInputWidth = 110f;

	private const float c_TranslationLanguageDropdownWidth = 228f;

	private const float c_TranslationLanguageDropdownHeight = 30f;

	private const float c_TranslationLanguageDropdownFontSize = 16f;

	private const float c_FontScaleMultiplier = 1.1f;

	private const float c_PreviewSize = 72f;

	private const float c_VisualSourceHintPreferredWidth = 520f;

	private const float c_UnitButtonIconSize = 20f;

	private const float c_UnitButtonIconLeftPadding = 10f;

	private const float c_UnitButtonTextLeftInset = 34f;

	private const float c_VisualBindingButtonWidth = 72f;

	private const float c_VisualBindingButtonHeight = 56f;

	private const float c_VisualBindingIconInset = 14f;

	private const float c_RecruitmentPreviewButtonWidth = 112f;

	private const float c_PanelCornerRadius = 8f;

	private const float c_BodyCornerRadius = 8f;

	private const float c_CardCornerRadius = 6f;

	private const float c_FrameCornerRadius = 6f;

	private const float c_PanelShadowSize = 32f;

	private const float c_PanelShadowSpread = 0f;

	private const float c_PanelShadowOffsetAngle = 90f;

	private const float c_PanelShadowOffsetDistance = 9.5f;

	private const string c_ActionButtonPrefabResourcesPath = "Prefabs/WarningPanelButton";

	private const string c_ActionButtonPrefabAssetPath = "Assets/Prefabs/WarningPanelButton.prefab";

	private const string c_LocalizationTextPrefabAssetPath = "Assets/Prefabs/LocalizationText.prefab";

	private static MilitaryProfileEditorPanelUI s_Instance;

	private EditorContextType m_ContextType;

	private State m_CurrentState;

	private MapCulture m_CurrentCulture;

	private string m_SelectedUnitKey;

	private string m_SelectedVisualAssetKey;

	private string m_SelectedTranslationLanguage;

	private ModifierViewType m_SelectedModifierView;

	private bool m_IsInitialized;

	private bool m_IsRefreshing;

	private bool m_IsMilitaryPackageCardVisible;

	private TerrainModifierDetailLevel m_SelectedTerrainModifierDetailLevel;

	private string m_SelectedRecruitmentPreviewTerrainKey;

	private RectTransform m_ScrollContent;

	private TextMeshProUGUI m_HeaderTitleText;

	private GameObject m_TopReadOnlyHintHost;

	private GameObject m_TopReadOnlyHintCard;

	private TextMeshProUGUI m_TopReadOnlyHintText;

	private TextMeshProUGUI m_ContextSummaryText;

	private TextMeshProUGUI m_ContextHintText;

	private RectTransform m_ModeButtonRoot;

	private GameObject m_MilitaryPackageCard;

	private RectTransform m_UnitButtonRoot;

	private RectTransform m_VisualBindingButtonRoot;

	private RectTransform m_ModifierButtonRoot;

	private RectTransform m_TerrainDetailLevelButtonRoot;

	private TMP_InputField m_LocalizedNameInput;

	private TMP_InputField m_BaseCombatPowerInput;

	private TMP_InputField m_RecruitmentWeightInput;

	private TMP_InputField m_LandMovementSpeedInput;

	private TMP_InputField m_LandSpriteScaleInput;

	private TMP_InputField m_MilitaryPackageNameInput;

	private Image m_UnitPreviewBackground;

	private Image m_UnitPreviewIcon;

	private TextMeshProUGUI m_UnitPreviewTitleText;

	private TextMeshProUGUI m_UnitPreviewSubtitleText;

	private TextMeshProUGUI m_LandMovementSpeedHintText;

	private TextMeshProUGUI m_LandSpriteScaleHintText;

	private TextMeshProUGUI m_VisualSourceHintText;

	private TextMeshProUGUI m_ModifierSectionTitleText;

	private TextMeshProUGUI m_ModifierSectionHintText;

	private TextMeshProUGUI m_TerrainHelpText;

	private GameObject m_RecruitmentPreviewCard;

	private TextMeshProUGUI m_RecruitmentPreviewHintText;

	private RectTransform m_RecruitmentPreviewTerrainButtonRoot;

	private TextMeshProUGUI m_RecruitmentPreviewSelectionText;

	private TextMeshProUGUI m_RecruitmentPreviewContentText;

	private TextMeshProUGUI m_MilitaryPackageHintText;

	private TextMeshProUGUI m_MilitaryPackageLocationText;

	private DropdownInfo m_TranslationLanguageDropdownInfo;

	private TMP_Dropdown m_TranslationLanguageDropdown;

	private Button m_AutoTranslateUnitButton;

	private TextMeshProUGUI m_AutoTranslateUnitButtonText;

	private Button m_AutoTranslateProfileButton;

	private TextMeshProUGUI m_AutoTranslateProfileButtonText;

	private Button m_ImportImageButton;

	private TextMeshProUGUI m_ImportImageButtonText;

	private Button m_RemoveImageButton;

	private TextMeshProUGUI m_RemoveImageButtonText;

	private GameObject m_UseStateColorTintRow;

	private Button m_UseStateColorTintButton;

	private TextMeshProUGUI m_UseStateColorTintButtonText;

	private TextMeshProUGUI m_UseStateColorTintHintText;

	private TextMeshProUGUI m_VisualLibraryStatusText;

	private Button m_AddUnitButton;

	private TextMeshProUGUI m_AddUnitButtonText;

	private Button m_DuplicateUnitButton;

	private TextMeshProUGUI m_DuplicateUnitButtonText;

	private Button m_DeleteUnitButton;

	private TextMeshProUGUI m_DeleteUnitButtonText;

	private Button m_CloneToCustomButton;

	private TextMeshProUGUI m_CloneToCustomButtonText;

	private Button m_ToggleMilitaryPackageButton;

	private TextMeshProUGUI m_ToggleMilitaryPackageButtonText;

	private Button m_ResetUnitButton;

	private TextMeshProUGUI m_ResetUnitButtonText;

	private Button m_ResetProfileButton;

	private TextMeshProUGUI m_ResetProfileButtonText;

	private Button m_ExportMilitaryPackageButton;

	private TextMeshProUGUI m_ExportMilitaryPackageButtonText;

	private Button m_ImportMilitaryPackageButton;

	private TextMeshProUGUI m_ImportMilitaryPackageButtonText;

	[SerializeField]
	private Button m_ActionButtonPrefab;

	[SerializeField]
	private LocalizationText m_LocalizationTextPrefab;

	private readonly Dictionary<StateMilitaryBindingMode, SimpleButtonView> m_StateModeButtons;

	private readonly Dictionary<MilitaryProfileMode, SimpleButtonView> m_CultureModeButtons;

	private readonly Dictionary<string, SimpleButtonView> m_UnitButtons;

	private readonly Dictionary<string, SimpleButtonView> m_VisualBindingButtons;

	private readonly Dictionary<ModifierViewType, SimpleButtonView> m_ModifierButtons;

	private readonly Dictionary<TerrainModifierDetailLevel, SimpleButtonView> m_TerrainDetailLevelButtons;

	private readonly Dictionary<string, SimpleButtonView> m_RecruitmentPreviewTerrainButtons;

	private readonly List<TerrainInputBinding> m_TerrainInputBindings;

	private readonly List<string> m_TranslationLanguageOptions;

	private readonly List<StaticLocalizedTextBinding> m_StaticLocalizedTextBindings;

	private readonly Dictionary<string, MilitaryImportDescriptor> m_MilitaryImportDescriptors;

	public static MilitaryProfileEditorPanelUI Instance => null;

	private static MilitaryProfileEditorPanelUI FindExistingInstance()
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

	protected override void RefreshLocalization()
	{
	}

	private void HideImmediate()
	{
	}

	public void Display(State state)
	{
	}

	public void Display(MapCulture culture)
	{
	}

	private void EnsurePanelStructure()
	{
	}

	private void BuildPanelUI()
	{
	}

	private void CreateModifierButton(ModifierViewType modifierViewType)
	{
	}

	private void CreateTerrainDetailLevelButton(TerrainModifierDetailLevel detailLevel)
	{
	}

	private void CreateTerrainFieldBindings(Transform parent)
	{
	}

	private void CreateTerrainInputBindingRow(string objectName, Transform parent, TerrainFieldType fieldType, string key, bool showInSimpleView, bool showInDetailedView, bool enableTooltip)
	{
	}

	private void ConfigureSimpleBiomeTooltip(TextMeshProUGUI label, string groupKey)
	{
	}

	private void CreateRecruitmentPreviewBindings(Transform parent)
	{
	}

	private string BuildSimpleBiomeTooltip(string groupKey)
	{
		return null;
	}

	private void RefreshPanel()
	{
	}

	private void RefreshUnitButtons(MilitaryProfile displayedProfile)
	{
	}

	private void RebuildUnitButtons(MilitaryProfile displayedProfile)
	{
	}

	private void RebuildVisualBindingButtons(MilitaryProfile displayedProfile)
	{
	}

	private void AddVisualBindingButton(MilitaryProfile displayedProfile, string visualAssetKey, bool preserveIconColors)
	{
	}

	private void RefreshPreviewAndBasics(MilitaryProfile displayedProfile)
	{
	}

	private void RefreshTranslationControls(MilitaryProfile displayedProfile)
	{
	}

	private void RefreshVisualBindingButtons(MilitaryProfile displayedProfile)
	{
	}

	private void RefreshImageControls(MilitaryProfile displayedProfile)
	{
	}

	private void RefreshMilitaryPackageControls(MilitaryProfile displayedProfile)
	{
	}

	private void RefreshModifierButtons()
	{
	}

	private void RefreshTerrainDetailLevelButtons()
	{
	}

	private void RefreshTerrainBindings(MilitaryProfile displayedProfile)
	{
	}

	private void RefreshRecruitmentPreview(MilitaryProfile displayedProfile)
	{
	}

	private List<string> GetRecruitmentPreviewTerrainKeys()
	{
		return null;
	}

	private string GetCompatibleRecruitmentPreviewTerrainKey(string currentKey, List<string> previewTerrainKeys)
	{
		return null;
	}

	private void RebuildRecruitmentPreviewTerrainButtons(List<string> previewTerrainKeys)
	{
	}

	private void RefreshRecruitmentPreviewTerrainButtons()
	{
	}

	private string GetRecruitmentPreviewTerrainLabel(string terrainKey)
	{
		return null;
	}

	private string GetRecruitmentPreviewHint(string terrainKey)
	{
		return null;
	}

	private string BuildRecruitmentPreviewContent(MilitaryProfile displayedProfile, string terrainKey)
	{
		return null;
	}

	private MilitaryTerrainContext BuildRecruitmentPreviewTerrainContext(string terrainKey)
	{
		return default;
	}

	private static bool TryGetBiomeIndex(string biomeName, out int biomeIndex)
	{
		biomeIndex = default;
		return false;
	}

	private void RefreshActionButtons()
	{
	}

	private void RebuildModeButtons()
	{
	}

	private void CreateModeButton(StateMilitaryBindingMode mode, bool isSelected, Color accent, Action onClick)
	{
	}

	private void CreateModeButton(MilitaryProfileMode mode, bool isSelected, Color accent, Action onClick)
	{
	}

	private void OnStateModeSelected(StateMilitaryBindingMode mode)
	{
	}

	private void OnCultureModeSelected(MilitaryProfileMode mode)
	{
	}

	private void OnCloneToCustomClicked()
	{
	}

	private void OnResetUnitClicked()
	{
	}

	private void OnResetProfileClicked()
	{
	}

	private void OnUnitButtonClicked(string unitKey)
	{
	}

	private void OnAddUnitClicked()
	{
	}

	private void OnDuplicateUnitClicked()
	{
	}

	private void OnDeleteUnitClicked()
	{
	}

	private void OnTranslationLanguageDropdownValueChanged(int selectedIndex)
	{
	}

	private void OnVisualBindingButtonClicked(string visualUnitKey)
	{
	}

	private void OnStateColorTintButtonClicked()
	{
	}

	private void OnImportImageClicked()
	{
	}

	private void OnRemoveImageClicked()
	{
	}

	private void OnMilitaryPackageNameEndEdit(string value)
	{
	}

	private void OnToggleMilitaryPackageCardClicked()
	{
	}

	private void OnExportMilitaryPackageClicked()
	{
	}

	private void OnImportMilitaryPackageClicked()
	{
	}

	private void OnMilitaryImportSourceSelected(string selectedSourceKey)
	{
	}

	[IteratorStateMachine(typeof(_003CShowMilitaryImportOptionsNextFrame_003Ed__228))]
	private IEnumerator ShowMilitaryImportOptionsNextFrame(MilitaryImportSourceType sourceType)
	{
		return null;
	}

	private void ShowMilitaryImportOptions(MilitaryImportSourceType sourceType)
	{
	}

	private void OnMilitaryImportOptionSelected(string selectedDescriptorKey)
	{
	}

	private List<MilitaryImportDescriptor> BuildLocalMilitaryImportDescriptors()
	{
		return null;
	}

	private List<MilitaryImportDescriptor> BuildWorkshopMilitaryImportDescriptors()
	{
		return null;
	}

	private List<MilitaryImportDescriptor> BuildCultureMilitaryImportDescriptors()
	{
		return null;
	}

	private bool ShouldListCultureMilitaryProfile(string cultureNameId, CultureData cultureData)
	{
		return false;
	}

	private string BuildCultureMilitaryTooltip(string cultureNameId, CultureData cultureData)
	{
		return null;
	}

	private string GetCultureSourceLabel(CultureData cultureData)
	{
		return null;
	}

	private MilitaryProfile EnsureEditableProfileForImport()
	{
		return null;
	}

	private string GetRequestedMilitaryPackageName()
	{
		return null;
	}

	private string BuildSuggestedMilitaryPackageName()
	{
		return null;
	}

	private string BuildCurrentMilitaryPackageSourceLabel()
	{
		return null;
	}

	private void ShowMilitaryPackageMessage(string message)
	{
	}

	private void EnsureSelectContainerPanelVisible()
	{
	}

	private void OnModifierButtonClicked(ModifierViewType modifierView)
	{
	}

	private void OnLocalizedNameInputEndEdit(string value)
	{
	}

	private void OnBaseCombatPowerEndEdit(string value)
	{
	}

	private void OnRecruitmentWeightEndEdit(string value)
	{
	}

	private void OnLandMovementSpeedEndEdit(string value)
	{
	}

	private void OnLandSpriteScaleEndEdit(string value)
	{
	}

	private void OnTerrainModifierEndEdit(TerrainFieldType fieldType, string key, string value)
	{
	}

	private void OnTerrainDetailLevelButtonClicked(TerrainModifierDetailLevel detailLevel)
	{
	}

	private void OnRecruitmentPreviewTerrainButtonClicked(string terrainKey)
	{
	}

	private void HandleImportedImageSelected(bool selected, string filePath, string[] files)
	{
	}

	[IteratorStateMachine(typeof(_003CTranslateUnitNameCoroutine_003Ed__253))]
	private IEnumerator TranslateUnitNameCoroutine(string unitKey, string sourceText, string sourceLanguage)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTranslateProfileNamesCoroutine_003Ed__254))]
	private IEnumerator TranslateProfileNamesCoroutine(List<string> unitKeys, List<string> sourceTexts, string sourceLanguage)
	{
		return null;
	}

	private void OnAutoTranslateUnitClicked()
	{
	}

	private void OnAutoTranslateProfileClicked()
	{
	}

	private void EnsureSelectedTranslationLanguageInitialized()
	{
	}

	private string GetSelectedTranslationLanguage()
	{
		return null;
	}

	private void RefreshTranslationLanguageDropdown(bool editable, string selectedLanguage)
	{
	}

	private void PopulateTranslationLanguageDropdownOptions(string fallbackLanguage)
	{
	}

	private static string GetLocalizedLanguageDisplayName(string language)
	{
		return null;
	}

	private void DetachFileBrowserHandlers()
	{
	}

	private static bool TryValidateImportedImage(byte[] imageBytes)
	{
		return false;
	}

	private MilitaryProfile GetDisplayedProfile()
	{
		return null;
	}

	private MilitaryProfile GetEditableProfile()
	{
		return null;
	}

	private MilitaryUnitDefinition GetEditableSelectedUnitDefinition()
	{
		return null;
	}

	private bool IsEditable()
	{
		return false;
	}

	private StateMilitaryBindingMode GetCurrentStateBindingMode()
	{
		return StateMilitaryBindingMode.InheritCulture;
	}

	private MilitaryProfileMode GetCurrentCultureProfileMode()
	{
		return MilitaryProfileMode.BuiltInDefault;
	}

	private TerrainModifierTable GetCurrentTerrainTable(MilitaryProfile profile)
	{
		return null;
	}

	private void NotifyProfileChanged()
	{
	}

	private void RefreshAffectedArmies()
	{
	}

	private void RefreshMapDefaultArmies()
	{
	}

	private void RefreshStateArmies(State state)
	{
	}

	private void RefreshDependentPanels()
	{
	}

	private static MilitaryProfile CreateEditableClone(MilitaryProfile sourceProfile)
	{
		return null;
	}

	private static void ApplyProfileData(MilitaryProfile targetProfile, MilitaryProfile sourceProfile)
	{
	}

	private string GetPanelTitle()
	{
		return null;
	}

	private string GetContextSummary()
	{
		return null;
	}

	private static string GetCurrentStateDisplayName(State state)
	{
		return null;
	}

	private string GetContextHint()
	{
		return null;
	}

	private string GetStateBindingModeLabel(StateMilitaryBindingMode mode)
	{
		return null;
	}

	private string GetCultureProfileModeLabel(MilitaryProfileMode mode)
	{
		return null;
	}

	private bool IsEditingMapDefaultProfile()
	{
		return false;
	}

	private string GetModifierViewLabel(ModifierViewType modifierViewType)
	{
		return null;
	}

	private string GetModifierViewDescription(ModifierViewType modifierViewType)
	{
		return null;
	}

	private string GetTerrainDetailLevelLabel(TerrainModifierDetailLevel detailLevel)
	{
		return null;
	}

	private string GetDisplayNameForProfile(MilitaryProfile profile, string unitKey)
	{
		return null;
	}

	private string GetBuiltInUnitDisplayName(string unitKey)
	{
		return null;
	}

	private static void SetInputPlaceholder(TMP_InputField inputField, string placeholderText)
	{
	}

	private static void ApplyInputFontForLanguage(TMP_InputField inputField, string language)
	{
	}

	private void ApplySelectedTranslationInputFont()
	{
	}

	private void ApplyTranslationLanguageDropdownTextStyle()
	{
	}

	private string GetTerrainFieldLabel(TerrainFieldType fieldType, string key)
	{
		return null;
	}

	private string GetVisualBindingKey(MilitaryProfile profile, string unitKey)
	{
		return null;
	}

	private static bool ShouldUseStateColorTint(MilitaryProfile profile, string unitKey)
	{
		return false;
	}

	private void EnsureSelectedVisualAssetKey(MilitaryProfile profile, bool syncToCurrentUnitBinding)
	{
	}

	private string GetSelectedVisualAssetKey(MilitaryProfile profile)
	{
		return null;
	}

	private static bool TryGetSimpleBiomeGroupMembers(string groupKey, out string[] biomeKeys)
	{
		biomeKeys = null;
		return false;
	}

	private bool ShouldShowTerrainBinding(TerrainInputBinding binding)
	{
		return false;
	}

	private bool TryGetTerrainBindingDisplayValue(TerrainModifierTable table, TerrainInputBinding binding, out string displayValue, out string placeholderText)
	{
		displayValue = null;
		placeholderText = null;
		return false;
	}

	private bool IsVisualSelectionAvailable(MilitaryProfile profile, string visualKey)
	{
		return false;
	}

	private string SanitizeVisualSelection(MilitaryProfile profile, string visualKey)
	{
		return null;
	}

	private string GetVisualAssetDisplayName(MilitaryProfile profile, string visualKey)
	{
		return null;
	}

	private static string NormalizeVisualBindingKey(string visualKey)
	{
		return null;
	}

	private static float ResolveTerrainFieldValue(TerrainModifierTable table, TerrainFieldType fieldType, string key)
	{
		return 0f;
	}

	private static bool TryParsePositiveFloat(string input, float minValue, out float value)
	{
		value = default;
		return false;
	}

	private static bool TryParseTerrainModifier(string input, out float value)
	{
		value = default;
		return false;
	}

	private static string FormatFloat(float value)
	{
		return null;
	}

	private static string FormatPercent(float value)
	{
		return null;
	}

	private Color GetAccentColor()
	{
		return default;
	}

	private static Color GetSelectedButtonColor(Color accentColor)
	{
		return default;
	}

	private static CardTheme GetCardTheme(string objectName, bool subtle)
	{
		return default;
	}

	private static Color GetUnitButtonColor(string unitKey)
	{
		return default;
	}

	private static Color GetUnitButtonIconColor(string unitKey)
	{
		return default;
	}

	private Color GetUnitButtonSelectedColor(string unitKey, Color accentColor)
	{
		return default;
	}

	private static Color GetVisualBindingButtonColor()
	{
		return default;
	}

	private void ApplyChoiceButtonStyle(SimpleButtonView view, bool isSelected, bool isInteractable, Color accentColor)
	{
	}

	private void ApplyChoiceButtonStyle(SimpleButtonView view, bool isSelected, bool isInteractable, Color normalColor, Color selectedColor, Color disabledColor, Color labelColor, Color normalIconColor, Color selectedIconColor)
	{
	}

	private void ApplyUnitButtonStyle(SimpleButtonView view, string unitKey, bool isSelected, bool isInteractable, Color accentColor)
	{
	}

	private void ApplyVisualBindingButtonStyle(SimpleButtonView view, bool isSelected, bool isInteractable, Color accentColor)
	{
	}

	private void ApplyActionButtonStyle(Button button, TextMeshProUGUI label, bool isInteractable, Color activeColor, Color disabledColor, Color activeTextColor, Color disabledTextColor)
	{
	}

	private GameObject CreateCard(string objectName, Transform parent, bool subtle)
	{
		return null;
	}

	private GameObject CreateRow(string objectName, Transform parent)
	{
		return null;
	}

	private GameObject CreateFlexibleRow(string objectName, Transform parent, float spacing)
	{
		return null;
	}

	private GameObject CreateButtonGrid(string objectName, Transform parent, float cellWidth, float cellHeight, int columnCount)
	{
		return null;
	}

	private GameObject CreateColumn(string objectName, Transform parent, float spacing)
	{
		return null;
	}

	private GameObject CreateEditorRow(string objectName, Transform parent, string labelText)
	{
		return null;
	}

	private GameObject CreateLocalizedEditorRow(string objectName, Transform parent, string localizationKey)
	{
		return null;
	}

	private TextMeshProUGUI CreateFixedLabel(string objectName, Transform parent, string text)
	{
		return null;
	}

	private TextMeshProUGUI CreateLocalizedFixedLabel(string objectName, Transform parent, string localizationKey)
	{
		return null;
	}

	private static float ScaleFontSize(float fontSize)
	{
		return 0f;
	}

	private TextMeshProUGUI CreateText(string objectName, Transform parent, float fontSize, FontStyles fontStyle, Color color, TextAlignmentOptions alignment)
	{
		return null;
	}

	private TextMeshProUGUI CreateLocalizedText(string objectName, Transform parent, float fontSize, FontStyles fontStyle, Color color, TextAlignmentOptions alignment, string localizationKey)
	{
		return null;
	}

	private void RegisterStaticLocalizedText(TextMeshProUGUI text, string localizationKey)
	{
	}

	private void RefreshStaticLocalizedTexts()
	{
	}

	private Button CreateButton(string objectName, Transform parent, out TextMeshProUGUI textComponent, string text, float width, float height)
	{
		textComponent = null;
		return null;
	}

	private Button CreateIconButton(string objectName, Transform parent, out TextMeshProUGUI textComponent, out Image iconComponent, Sprite iconSprite, float width, float height)
	{
		textComponent = null;
		iconComponent = null;
		return null;
	}

	private DropdownInfo CreateDropdown(string objectName, Transform parent, string labelLocalizationKey, float width, float dropdownHeight, bool showLabel)
	{
		return null;
	}

	private Button CreateButtonWithLeftIcon(string objectName, Transform parent, out TextMeshProUGUI textComponent, out Image iconComponent, string text, Sprite iconSprite, float width, float height)
	{
		textComponent = null;
		iconComponent = null;
		return null;
	}

	private TMP_InputField CreateInput(string objectName, Transform parent, UnityAction<string> onEndEdit, float width, string placeholderText, bool isNumeric)
	{
		return null;
	}

	private LayoutElement GetOrAddLayoutElement(GameObject target)
	{
		return null;
	}

	private static void ConfigureRoundedRectangle(MPImage image, Color fillColor, float cornerRadius, float outlineWidth, Color outlineColor, bool raycastTarget)
	{
	}

	private void ConfigurePanelShadow()
	{
	}

	private Button GetOrFindActionButtonPrefab()
	{
		return null;
	}

	private LocalizationText GetLocalizationTextTemplate()
	{
		return null;
	}

	private void ApplyCurrentFontToAllTexts(Transform root)
	{
	}

	private static string T(string localizationKey)
	{
		return null;
	}
}
