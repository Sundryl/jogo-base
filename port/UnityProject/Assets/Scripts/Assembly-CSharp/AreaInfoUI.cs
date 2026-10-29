using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AreaInfoUI : BasePanelUI
{
	private static AreaInfoUI s_Instance;

	private static GameObject s_InstanceObject;

	[Header("地区名称控件")]
	[SerializeField]
	private TMP_InputField m_AreaNameInputField;

	[Header("折叠区域")]
	[SerializeField]
	private CollapsibleSectionUI m_ActionsSection;

	[Header("翻译面板")]
	[SerializeField]
	private TranslationUIPanel m_TranslationUIPanel;

	private State m_CurrentArea;

	private Button m_TranslateAreaNameButton;

	private Button m_UseNeighborStateColorButton;

	public static AreaInfoUI Instance => null;

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	private void InitializeComponents()
	{
	}

	private void FindTitleText()
	{
	}

	private void FindAreaNameInputField()
	{
	}

	private void FindCollapsibleSections()
	{
	}

	private void InitializeSections()
	{
	}

	private void FindTranslationPanel()
	{
	}

	private void FindAndBindActionButtons()
	{
	}

	private void BindColorPicker()
	{
	}

	public void InitAreaInfo(int areaID)
	{
	}

	public void Display(int areaID)
	{
	}

	public void UpdateAreaName(string name)
	{
	}

	public void UpdateAreaColor(Color color)
	{
	}

	public void OnAreaInfoPanelButtonClose()
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

	private void OnActionsSectionExpanded(CollapsibleSectionUI section)
	{
	}

	private void UpdateAreaInfo(bool isForceUpdate)
	{
	}

	private void UpdateUseNeighborStateColorToggleVisual()
	{
	}

	private void OnUseNeighborStateColorButtonClicked()
	{
	}

	private void OnTranslateAreaNameButtonClicked()
	{
	}

	private void OnAreaTranslationPanelClosed(string key, Dictionary<string, string> translations)
	{
	}
}
