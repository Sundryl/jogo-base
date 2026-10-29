using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MPUIKIT;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ReligionInfoUI : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	public enum DisplayMode
	{
		BasicInfo = 0,
		Practices = 1,
		ReligionSets = 2
	}

	[CompilerGenerated]
	private sealed class _003CBatchTranslatePractices_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<string> _practiceNames;

		public List<string> _practiceKeys;

		public ReligionInfoUI _003C_003E4__this;

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
		public _003CBatchTranslatePractices_003Ed__68(int _003C_003E1__state)
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
	private sealed class _003CProcessTranslateReligionName_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReligionInfoUI _003C_003E4__this;

		public string _sourceReligionName;

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
		public _003CProcessTranslateReligionName_003Ed__71(int _003C_003E1__state)
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
	private sealed class _003CProcessTranslateReligionDescription_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReligionInfoUI _003C_003E4__this;

		public string _sourceReligionDescription;

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
		public _003CProcessTranslateReligionDescription_003Ed__72(int _003C_003E1__state)
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
	private sealed class _003CProcessTranslateReligionHolyBook_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReligionInfoUI _003C_003E4__this;

		public string _sourceReligionHolyBook;

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
		public _003CProcessTranslateReligionHolyBook_003Ed__73(int _003C_003E1__state)
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

	[SerializeField]
	[Header("基本信息面板组件")]
	private TMP_InputField m_ReligionNameInput;

	[SerializeField]
	private TMP_InputField m_ReligionDescriptionInput;

	[SerializeField]
	private TMP_InputField m_ReligionHolyBookInput;

	[SerializeField]
	private TMP_InputField m_ColorInput;

	[SerializeField]
	private MPImage m_ReligionColorImage;

	[SerializeField]
	private DropdownInfo m_HolyProvinceDropdown;

	[SerializeField]
	[Header("语言设置")]
	private DropdownInfo m_LanguageDropdown;

	[SerializeField]
	private GameObject m_LanguagePanel;

	[SerializeField]
	private Button m_TranslateCurrentPageButton;

	[SerializeField]
	private TranslationUIPanel m_TranslationUIPanel;

	[Header("标签按钮")]
	public LocalizationTmpButtonWithImage basicInfoTabButton;

	public LocalizationTmpButtonWithImage m_PracticesTabButton;

	public LocalizationTmpButtonWithImage m_ReligionSetsTabButton;

	[Header("标签面板")]
	public GameObject basicInfoPanel;

	public GameObject listPanel;

	public GameObject religionSetsPanel;

	[SerializeField]
	[Header("列表UI组件")]
	private GameObject m_ListItemPrefab;

	[SerializeField]
	private Transform m_ListItemContainer;

	[SerializeField]
	private PaginationComponent m_PaginationComponent;

	[SerializeField]
	private AddItemUIComponent m_AddItemUI;

	[Header("宗教集面板组件")]
	[SerializeField]
	private Button m_ExportReligionButton;

	[SerializeField]
	private Button m_CreateNewReligionSetButton;

	[SerializeField]
	private TMP_InputField m_NewReligionSetNameInput;

	[SerializeField]
	private TMP_InputField m_CurrentReligionSetInput;

	[SerializeField]
	private DropdownInfo m_TargetReligionSetDropdown;

	[SerializeField]
	private GameObject m_AddNewSetPanel;

	[SerializeField]
	private TextMeshProUGUI m_AddNewReligionSetLabel;

	[Header("其它组件")]
	[SerializeField]
	private Button m_ClosePanelButton;

	[HideInInspector]
	public MapReligion m_CurrentReligion;

	private string m_CurrentDisplayLanguage;

	private float m_LastUpdateTime;

	private DisplayMode m_CurrentDisplayMode;

	private LocalizationTmpButtonWithImage m_CurrentSelectedTab;

	private List<GameObject> m_ListItems;

	private List<GameObject> m_ReligionSetItems;

	private ReligionSet m_CurrentSelectedReligionSet;

	private ReligionSet m_CurrentReligionBelongingSet;

	private List<ReligionSet> m_VirtualReligionSets;

	private static ReligionInfoUI s_Instance;

	public static ReligionInfoUI Instance => null;

	public void RefreshLocalization()
	{
	}

	private void HandleHolyProvinceChanged(MapReligion religion)
	{
	}

	private void RefreshLayout()
	{
	}

	private void Start()
	{
	}

	private void SetupInputFieldListeners()
	{
	}

	private void InitializeLanguageDropdown()
	{
	}

	private void OnLanguageDropdownValueChanged(int _index)
	{
	}

	private void SaveCurrentLanguageInputsToCache(string _language)
	{
	}

	private void SaveCurrentLanguagePracticesInputsToCache(string _language)
	{
	}

	private void LoadLanguageInputsFromCache(string _language)
	{
	}

	private void LoadBasicInfoInputsFromCache(string _language)
	{
	}

	private void UpdateInputFieldLanguageSettings()
	{
	}

	private void RefreshCurrentTabDisplay()
	{
	}

	private void OnDestroy()
	{
	}

	private void SetupTabButtons()
	{
	}

	public void OnTabButtonClicked(LocalizationTmpButtonWithImage clickedTab)
	{
	}

	private void SelectTab(LocalizationTmpButtonWithImage tabToSelect)
	{
	}

	private void ShowTabPanel(LocalizationTmpButtonWithImage selectedTab)
	{
	}

	private void UpdateBasicInfoPanel()
	{
	}

	private void OnReligionNameChanged(string _newName)
	{
	}

	private void OnReligionDescriptionChanged(string _newDescription)
	{
	}

	private void OnReligionHolyBookChanged(string _newHolyBookName)
	{
	}

	private void OnColorInputChanged(string _hex)
	{
	}

	public void OnTranslateCurrentPageButtonClicked()
	{
	}

	public void AutoTranslateReligionInfo(bool _translateAll = false)
	{
	}

	private void TranslateCurrentPagePractices(string _sourceLanguage)
	{
	}

	[IteratorStateMachine(typeof(_003CBatchTranslatePractices_003Ed__68))]
	private IEnumerator BatchTranslatePractices(List<string> _practiceKeys, List<string> _practiceNames, string _sourceLanguage)
	{
		return null;
	}

	private void TranslateAllPractices(string _sourceLanguage)
	{
	}

	private void TranslateReligionBasicInfo(string _sourceLanguage)
	{
	}

	[IteratorStateMachine(typeof(_003CProcessTranslateReligionName_003Ed__71))]
	private IEnumerator ProcessTranslateReligionName(string _sourceReligionName, string _sourceLanguage)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessTranslateReligionDescription_003Ed__72))]
	private IEnumerator ProcessTranslateReligionDescription(string _sourceReligionDescription, string _sourceLanguage)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessTranslateReligionHolyBook_003Ed__73))]
	private IEnumerator ProcessTranslateReligionHolyBook(string _sourceReligionHolyBook, string _sourceLanguage)
	{
		return null;
	}

	private string ColorToHex(Color color)
	{
		return null;
	}

	private bool TryParseHexColor(string hex, out Color color)
	{
		color = default;
		return false;
	}

	public void SetReligionColor(Color color)
	{
	}

	public void Show(string _religionId)
	{
	}

	public void Hide()
	{
	}

	public void OnReligionInfoPanelButtonClose()
	{
	}

	public void CloseTranslationPanel()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	public void InitReligionInfo(string _religionId)
	{
	}

	public void SwitchDisplayMode(DisplayMode _newMode)
	{
	}

	public void RefreshItemList()
	{
	}

	public void RefreshItemListWithCurrentPage()
	{
	}

	private List<string> GetCurrentItems()
	{
		return null;
	}

	private void DisplayCurrentPage()
	{
	}

	private void ClearListItems()
	{
	}

	private void CreateListItem(string _itemKey, int _index)
	{
	}

	private string GetPracticeKeyPrefix(Religion religion)
	{
		return null;
	}

	private void OnAddPractice(string _practiceName)
	{
	}

	private void OnTranslatePractice(string _practiceKey, string _name)
	{
	}

	private void OnDeletePractice(string _practiceKey)
	{
	}

	private void OnPracticeChanged(string _practiceKey, string _newName)
	{
	}

	private void InitializeListUI()
	{
	}

	private void OnPageChanged(int _currentPage, int _startIndex, int _endIndex)
	{
	}

	private void UpdateReligionSetsPanel()
	{
	}

	private void RefreshReligionSetList()
	{
	}

	private void ClearReligionSetItems()
	{
	}

	private void OnCreateNewReligionSetClicked()
	{
	}

	private void OnExportToSelectedReligionSetClicked()
	{
	}

	private void PerformReligionExport(bool confirmOverwrite)
	{
	}

	private void HandleExportSuccess()
	{
	}

	private void UpdateCurrentReligionSetDisplay()
	{
	}

	private void UpdateTargetReligionSetDropdown()
	{
	}

	private void OnTargetReligionSetDropdownValueChanged(int _index)
	{
	}

	private void ShowCreateNewReligionSetDialog()
	{
	}

	private void CreateVirtualReligionSet(string _religionSetName)
	{
	}

	private void ResetTargetReligionSetDropdown()
	{
	}

	private void ShowAddNewReligionSetUI()
	{
	}

	private void HideAddNewReligionSetUI()
	{
	}

	private void InitializeHolyProvinceDropdown()
	{
	}

	private void UpdateHolyProvinceDisplay()
	{
	}

	private bool IsAtheismReligion()
	{
		return false;
	}

	private void UpdateHolyProvinceDropdownOptions()
	{
	}

	private void OnHolyProvinceDropdownValueChanged(int _index)
	{
	}

	private void SetHolyProvince(int _provinceId)
	{
	}

	private bool ValidateHolyProvince(int _provinceId)
	{
		return false;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void BringToFront()
	{
	}
}
