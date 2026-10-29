using System;
using System.Collections.Generic;
using MPUIKIT;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class SaveLoadModeSelectionPanelUI : BasePanelUI
{
	private sealed class LocalizedTextBinding
	{
		public TextMeshProUGUI Text;

		public string Key;
	}

	private const string c_ActionButtonPrefabResourcesPath = "Prefabs/WarningPanelButton";

	private const string c_ActionButtonPrefabAssetPath = "Assets/Prefabs/WarningPanelButton.prefab";

	private static readonly Color s_OverlayColor;

	private static readonly Color s_PanelColor;

	private static readonly Color s_PanelOutlineColor;

	private static readonly Color s_SummaryColor;

	private static readonly Color s_StreamingCardColor;

	private static readonly Color s_StreamingOutlineColor;

	private static readonly Color s_StandardCardColor;

	private static readonly Color s_StandardOutlineColor;

	private static readonly Color s_ButtonColor;

	private static readonly Color s_StreamingButtonColor;

	private static readonly Color s_StandardButtonColor;

	private static readonly Color s_TextColor;

	private static readonly Color s_MutedTextColor;

	private static readonly Color s_WarningTextColor;

	private static SaveLoadModeSelectionPanelUI s_Instance;

	private readonly List<LocalizedTextBinding> m_LocalizedTexts;

	private SaveInfo m_SaveInfo;

	private Action<SaveSystem.SaveFileLoadMode> m_OnSelected;

	private TextMeshProUGUI m_SelectedSaveText;

	private TextMeshProUGUI m_FormatHintText;

	[SerializeField]
	private Button m_ActionButtonPrefab;

	private bool m_IsInitialized;

	public static SaveLoadModeSelectionPanelUI Instance => null;

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

	public void Display(SaveInfo _saveInfo, Action<SaveSystem.SaveFileLoadMode> _onSelected)
	{
	}

	private static SaveLoadModeSelectionPanelUI FindExistingInstance()
	{
		return null;
	}

	private void BuildPanel()
	{
	}

	private void CreateModeCard(Transform _parent, string _objectName, Color _backgroundColor, Color _outlineColor, string _titleKey, string _descriptionKey, string _warningKey, string _buttonKey, Color _buttonColor, SaveSystem.SaveFileLoadMode _loadMode)
	{
	}

	private GameObject CreateCard(string _objectName, Transform _parent, Color _backgroundColor, Color _outlineColor)
	{
		return null;
	}

	private static GameObject CreateRow(string _objectName, Transform _parent, float _spacing)
	{
		return null;
	}

	private TextMeshProUGUI CreateLocalizedText(string _objectName, Transform _parent, string _key, float _fontSize, FontStyles _fontStyle, Color _color, TextAlignmentOptions _alignment)
	{
		return null;
	}

	private static TextMeshProUGUI CreateText(string _objectName, Transform _parent, float _fontSize, FontStyles _fontStyle, Color _color, TextAlignmentOptions _alignment)
	{
		return null;
	}

	private Button CreateButton(string _objectName, Transform _parent, string _localizationKey, float _width, float _height, Color _color)
	{
		return null;
	}

	private Button GetOrFindActionButtonPrefab()
	{
		return null;
	}

	private void SelectMode(SaveSystem.SaveFileLoadMode _loadMode)
	{
	}

	private void RefreshSaveDetails()
	{
	}

	private void HideImmediate()
	{
	}

	private static void ConfigureRoundedRectangle(MPImage _image, Color _fillColor, float _cornerRadius, float _outlineWidth, Color _outlineColor)
	{
	}

	private static LayoutElement GetOrAddLayout(GameObject _target)
	{
		return null;
	}

	private static void SetLayout(GameObject _target, float minWidth = -1f, float minHeight = -1f, float flexibleWidth = -1f, float flexibleHeight = -1f)
	{
	}

	private static string FormatFileSize(long _bytes)
	{
		return null;
	}

	private static string T(string _key)
	{
		return null;
	}
}
