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

public class CultureInfoUI : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	public enum DisplayMode
	{
		BasicInfo = 0,
		Countries = 1,
		Cities = 2,
		MaleFirstNames = 3,
		FemaleFirstNames = 4,
		LastNames = 5,
		Attributes = 6
	}

	private enum ImportType
	{
		Countries = 0,
		Cities = 1,
		MaleFirstNames = 2,
		FemaleFirstNames = 3,
		LastNames = 4,
		FullCulture = 5
	}

	[CompilerGenerated]
	private sealed class _003CProcessTranslateCultureName_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CultureInfoUI _003C_003E4__this;

		public string _sourceCultureName;

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
		public _003CProcessTranslateCultureName_003Ed__114(int _003C_003E1__state)
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
	private sealed class _003CProcessTranslateCultureDescription_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CultureInfoUI _003C_003E4__this;

		public string _sourceCultureDescription;

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
		public _003CProcessTranslateCultureDescription_003Ed__115(int _003C_003E1__state)
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
	private sealed class _003CBatchTranslateItems_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<string> _itemNames;

		public List<string> _itemKeys;

		public CultureInfoUI _003C_003E4__this;

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
		public _003CBatchTranslateItems_003Ed__117(int _003C_003E1__state)
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

	[Header("基本信息面板组件")]
	[SerializeField]
	private TMP_InputField m_CultureNameInput;

	[SerializeField]
	private TMP_InputField m_CultureDescriptionInput;

	[SerializeField]
	private TMP_InputField m_ColorInput;

	[SerializeField]
	private MPImage m_CultureColorImage;

	[SerializeField]
	private LocalizationTmpButton m_NameOrderToggleButton;

	[SerializeField]
	[Header("属性面板组件")]
	private GameObject m_TraitContainer;

	[SerializeField]
	private GameObject m_PoliticalSystemContainer;

	[SerializeField]
	private GameObject m_EthnicAttributeContainer;

	[SerializeField]
	private GameObject m_SliderTraitItemPrefab;

	[Header("语言设置")]
	[SerializeField]
	private DropdownInfo m_LanguageDropdown;

	[SerializeField]
	private DropdownInfo m_DisplayModeDropdown;

	[SerializeField]
	private GameObject m_LanguagePanel;

	[Header("标签按钮")]
	[Header("标签面板")]
	public GameObject basicInfoPanel;

	public GameObject listPanel;

	public GameObject attributesPanel;

	[Header("列表UI组件")]
	[SerializeField]
	private GameObject m_ListItemPrefab;

	[SerializeField]
	private Transform m_ListItemContainer;

	[SerializeField]
	private PaginationComponent m_PaginationComponent;

	[SerializeField]
	private AddItemUIComponent m_AddItemUI;

	[SerializeField]
	private Transform m_TranslationInputContainer;

	[Header("翻译相关组件")]
	[SerializeField]
	private TranslationUIPanel m_TranslationUIPanel;

	[SerializeField]
	[Header("功能按钮")]
	private Button m_ExportCultureButton;

	[SerializeField]
	private Button m_ImportButton;

	[SerializeField]
	private Button m_autoTranslate;

	private Button m_MilitaryProfileButton;

	private LocalizationTmpButton m_MilitaryProfileButtonLocalization;

	private Button m_OfficialTitleButton;

	private LocalizationTmpButton m_OfficialTitleButtonLocalization;

	[HideInInspector]
	public MapCulture m_CurrentCulture;

	private string m_CurrentDisplayLanguage;

	private float m_UpdateInterval;

	private float m_LastUpdateTime;

	private List<GameObject> m_ListItems;

	private DisplayMode m_CurrentDisplayMode;

	private static CultureInfoUI s_Instance;

	public static CultureInfoUI Instance => null;

	public void RefreshLocalization()
	{
	}

	private void RefreshLayout()
	{
	}

	private void Start()
	{
	}

	private void RefreshDisplayModeDropdownOptions()
	{
	}

	private void RefreshLanguageDropdownOptions()
	{
	}

	private void InitializeDisplayModeDropdown()
	{
	}

	private void OnDisplayModeDropdownValueChanged(int index)
	{
	}

	private void InitializeLanguageDropdown()
	{
	}

	private void OnLanguageDropdownValueChanged(int _index)
	{
	}

	private void InitializeUI()
	{
	}

	public void CloseTranslationPanel()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateImportButtonText(DisplayMode mode)
	{
	}

	private void EnsureMilitaryProfileButton()
	{
	}

	private void RefreshMilitaryProfileButtonText()
	{
	}

	private string GetMilitaryProfileButtonText()
	{
		return null;
	}

	private void EnsureOfficialTitleButton()
	{
	}

	private void RefreshOfficialTitleButtonText()
	{
	}

	private void ShowPanelForDisplayMode(DisplayMode mode)
	{
	}

	private void UpdateTabContent()
	{
	}

	private void UpdateBasicInfoPanel()
	{
	}

	private void UpdateListPanel()
	{
	}

	private void UpdateAttributesPanel()
	{
	}

	private void CreateSliderTraitItems(List<Trait> allTraits)
	{
	}

	private void CreateSliderPoliticalSystemItems()
	{
	}

	private void CreateSliderEthnicAttributeItems()
	{
	}

	private void OnTraitWeightChanged(string traitName, float weight)
	{
	}

	private void OnPoliticalSystemWeightChanged(PoliticalSystem system, float weight)
	{
	}

	private void OnEthnicAttributeWeightChanged(EthnicAttribute attribute, float weight)
	{
	}

	private void OnCultureNameChanged(string _newName)
	{
	}

	private void OnCultureDescriptionChanged(string _newDescription)
	{
	}

	private void OnColorInputChanged(string _hex)
	{
	}

	private void OnNameOrderToggleClicked()
	{
	}

	private void UpdateNameOrderButtonText()
	{
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

	public void OnCultureInfoPanelButtonClose()
	{
	}

	private void FixedUpdate()
	{
	}

	private void UpdateCultureInfo()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void InitCultureInfo(string cultureName)
	{
	}

	private void OnMilitaryProfileButtonClicked()
	{
	}

	private void OnOfficialTitleButtonClicked()
	{
	}

	public void RefreshItemList()
	{
	}

	public void RefreshItemListWithCurrentPage()
	{
	}

	private void OnPageChanged(int _currentPage, int _startIndex, int _endIndex)
	{
	}

	private void DisplayCurrentPage()
	{
	}

	private void ClearListItems()
	{
	}

	private void CreateItem(string _itemKey, int _index)
	{
	}

	private void OnAddItem(string _itemName)
	{
	}

	private void OnTranslateItem(string _itemKey, string _name)
	{
	}

	public void OnTranslationPanelClosed()
	{
	}

	private void OnDeleteItem(string _itemKey)
	{
	}

	private void OnItemNameChanged(string _itemKey, string _newName)
	{
	}

	public void SetCultureColor(Color color)
	{
	}

	private void SetupContainersInEditor()
	{
	}

	private void Awake()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void BringToFront()
	{
	}

	private string GetItemTypeString()
	{
		return null;
	}

	private List<string> GetCurrentKeys()
	{
		return null;
	}

	public void SwitchDisplayMode(DisplayMode _newMode)
	{
	}

	private void OnExportCultureClicked()
	{
	}

	public void ImportNamesFromCultureManager(string _sourceCultureNameID, bool _copyStateNames, bool _copyCityNames)
	{
	}

	private void OnImportButtonClicked()
	{
	}

	private void ShowCultureSelectionPanel(ImportType _importType = ImportType.Countries)
	{
	}

	private void OnCultureSelected(string _selectedCulture, ImportType _importType)
	{
	}

	public void ImportFirstAndLastNamesFromCultureManager(string _sourceCultureNameID, bool _copyMaleFirstNames, bool _copyFemaleFirstNames, bool _copyLastNames)
	{
	}

	private void ImportFullCultureData(string _sourceCultureName)
	{
	}

	public void ClearCurrentListDataAndPagination()
	{
	}

	public void OnClearAllCultureDataButtonClicked()
	{
	}

	public void OnTranslateCurrentPageButtonClicked()
	{
	}

	public void AutoTranslateCultureInfo(bool _translateAll = false)
	{
	}

	private void TranslateCultureBasicInfo(string _sourceLanguage)
	{
	}

	[IteratorStateMachine(typeof(_003CProcessTranslateCultureName_003Ed__114))]
	private IEnumerator ProcessTranslateCultureName(string _sourceCultureName, string _sourceLanguage)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessTranslateCultureDescription_003Ed__115))]
	private IEnumerator ProcessTranslateCultureDescription(string _sourceCultureDescription, string _sourceLanguage)
	{
		return null;
	}

	private void TranslateCurrentPageItems(string _sourceLanguage)
	{
	}

	[IteratorStateMachine(typeof(_003CBatchTranslateItems_003Ed__117))]
	private IEnumerator BatchTranslateItems(List<string> _itemKeys, List<string> _itemNames, string _sourceLanguage)
	{
		return null;
	}

	private void TranslateAllItems(string _sourceLanguage)
	{
	}
}
