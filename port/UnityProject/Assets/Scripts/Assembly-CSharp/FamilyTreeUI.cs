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

public class FamilyTreeUI : BasePanelUI
{
	private class LineConnection
	{
		public enum LineType
		{
			Parent = 0,
			Child = 1,
			Spouse = 2
		}

		public List<MPImage> segments;

		public FamilyTreeNode startNode;

		public FamilyTreeNode endNode;

		public LineType type;

		public Vector3 lastStartPos;

		public Vector3 lastEndPos;
	}

	private enum FamilyActionType
	{
		PromoteToPatriarch = 0,
		SetHeir = 1,
		SetAge = 2,
		AddSpouse = 3,
		AddChild = 4,
		Divorce = 5,
		DeleteCharacter = 6,
		KillCharacter = 7
	}

	[CompilerGenerated]
	private sealed class _003CSyncSetAgeInputWidthNextFrame_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FamilyTreeUI _003C_003E4__this;

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
		public _003CSyncSetAgeInputWidthNextFrame_003Ed__116(int _003C_003E1__state)
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
	private sealed class _003CRefreshListLayoutAfterFrames_003Ed__136 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FamilyTreeUI _003C_003E4__this;

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
		public _003CRefreshListLayoutAfterFrames_003Ed__136(int _003C_003E1__state)
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
	private sealed class _003CUpdateVisibility_003Ed__171 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FamilyTreeUI _003C_003E4__this;

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
		public _003CUpdateVisibility_003Ed__171(int _003C_003E1__state)
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

	private static FamilyTreeUI s_Instance;

	[Header("UI References")]
	[SerializeField]
	private RectTransform m_TreeContainer;

	[SerializeField]
	private RectTransform m_ViewportMask;

	[SerializeField]
	private Transform m_NodesContainer;

	[SerializeField]
	private Transform m_LinesContainer;

	[SerializeField]
	private Transform m_FamilyListContainer;

	[SerializeField]
	private Transform m_CollateralListContainer;

	[SerializeField]
	private Transform m_ActionButtonContainer;

	[SerializeField]
	private Toggle m_LayoutToggle;

	[SerializeField]
	private SinglePanel m_InfoPanel;

	[SerializeField]
	[Header("Prefabs")]
	private GameObject m_NodePrefab;

	[SerializeField]
	private GameObject m_ActionButtonPrefab;

	[Header("Layout Settings")]
	private float m_NodeWidth;

	private float m_NodeHeight;

	private float m_HorizontalSpacing;

	private float m_VerticalSpacing;

	[SerializeField]
	private bool m_DefaultHorizontalLayout;

	private const int c_MaxGenerations = 4;

	private const string c_GenerateNewSpouseItemKey = "__GenerateNewSpouse__";

	private const string c_BackToFamilySelectItemKey = "__BackToFamilySelect__";

	private const string c_GenerateNewSpouseRandomTextKey = "FamilyTreeGenerateNewSpouseRandom";

	private const string c_BackToFamilyListTextKey = "FamilyTreeBackToFamilyList";

	private const string c_MarriageableValueTextKey = "FamilyTreeMarriageableValue";

	private const string c_TooltipRelationThemToYouKey = "FamilyTreeTooltipRelationThemToYou";

	private const string c_TooltipRelationYouToThemKey = "FamilyTreeTooltipRelationYouToThem";

	private const string c_TooltipRelationToRulingFamilyWithTargetKey = "FamilyTreeTooltipRelationToRulingFamilyWithTarget";

	private const string c_TooltipRulingFamilyIsSelfKey = "FamilyTreeTooltipRulingFamilyIsSelf";

	private const string c_AgeYearsOldTextKey = "FamilyTreeAgeYearsOld";

	private const string c_ConfirmDivorceTitleKey = "FamilyTreeConfirmDivorce";

	private const string c_ConfirmDivorceDetailTitleKey = "FamilyTreeConfirmDivorceDetail";

	private const string c_ConfirmKillCharacterTitleKey = "FamilyTreeConfirmKillCharacter";

	private const string c_ConfirmDeleteCharacterTitleKey = "FamilyTreeConfirmDeleteCharacter";

	private const string c_ConfirmYesKey = "Yes";

	private const string c_ConfirmNoKey = "No";

	private const string c_SetAgePlaceholderKey = "FamilyTreeSetAgePlaceholder";

	private const string c_SetAgeInvalidInputKey = "FamilyTreeSetAgeInvalidInput";

	private const string c_SetAgeOutOfRangeKey = "FamilyTreeSetAgeOutOfRange";

	private const int c_SetAgeMinYears = 0;

	private const int c_SetAgeMaxYears = 200;

	private const string c_SetAgeInputPrefabResourcesPath = "Prefab/AddItemUIPrefab";

	[SerializeField]
	[Header("Interaction Settings")]
	private float m_MinZoom;

	[SerializeField]
	private float m_MaxZoom;

	[SerializeField]
	private float m_ZoomSpeed;

	[SerializeField]
	private float m_DragSensitivity;

	[SerializeField]
	private float m_DefaultZoom;

	[SerializeField]
	[Header("Performance Settings")]
	private int m_MaxVisibleNodes;

	[SerializeField]
	private float m_CullDistance;

	[SerializeField]
	private int m_NodePoolSize;

	[SerializeField]
	private int m_MPImagePoolSize;

	[SerializeField]
	private float m_UpdateInterval;

	[SerializeField]
	private int m_ListItemPoolSize;

	[SerializeField]
	[Header("Line Style Settings")]
	private float m_ParentLineWidth;

	[SerializeField]
	private float m_SpouseLineWidth;

	[SerializeField]
	private Color m_ParentLineColor;

	[SerializeField]
	private Color m_SpouseLineColor;

	[SerializeField]
	[Header("Node Color Settings")]
	private Color m_MaleNodeColor;

	[SerializeField]
	private Color m_FemaleNodeColor;

	[SerializeField]
	private Color m_DeadMaleNodeColor;

	[SerializeField]
	private Color m_DeadFemaleNodeColor;

	[SerializeField]
	private Color m_SelectedNodeColor;

	private Family m_CurrentFamily;

	private int m_CurrentFamilyId;

	private FamilyTreeLayoutManager m_LayoutManager;

	private Dictionary<int, FamilyTreeNode> m_NodeMap;

	private List<LineConnection> m_Lines;

	private Queue<GameObject> m_NodePool;

	private Queue<MPImage> m_MPImagePool;

	private Queue<SinglePanel> m_ListItemPool;

	private List<SinglePanel> m_ActiveFamilyListItems;

	private List<SinglePanel> m_ActiveCollateralListItems;

	private readonly List<int> m_IsolatedMemberIds;

	private float m_CurrentZoom;

	private Vector2 m_TreePosition;

	private bool m_IsDragging;

	private Vector2 m_LastMousePosition;

	private float m_LastUpdateTime;

	private Coroutine m_UpdateCoroutine;

	private Coroutine m_ListLayoutRefreshCoroutine;

	private int m_SelectedCharacterId;

	private bool m_IsUsingCustomRoot;

	private int m_CustomRootCharacterId;

	private FamilyTreeNode m_HighlightedNode;

	private readonly Dictionary<FamilyActionType, Button> m_ActionButtons;

	[Header("Age Edit UI")]
	[SerializeField]
	private Transform m_SetAgeInputContainer;

	[SerializeField]
	private GameObject m_SetAgeInputPrefab;

	private AddItemUIComponent m_SetAgeInputUI;

	private TMP_InputField m_SetAgeInputField;

	private GameObject m_SetAgeInputInstance;

	public static FamilyTreeUI Instance => null;

	private static string T(string _key)
	{
		return null;
	}

	protected override void Awake()
	{
	}

	protected override void OnPanelInitialize()
	{
	}

	private void InitializePanel()
	{
	}

	private void InitializeObjectPools()
	{
	}

	private MPImage CreateMPImageSegment()
	{
		return null;
	}

	private SinglePanel CreateListItemPanel()
	{
		return null;
	}

	private void SetupButtonListeners()
	{
	}

	private void InitializeActionButtons()
	{
	}

	private bool EnsureActionButtonDependencies()
	{
		return false;
	}

	private void OnActionButtonClicked(FamilyActionType actionType)
	{
	}

	private string BuildDivorceConfirmTitle(Character _character)
	{
		return null;
	}

	private string GetCharacterFamilyName(Character _character)
	{
		return null;
	}

	private string GetCharacterStateName(Character _character)
	{
		return null;
	}

	private static bool IsZeroColor(Color _color)
	{
		return false;
	}

	private static string WrapWithMarkTag(string _text, Color _color)
	{
		return null;
	}

	private static string SanitizeForRichText(string _text)
	{
		return null;
	}

	private void ShowConfirmWarningWithActionKey(string _titleKey, Action _onConfirmed)
	{
	}

	private void ShowConfirmWarningWithActionCustomTitle(string _customTitle, Action _onConfirmed)
	{
	}

	private void ShowConfirmWarningWithActionInternal(string _titleContent, bool _isCustomTitle, Action _onConfirmed)
	{
	}

	private void SetSelectedCharacter(int characterId)
	{
	}

	private Character GetSelectedCharacter()
	{
		return null;
	}

	private void UpdateActionButtonsState()
	{
	}

	private void InitializeSetAgeInputUI()
	{
	}

	[IteratorStateMachine(typeof(_003CSyncSetAgeInputWidthNextFrame_003Ed__116))]
	private IEnumerator SyncSetAgeInputWidthNextFrame()
	{
		return null;
	}

	private void SyncSetAgeInputWidthToActionButtons()
	{
	}

	private void SyncSetAgeInputFieldWidth(float _targetTotalWidth)
	{
	}

	private float GetReferenceActionButtonWidth()
	{
		return 0f;
	}

	private bool EnsureSetAgeInputDependencies()
	{
		return false;
	}

	private void ToggleSetAgeInputUI()
	{
	}

	private void ShowSetAgeInputUIForSelection()
	{
	}

	private void HideSetAgeInputUI()
	{
	}

	private void RefreshSetAgeInputUIForSelection()
	{
	}

	private void RefreshSetAgeInputUIText()
	{
	}

	private void HandleSetAgeInputSubmitted(string _inputText)
	{
	}

	private double GetBirthTimeFromExactAgeYears(int _desiredAgeYears)
	{
		return 0.0;
	}

	private void ShowSetAgeWarning(string _titleKey)
	{
	}

	private void SetActionButtonInteractable(FamilyActionType actionType, bool interactable)
	{
	}

	private bool IsSelectedCharacterValid()
	{
		return false;
	}

	private void RefreshSelectionHighlight()
	{
	}

	public void Display(int familyId)
	{
	}

	private void PopulateFamilyList()
	{
	}

	private void PopulateCollateralList()
	{
	}

	private void RequestListLayoutRefresh()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshListLayoutAfterFrames_003Ed__136))]
	private IEnumerator RefreshListLayoutAfterFrames()
	{
		return null;
	}

	private void UpdateIsolatedMembersFromLayout()
	{
	}

	private int CalculateGeneration(Character character)
	{
		return 0;
	}

	private SinglePanel GetListItemFromPool()
	{
		return null;
	}

	private void OnFamilyListItemClicked(int familyId)
	{
	}

	private void OnCollateralItemClicked(int memberId)
	{
	}

	private void BuildFamilyTree()
	{
	}

	private Character FindRootCharacter()
	{
		return null;
	}

	private void LogLayoutData()
	{
	}

	private void CreateNodesAndLines()
	{
	}

	private void CreateNode(Character character, Vector2 position)
	{
	}

	private void CreateAllLines()
	{
	}

	private void CreateParentChildConnection(Vector3 parentPos, FamilyTreeNode childNode)
	{
	}

	private void CreateParentToSiblingsMainLine(Vector3 parentMidPoint, Vector3 siblingsLineMidPoint)
	{
	}

	private void CreateSiblingsHorizontalLine(Vector3 leftPoint, Vector3 rightPoint)
	{
	}

	private void CreateChildToHorizontalLine(Vector3 horizontalLinePoint, Vector3 childPos)
	{
	}

	private void CreateLinesFromJSConnectors(List<(Vector2 start, Vector2 end, RelType type)> connectors)
	{
	}

	private void CreateLine(FamilyTreeNode startNode, FamilyTreeNode endNode, LineConnection.LineType lineType)
	{
	}

	private void ConfigureMPImageStyle(MPImage mpImage, LineConnection.LineType lineType)
	{
	}

	private GameObject GetNodeFromPool()
	{
		return null;
	}

	private MPImage GetMPImageFromPool()
	{
		return null;
	}

	private void ReturnNodeToPool(GameObject node)
	{
	}

	private void ReturnMPImageToPool(MPImage mpImage)
	{
	}

	private void ClearTree()
	{
	}

	private void ClearLists()
	{
	}

	protected override void Update()
	{
	}

	private void HandleInput()
	{
	}

	private void HandleMouseScroll()
	{
	}

	private bool IsMouseOverScrollView()
	{
		return false;
	}

	private void HandleDragging()
	{
	}

	private void SetZoom(float zoom)
	{
	}

	private void OnZoomIn()
	{
	}

	private void OnZoomOut()
	{
	}

	private void OnResetView()
	{
	}

	private void OnLayoutToggleChanged(bool isHorizontal)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateVisibility_003Ed__171))]
	private IEnumerator UpdateVisibility()
	{
		return null;
	}

	private void UpdateLinePosition(LineConnection connection)
	{
	}

	private void UpdateStraightLine(MPImage segment, Vector3 startPos, Vector3 endPos)
	{
	}

	private void UpdateElbowLine(List<MPImage> segments, Vector3 startPos, Vector3 endPos)
	{
	}

	private void UpdateLineSegment(MPImage segment, Vector3 start, Vector3 end, bool isVertical)
	{
	}

	private Rect GetViewportRect()
	{
		return default;
	}

	private bool IsNodeInViewport(FamilyTreeNode node, Rect viewportRect)
	{
		return false;
	}

	public void OnNodeClicked(FamilyTreeNode node)
	{
	}

	public void HandleDeleteCharacterRequest(int characterId)
	{
	}

	private int FindReplacementRootForDeletedCustomRoot(Character deletedCharacter)
	{
		return 0;
	}

	private bool IsValidCustomRootCandidate(int candidateId)
	{
		return false;
	}

	public void HandleKillCharacterRequest(int characterId)
	{
	}

	public void HandlePromoteToPatriarchRequest(int characterId)
	{
	}

	public void HandleSetHeirRequest(int characterId)
	{
	}

	public void HandleDivorceRequest(int characterId)
	{
	}

	public void HandleAddSpouseRequest(int characterId)
	{
	}

	private void ShowSpouseFamilySelection(Character _targetCharacter, Family _currentFamily)
	{
	}

	private string BuildMarriageFamilyTooltip(Character _targetCharacter, Family _currentFamily, Family _candidateFamily, int _marriageableCount)
	{
		return null;
	}

	private string GetLocalizedCultureName(string _cultureName)
	{
		return null;
	}

	private string GetLocalizedReligionName(string _religionId)
	{
		return null;
	}

	private void ShowSpouseCandidateSelection(Character _targetCharacter, Family _currentFamily, Family _selectedFamily)
	{
	}

	private void AddGeneratedSpouse(Character _targetCharacter, Family _family)
	{
	}

	private List<Character> GetMarriageableCandidatesFromFamily(Character _targetCharacter, Family _family)
	{
		return null;
	}

	private string GetMarriageCandidateDisplayText(Character _candidate, Family _family)
	{
		return null;
	}

	private void EnsureSpouseRoles(Character _character1, Character _character2)
	{
	}

	private void EnsureSpouseRoleForCharacter(Character _holder, Character _spouse)
	{
	}

	private void EnsureSelectContainerPanelVisible()
	{
	}

	public void HandleAddChildRequest(int characterId)
	{
	}

	private bool TryGetEditableFamilyCharacter(int characterId, bool requireAlive, out Character character, out Family family)
	{
		character = null;
		family = null;
		return false;
	}

	private Character CreateGeneratedSpouse(Character character, Family family)
	{
		return null;
	}

	private MarriageType DetermineManualMarriageType(Character character, Family family)
	{
		return MarriageType.Patrilineal;
	}

	private Character CreateGeneratedChild(Character father, Character mother, Family childFamily)
	{
		return null;
	}

	private Family DetermineChildFamily(Character father, Character mother, Family fallbackFamily)
	{
		return null;
	}

	private void RemoveSpouseRoles(Character character, int spouseId)
	{
	}

	private void RefreshFamilyTreeAfterDataChange()
	{
	}

	private void RecordManualBirthEvent(Character child, Character father, Character mother, Family family)
	{
	}

	private void RestoreCharacterToOriginalFamily(Character person)
	{
	}

	private void ApplyInheritedAttributes(Character child, Character father, Character mother)
	{
	}

	private float CalculateInheritedAttribute(float fatherValue, float motherValue)
	{
		return 0f;
	}

	private void ApplyInheritedTraits(Character child, Character father, Character mother)
	{
	}

	private void TryInheritTraits(Character child, Character parent)
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

	private void OnDestroy()
	{
	}
}
