using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FantasyWorld.CharacterSystem;
using MPUIKIT;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class GovernmentOfficeManagementPanelUI : BasePanelUI
{
	private enum ManagementSection
	{
		Central = 0,
		District = 1,
		Local = 2,
		Wartime = 3
	}

	private enum CardKind
	{
		Default = 0,
		Subtle = 1,
		Summary = 2,
		Controls = 3,
		Navigation = 4,
		Section = 5,
		Warning = 6,
		Selected = 7
	}

	private sealed class OfficeScope
	{
		public string OfficeId;

		public GovernmentOfficeScopeKind ScopeKind;

		public int ScopeId;

		public GovernmentOfficeWarSystemKind WarSystemKind;

		public string ScopeDisplayName;
	}

	private sealed class WarScopeInfo
	{
		public GovernmentOfficeWarSystemKind WarSystemKind;

		public int WarId;

		public string DisplayName;
	}

	private sealed class SimpleButtonView
	{
		public Button Button;

		public Image Background;

		public TextMeshProUGUI Label;
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
	private sealed class _003CFillVacanciesCoroutine_003Ed__126 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GovernmentOfficeManagementPanelUI _003C_003E4__this;

		public State _targetState;

		public IReadOnlyList<OfficeScope> _scopes;

		private int _003CfilledCount_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CFillVacanciesCoroutine_003Ed__126(int _003C_003E1__state)
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

	private const string c_ActionButtonPrefabResourcesPath = "Prefabs/WarningPanelButton";

	private const string c_ActionButtonPrefabAssetPath = "Assets/Prefabs/WarningPanelButton.prefab";

	private const float c_ButtonHeight = 36f;

	private const float c_RowSpacing = 10f;

	private const float c_FontScaleMultiplier = 1.1f;

	private const float c_PanelScale = 1f;

	private const float c_PanelCornerRadius = 8f;

	private const float c_BodyCornerRadius = 8f;

	private const float c_CardCornerRadius = 6f;

	private const float c_PanelShadowSize = 32f;

	private const float c_PanelShadowOffsetDistance = 9.5f;

	private const int c_CandidatesPerPage = 12;

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

	private static readonly Color s_PanelOutlineColor;

	private static readonly Color s_ConfirmActionColor;

	private static readonly Color s_RemoveActionColor;

	private static readonly Color s_SecondaryActionColor;

	private static readonly Color s_OfficeTitleTextColor;

	private static readonly Color s_EditableAccentColor;

	private static readonly Color s_LockedAccentColor;

	private static readonly string[] s_CentralOfficeIds;

	private static GovernmentOfficeManagementPanelUI s_Instance;

	private State m_CurrentState;

	private ManagementSection m_SelectedSection;

	private int m_SelectedProvinceId;

	private int m_SelectedDistrictId;

	private OfficeScope m_CandidateScope;

	private List<GovernmentOfficeCandidateScore> m_Candidates;

	private int m_SelectedCandidateId;

	private int m_CandidatePage;

	private int m_DisplaySessionVersion;

	private bool m_IsInitialized;

	private bool m_IsRebuilding;

	private bool m_IsFillingVacancies;

	private string m_StatusLocalizationKey;

	private object[] m_StatusArguments;

	private Coroutine m_FillVacanciesCoroutine;

	private readonly Dictionary<string, GovernmentOfficeAssignment> m_AssignmentSnapshot;

	private readonly Dictionary<string, Character> m_HolderSnapshot;

	private readonly List<Province> m_ProvinceSnapshot;

	private readonly List<District> m_DistrictSnapshot;

	private readonly List<WarScopeInfo> m_WarSnapshot;

	private int m_CentralFilledCount;

	private int m_DistrictFilledCount;

	private int m_LocalFilledCount;

	private int m_WartimeFilledCount;

	private bool m_HasFamily;

	private RectTransform m_ScrollContent;

	private ScrollRect m_ScrollRect;

	private TextMeshProUGUI m_HeaderTitleText;

	private TextMeshProUGUI m_CloseButtonLabel;

	private GameObject m_TopReadOnlyHintHost;

	private GameObject m_TopReadOnlyHintCard;

	private TextMeshProUGUI m_TopReadOnlyHintText;

	private TextMeshProUGUI m_StatusText;

	private Button m_PrimaryActionButton;

	private TextMeshProUGUI m_PrimaryActionButtonLabel;

	private Button m_SecondaryActionButton;

	private TextMeshProUGUI m_SecondaryActionButtonLabel;

	[SerializeField]
	private Button m_ActionButtonPrefab;

	public static GovernmentOfficeManagementPanelUI Instance => null;

	private static Canvas FindRootCanvas()
	{
		return null;
	}

	private static GovernmentOfficeManagementPanelUI FindExistingInstance()
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

	public void Display(State _state)
	{
	}

	private void HideImmediate()
	{
	}

	private void BuildPanelStructure()
	{
	}

	private void RefreshPanel(bool _resetScrollPosition = false)
	{
	}

	private void RebuildScrollContent()
	{
	}

	private void BuildManagementContent()
	{
	}

	private void BuildSummaryCard(IReadOnlyList<Province> _provinces, IReadOnlyList<District> _districts, IReadOnlyList<WarScopeInfo> _wars)
	{
	}

	private void BuildNoFamilyHintCard()
	{
	}

	private static string BuildNoFamilyHintText()
	{
		return null;
	}

	private void BuildControlsCard()
	{
	}

	private void BuildNavigationCard(IReadOnlyList<Province> _provinces, IReadOnlyList<District> _districts, IReadOnlyList<WarScopeInfo> _wars)
	{
	}

	private void BuildSectionButton(Transform _parent, ManagementSection _section, string _localizationKey, int _filled, int _total)
	{
	}

	private void BuildCentralSection()
	{
	}

	private void BuildDistrictSection(IReadOnlyList<District> _districts)
	{
	}

	private void BuildLocalSection(IReadOnlyList<Province> _provinces)
	{
	}

	private void BuildWartimeSection(IReadOnlyList<WarScopeInfo> _wars)
	{
	}

	private void BuildSectionHeader(Transform _parent, string _titleLocalizationKey, string _hintLocalizationKey)
	{
	}

	private void BuildOfficeCard(Transform _parent, OfficeScope _scope)
	{
	}

	private void BuildHolderDetails(Transform _parent, OfficeScope _scope, GovernmentOfficeAssignment _assignment, Character _holder)
	{
	}

	private void BuildOfficeActions(Transform _parent, OfficeScope _scope, GovernmentOfficeAssignment _assignment, Character _holder)
	{
	}

	private void BuildCandidateContent()
	{
	}

	private void BuildCandidatePagination(Transform _parent, int _pageCount)
	{
	}

	private void BuildCandidateCard(Transform _parent, GovernmentOfficeCandidateScore _score)
	{
	}

	private void RefreshFooter(bool _editable)
	{
	}

	private void OnPrimaryActionClicked()
	{
	}

	private void OnSecondaryActionClicked()
	{
	}

	private void ToggleAutoAppointment()
	{
	}

	private void ToggleAssignmentLock(OfficeScope _scope)
	{
	}

	private void RequestDismissAssignment(OfficeScope _scope)
	{
	}

	private void DismissAssignmentConfirmed(State _targetState, OfficeScope _scope, int _expectedHolderId, int _sessionVersion)
	{
	}

	private void OpenCandidateMode(OfficeScope _scope)
	{
	}

	private void ReloadCandidates()
	{
	}

	private void ConfirmCandidateAppointment()
	{
	}

	private void CloseCandidateMode()
	{
	}

	private void BeginFillAllVacancies()
	{
	}

	private List<OfficeScope> BuildVacantScopes()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFillVacanciesCoroutine_003Ed__126))]
	private IEnumerator FillVacanciesCoroutine(IReadOnlyList<OfficeScope> _scopes, State _targetState)
	{
		return null;
	}

	private int TryFillVacancy(OfficeScope _scope)
	{
		return 0;
	}

	private void CancelFillVacancies()
	{
	}

	private bool IsOfficeScopeActive(OfficeScope _scope)
	{
		return false;
	}

	private static bool IsActiveWarScope(State _state, GovernmentOfficeWarSystemKind _warSystemKind, int _warId)
	{
		return false;
	}

	private void RebuildStateSnapshot()
	{
	}

	private GovernmentOfficeAssignment GetSnapshotAssignment(OfficeScope _scope)
	{
		return null;
	}

	private GovernmentOfficeAssignment GetSnapshotAssignment(string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind)
	{
		return null;
	}

	private Character GetSnapshotHolder(OfficeScope _scope)
	{
		return null;
	}

	private Character GetSnapshotHolder(string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind)
	{
		return null;
	}

	private static OfficeScope CloneScope(OfficeScope _scope)
	{
		return null;
	}

	private static List<District> GetManageableDistricts(IReadOnlyList<Province> _ownedProvinces)
	{
		return null;
	}

	private static List<Province> GetManageableProvinces(State _state)
	{
		return null;
	}

	private static List<WarScopeInfo> GetActiveWarScopes(State _state)
	{
		return null;
	}

	private static string GetWarV2DisplayName(WarV2 _war)
	{
		return null;
	}

	private string BuildDistrictOptionDisplay(District _district)
	{
		return null;
	}

	private string BuildDistrictScopeDisplayName(District _district)
	{
		return null;
	}

	private string BuildProvinceOptionDisplay(Province _province)
	{
		return null;
	}

	private static string BuildCharacterSkillsText(Character _character)
	{
		return null;
	}

	private static string BuildHolderEffectsText(string _officeId, Character _character)
	{
		return null;
	}

	private static string FormatSignedPercent(float _value)
	{
		return null;
	}

	private static string GetCultureDisplayName(State _state)
	{
		return null;
	}

	private bool CanEdit()
	{
		return false;
	}

	private bool CanMutate()
	{
		return false;
	}

	private static CardTheme GetCardTheme(CardKind _kind)
	{
		return default;
	}

	private static void ApplyChoiceButtonStyle(SimpleButtonView _view, bool _selected, bool _interactable)
	{
	}

	private static void ApplyActionButtonStyle(Button _button, TextMeshProUGUI _label, bool _interactable, Color _activeColor)
	{
	}

	private static void MakeButtonFlexible(Button _button, float _minimumWidth)
	{
	}

	private GameObject CreateCard(string _objectName, Transform _parent, CardKind _kind)
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

	private GameObject CreateColumn(string _objectName, Transform _parent, float _spacing)
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

	private Button CreateButton(string _objectName, Transform _parent, out TextMeshProUGUI _textComponent, string _text, float _width, float _height)
	{
		_textComponent = null;
		return null;
	}

	private DropdownInfo CreateDropdown(string _objectName, Transform _parent, string _labelLocalizationKey, float _width, float _dropdownHeight, bool _showLabel)
	{
		return null;
	}

	private Button GetOrFindActionButtonPrefab()
	{
		return null;
	}

	private static void ConfigureRoundedRectangle(MPImage _image, Color _fillColor, float _cornerRadius, float _outlineWidth, Color _outlineColor, bool _raycastTarget)
	{
	}

	private void ConfigurePanelShadow()
	{
	}

	private static void ClearChildren(Transform _root)
	{
	}

	private static void BuildEmptyText(Transform _parent, string _localizationKey)
	{
	}

	private static LayoutElement GetOrAddLayoutElement(GameObject _target)
	{
		return null;
	}

	private static void ApplyCurrentFontToAllTexts(Transform _root)
	{
	}

	private void SetStatus(string _localizationKey, params object[] _arguments)
	{
	}

	private void ClearStatus()
	{
	}

	private static bool IsCharacterAvailable(Character _character, State _state)
	{
		return false;
	}

	private static bool IsStateAvailable(State _state)
	{
		return false;
	}

	private static bool HasAnyFamily(State _state)
	{
		return false;
	}

	private static string T(string _localizationKey)
	{
		return null;
	}
}
