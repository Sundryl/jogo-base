using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public sealed class CustomMapImageInfoUI : BasePanelUI
{
	private const string c_TitleLocalizationKey = "CustomImageTitle";

	private const string c_NameLabelLocalizationKey = "CustomImageName";

	private const string c_NamePlaceholderLocalizationKey = "CustomImageNamePlaceholder";

	private const string c_ScaleLocalizationKey = "ImageScale";

	private const string c_RotationLocalizationKey = "ImageRotation";

	private const string c_AlphaLocalizationKey = "ImageAlpha";

	private const string c_LayerLocalizationKey = "ImageLayer";

	private const string c_LayerOrderLocalizationKey = "ImageLayerOrder";

	private const string c_LayerOrderHintLocalizationKey = "ImageLayerOrderHint";

	private const string c_ScaleDisplayFormat = "0.######";

	private const string c_ReplaceLocalizationKey = "ReplaceImage";

	private const float c_DefaultInfoFontSizeCN = 21.5f;

	private const float c_DefaultInfoFontSizeEN = 15f;

	private TMP_InputField m_NameInput;

	private Transform m_PreviewSectionRoot;

	private LocalizationTmpButton m_ReplaceButtonLocalizationButton;

	private Button m_ReplaceButton;

	private LocalizationTmpButton m_VisibleButtonLocalizationButton;

	private Button m_VisibleButton;

	private SliderValueConnector m_ScaleSliderConnector;

	private Slider m_ScaleSlider;

	private SliderValueConnector m_RotationSliderConnector;

	private Slider m_RotationSlider;

	private SliderValueConnector m_AlphaSliderConnector;

	private Slider m_AlphaSlider;

	private DropdownInfo m_LayerDropdownInfo;

	private TMP_Dropdown m_LayerDropdown;

	private TMP_InputField m_LayerOrderInput;

	private TMP_Text m_LayerOrderLabelText;

	private TooltipTrigger m_LayerOrderTooltipTrigger;

	private bool m_IsRefreshing;

	private bool m_IsSyncingLayerDropdown;

	private string m_CurrentId;

	public static CustomMapImageInfoUI ExistingInstance => null;

	protected override void Awake()
	{
	}

	public void Open(string imageId)
	{
	}

	public void Close()
	{
	}

	protected override void OnPanelHide()
	{
	}

	protected override void RefreshLocalization()
	{
	}

	private void SetupNameInput()
	{
	}

	private void SetupPreviewSection()
	{
	}

	private void SetupActionButtons()
	{
	}

	private void SetupSliders()
	{
	}

	private void SetupLayerControls()
	{
	}

	private void EnsureLayerControls()
	{
	}

	private void SetupLayerDropdown()
	{
	}

	private void SetupLayerOrderInput()
	{
	}

	private void HideUnusedControls()
	{
	}

	private void RefreshDynamicLocalization()
	{
	}

	private void RefreshNamePlaceholder()
	{
	}

	private void RefreshLayerDropdownLocalization()
	{
	}

	private void RefreshFields()
	{
	}

	private void SyncSlider(SliderValueConnector connector, Slider slider, Vector2 range, float value)
	{
	}

	private void SyncLayerDropdownSelection(CustomMapImageData data)
	{
	}

	private void OnNameInputEndEdit(string value)
	{
	}

	private void OnScaleValueChanged(float value)
	{
	}

	private void OnRotationValueChanged(float value)
	{
	}

	private void OnAlphaValueChanged(float value)
	{
	}

	private void OnLayerDropdownValueChanged(int _index)
	{
	}

	private void OnLayerOrderInputEndEdit(string _text)
	{
	}

	private void RefreshLayerOrderInputDisplay()
	{
	}

	private void OnReplaceButtonClicked()
	{
	}

	private void OnVisibleButtonClicked()
	{
	}

	private void UpdateVisibleButtonLocalization()
	{
	}

	private static bool TryParseInt(string text, out int value)
	{
		value = default;
		return false;
	}

	private Transform EnsureSliderRoot(Transform templateRoot, string objectName)
	{
		return null;
	}

	private void BindSlider(Transform sliderRoot, string localizationKey, string formatString, UnityAction<float> listener, out SliderValueConnector connector, out Slider slider)
	{
		connector = null;
		slider = null;
	}

	private static void ConfigureDropdownLayout(GameObject dropdownObject, RectTransform templateRect)
	{
	}

	private static void ApplySectionLocalizationKey(Transform root, string key)
	{
	}

	private void ApplyUnifiedFontSizes()
	{
	}

	private void ResolveNameLabelFontSizes(out float _chineseFontSize, out float _latinFontSize)
	{
		_chineseFontSize = default;
		_latinFontSize = default;
	}

	private static void ApplyInputFieldFontSize(TMP_InputField _inputField, float _fontSize)
	{
	}

	private static void ApplyTextFontSize(TMP_Text _text, float _fontSize)
	{
	}
}
