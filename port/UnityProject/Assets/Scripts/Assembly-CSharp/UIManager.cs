using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Michsky.MUIP;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

internal class UIManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CEnableEditPanel_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

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
		public _003CEnableEditPanel_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CFadeCanvasGroup_003Ed__165 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CanvasGroup cg;

		public float start;

		public float end;

		public UIManager _003C_003E4__this;

		public Action action;

		private float _003CelapsedTime_003E5__2;

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
		public _003CFadeCanvasGroup_003Ed__165(int _003C_003E1__state)
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
	private sealed class _003CRefreshBottomUI_003Ed__166 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

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
		public _003CRefreshBottomUI_003Ed__166(int _003C_003E1__state)
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
	private sealed class _003CRefreshUIAfterFrame_003Ed__168 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<GameObject> gameObjects;

		private List<GameObject> _003CgameObjectsActive_003E5__2;

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
		public _003CRefreshUIAfterFrame_003Ed__168(int _003C_003E1__state)
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
	private sealed class _003CRefreshLayoutAfterFrame_003Ed__174 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RectTransform rectTransform;

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
		public _003CRefreshLayoutAfterFrame_003Ed__174(int _003C_003E1__state)
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
	private sealed class _003CRefreshLayoutAfterFrameRecursive_003Ed__175 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RectTransform rectTransform;

		public UIManager _003C_003E4__this;

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
		public _003CRefreshLayoutAfterFrameRecursive_003Ed__175(int _003C_003E1__state)
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

	private const float c_InitializedPanelCanvasAlpha = 1E-06f;

	private const float c_FamilyPanelInitialSideMargin = 20f;

	[Header("Basic UI Prefabs")]
	public GameObject InfoRowPrefab;

	public GameObject DropDownInfoPrefab;

	public GameObject SinglePanelPrefab;

	public GameObject TraitButtonPrefab;

	public GameObject SliderWithLabelPrefab;

	public GameObject CollapsibleSectionPrefab;

	[Header("Panel Prefabs")]
	public GameObject FamilyPanelUIPrefab;

	public GameObject CharacterPanelUIPrefab;

	public GameObject FamilyTreeUIPrefab;

	public GameObject HistoryTimelineUIPrefab;

	public GameObject HistoryInfoPanelPrefab;

	public GameObject ProvinceInfoPanelPrefab;

	public GameObject AreaInfoPanelPrefab;

	public GameObject SelectUIPrefab;

	public GameObject StateCustomNamingPanelPrefab;

	public CanvasGroup displayPanel;

	public CanvasGroup diplomacyPanel;

	public CanvasGroup LanguageChoosePanel;

	public CanvasGroup WallPaperPanel;

	public CanvasGroup histroryPanel;

	public CanvasGroup newSaveSlotPanel;

	public CanvasGroup rightClickPanel;

	public CanvasGroup ColorPickerPanel;

	public CanvasGroup DescriptionPanel;

	public CanvasGroup SelectCultureToEditPanel;

	public CanvasGroup StateInfoPanel;

	public CanvasGroup StatisticsInfoPanel;

	public CanvasGroup DouyinSidePanel;

	public GameObject DouyinGiftPanel;

	public GameObject DouyinControlPanel;

	public GameObject DouyinBottomPanel;

	public CanvasGroup AnnounceMentPanel;

	public CanvasGroup GenerateMapWarningPanel;

	public CanvasGroup LoadSaveOrUploadToWorkShopPanel;

	public ButtonManager ModifyMapButton;

	public CanvasGroup ThanksPanel;

	public CanvasGroup UpdatePanel;

	public CanvasGroup LoadSaveDataPanel;

	public CanvasGroup SelectContainerPanel;

	public CanvasGroup ProvinceInfoPanel;

	public CanvasGroup CultureSetWorkshopPanel;

	public CanvasGroup ReligionSetWorkshopPanel;

	public CanvasGroup WorkshopPanel;

	public CanvasGroup EditStateDescriptionPanel;

	public CanvasGroup EditHeightMapDescriptionPanel;

	public CanvasGroup TipsPanel;

	public CanvasGroup RoadMapPanel;

	public CanvasGroup DeleteSaveWarningPanel;

	public CanvasGroup RegenerateBiomWarningPanel;

	public CanvasGroup WorkshopItemContentPanel;

	public CanvasGroup TimeShowPanel;

	public CanvasGroup ImportHeightMapPanel;

	public CanvasGroup RefreshRiverWarningPanel;

	public CanvasGroup DouyinAnnoucementPanel;

	public CanvasGroup RegenerateStateWarningPanel;

	public CanvasGroup DouyinStartGamePanel;

	public CanvasGroup ErrorToDownloadVCredistPanel;

	public CanvasGroup DouyinHelper;

	public CanvasGroup TooltipsText;

	public CanvasGroup MapCulturePanel;

	public CanvasGroup TooltipsPanel;

	[Header("Tooltip System")]
	[SerializeField]
	private List<GraphicRaycaster> m_TooltipRaycasters;

	private const string c_TooltipCanvasName = "Canvas";

	public CanvasGroup ExitWallpaperPanel;

	public CanvasGroup CultureInfoUIPanel;

	public CanvasGroup ScreenshotPanel;

	public CanvasGroup HistoryExportPanel;

	public TextMeshProUGUI titleText;

	public ButtonManager WallpaperScreenButton1;

	public ButtonManager WallpaperScreenButton2;

	public ButtonManager WallpaperScreenButton3;

	public CanvasGroup EditPanel;

	public CanvasGroup SettingPanel;

	private float fadeDuration;

	private static UIManager instance;

	private readonly List<RaycastResult> m_TooltipRaycastResults;

	private PointerEventData m_TooltipPointerEventData;

	private EventSystem m_TooltipEventSystem;

	private ITooltipProvider m_CurrentTooltipProvider;

	private TooltipContent m_CurrentTooltipContent;

	public CanvasGroup RoundResultPanel;

	public CanvasGroup AreaInfoPanel;

	public LocalizationTextWithAdditionalText NonInteractModeText;

	public Slider NonInteractModeSlider;

	public GameObject rootCanvas;

	internal bool IsShowDouyinAnnoucement;

	private Dictionary<string, UserData> userData;

	private List<UserRoundData> userResults;

	public CanvasGroup RegenerateProvinceWarningPanel;

	public CanvasGroup EditSuggestionPanel;

	public static UIManager Instance => null;

	private void Start()
	{
	}

	public static void ApplyFamilyPanelInitialPosition(RectTransform _panelRectTransform)
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableEditPanel_003Ed__76))]
	public IEnumerator EnableEditPanel()
	{
		return null;
	}

	public void OnSelectCultureToEditPanelButtonClicked(string cultureName, bool isEnabled)
	{
	}

	public void OnMapCulturePanelButtonClicked(string cultureName)
	{
	}

	public void OnSelectContainerPanelButtonClicked()
	{
	}

	public void OnExitWallpaperPanelButtonClicked()
	{
	}

	public void OnDouyinAnnoucementPanelButtonClicked()
	{
	}

	private void BringPanelToFront(CanvasGroup panel)
	{
	}

	public void OnTooltipsPanelButtonClicked(string tooltipsContent, UnityAction action)
	{
	}

	public void OnUpdatePanelButtonClicked()
	{
	}

	public void OnDouyinStartGamePanelButtonClicked()
	{
	}

	public void OnDouyinHelperPanelButtonClicked()
	{
	}

	public void OnImportHeightMapPanelButtonClicked()
	{
	}

	public void OnRefreshRiverWarningPanelButtonClicked()
	{
	}

	public void ShowTimeDisplayPanel(bool IsEnable)
	{
	}

	public void OnRoadMapPanelButtonClicked()
	{
	}

	public void OnTipsPanelButtonClicked()
	{
	}

	public void OnEditStatePanelDescriptionButtonClicked()
	{
	}

	public void OnEditHeightMapDescriptionPanelButtonClicked()
	{
	}

	public void OnWorkshopPanelButtonClicked()
	{
	}

	public void OnWorkshopItemContentPanelButtonClicked()
	{
	}

	public void OnDeleteSaveWarningPanelClicked()
	{
	}

	public void OnRegenerateBiomWarningPanelClicked()
	{
	}

	public void OnRegenerateProvinceWarningPanelClicked()
	{
	}

	private void Awake()
	{
	}

	private void LoadUIPrefabs()
	{
	}

	private void ValidatePrefabLoading()
	{
	}

	private void InitializeUIPanels()
	{
	}

	private void InitializeWorkshopItemContentPanel(Transform canvasTransform)
	{
	}

	private void InitializeUnifiedWorkshopItemContentPanel(Transform canvasTransform)
	{
	}

	private CanvasGroup SetPanelCanvasGroupAlpha(GameObject panelObject)
	{
		return null;
	}

	public void OnAreaInfoPanelButtonClicked(int stateID)
	{
	}

	public void OnDisplayPanelButtonClicked()
	{
	}

	public void OnEditPanelButtonClicked()
	{
	}

	public void OpenEditPanelToGlobalCommands()
	{
	}

	public void OnDiplomacyPanelButtonClicked()
	{
	}

	public void OnCultureSetPanelWorkshopButtonClicked()
	{
	}

	public void OnReligionSetPanelWorkshopButtonClicked()
	{
	}

	public void OnDescriptionPanelButtonClicked()
	{
	}

	public void OnLanguageChoosePanelButtonClicked()
	{
	}

	public void OnWallPaperPanelButtonClicked()
	{
	}

	public void OnWallPaperScreenButtonSelection(int index)
	{
	}

	public void OnHistoryPanelButtonClicked()
	{
	}

	public void OnHistoryTimelineButtonClicked()
	{
	}

	public void OnSettingPanelButtonClicked()
	{
	}

	public void OnMouseRightButtonClicked()
	{
	}

	public void ShowRightClickMenu(bool isDisplay)
	{
	}

	public void OnColorPickerPanelButtonClicked()
	{
	}

	public void OnAnnoucementPanelButtonClicked()
	{
	}

	public void OnThanksPanelButtonClicked()
	{
	}

	public void OnGenerateMapWarningPanelTriggered(UnityAction action)
	{
	}

	public void OnLoadSaveOrUploadToWorkShopPanelButtonClicked()
	{
	}

	public static void OpenWorkshopPage()
	{
	}

	public void OnGenerateMapWarningPanelClosed()
	{
	}

	public void OnLoadSaveDataPanelButtonClicked()
	{
	}

	public void OnWorkShopDataPanelButtonClicked()
	{
	}

	public void OnNewSaveSlotButtonClicked()
	{
	}

	public void OnSaveDataPanelButtonClicked()
	{
	}

	public void OnAddToWishListButtonClicked()
	{
	}

	public void OnStateInfoPanelButtonClicked(int stateID)
	{
	}

	public void OnStateInfoPanelButtonClose()
	{
	}

	public void OnStatisticsInfoPanelButtonClicked()
	{
	}

	public void OnStatisticsPanelButtonClose()
	{
	}

	public void OnStatelineColorValueChanged(Color color)
	{
	}

	public void OnProvinceBorderColorValueChanged(Color color)
	{
	}

	public void OnCoastlineColorValueChanged(Color color)
	{
	}

	public void OnStateNameColorValueChanged(Color color)
	{
	}

	public void OnShallowWaterColorValueChanged(Color color)
	{
	}

	public void OnDeepWaterColorValueChanged(Color color)
	{
	}

	public void OnSeaRouteWaterColorValueChanged(Color color)
	{
	}

	public void OnRegerateStateWarningPanelClicked()
	{
	}

	public void OnBorderWidthValueChanged(float value)
	{
	}

	public void OnNonInteractModeSliderValueChanged(float value)
	{
	}

	public Coroutine FadeIn(CanvasGroup canvasGroup, Action action = null)
	{
		return null;
	}

	public Coroutine FadeOut(CanvasGroup canvasGroup, Action action = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeCanvasGroup_003Ed__165))]
	private IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float fadeDuratio, Action action = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRefreshBottomUI_003Ed__166))]
	private IEnumerator RefreshBottomUI()
	{
		return null;
	}

	public void RefreshUI()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshUIAfterFrame_003Ed__168))]
	public IEnumerator RefreshUIAfterFrame(List<GameObject> gameObjects)
	{
		return null;
	}

	public void RefreshLayout(RectTransform rectTransform)
	{
	}

	public void RefreshLayoutRecursively(RectTransform rectTransform)
	{
	}

	public void RefreshAllUILayout()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshLayoutAfterFrame_003Ed__174))]
	private IEnumerator RefreshLayoutAfterFrame(RectTransform rectTransform)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRefreshLayoutAfterFrameRecursive_003Ed__175))]
	private IEnumerator RefreshLayoutAfterFrameRecursive(RectTransform rectTransform)
	{
		return null;
	}

	private void RefreshLayoutRecursive(RectTransform rectTransform)
	{
	}

	public void EnableBottomPanel(bool isEnabled)
	{
	}

	public void EnableDouyinMode(bool isEnabled)
	{
	}

	internal void OnAreaInfoPanelButtonClose()
	{
	}

	public void OnRoundResultPanelButtonClicked()
	{
	}

	internal void ShowRoundResult(Dictionary<string, UserData> userData, List<UserRoundData> userResults)
	{
	}

	public void EnableTooltip(bool isEnabled, string content, GameObject uiObject = null, bool isKey = true)
	{
	}

	private void InitializeTooltipSystem()
	{
	}

	private void TryAttachCanvasRaycasters()
	{
	}

	public void RegisterTooltipRaycaster(GraphicRaycaster raycaster)
	{
	}

	public void UnregisterTooltipRaycaster(GraphicRaycaster raycaster)
	{
	}

	private void UpdateTooltipHover()
	{
	}

	private static ITooltipProvider FindTooltipProvider(GameObject target)
	{
		return null;
	}

	private void ShowTooltip(ITooltipProvider provider, TooltipContent content)
	{
	}

	private bool TooltipContentEquals(TooltipContent a, TooltipContent b)
	{
		return false;
	}

	private void ClearActiveTooltip()
	{
	}

	private void ValidateActiveTooltipProvider()
	{
	}

	public void OnEditSuggestionPanelButtonClicked()
	{
	}

	public void OnCultureInfoUIPanelButtonClicked(string cultureName, bool isShowPanel = true)
	{
	}

	public void OnCultureInfoUIPanelButtonClose()
	{
	}

	public void OnScreenshotPanelButtonClose()
	{
	}

	public void OnScreenshotPanelButtonClicked()
	{
	}

	public void OnHistoryExportPanelButtonClicked()
	{
	}

	public void OnErrorToDownloadVCredistPanelButtonClicked()
	{
	}
}
