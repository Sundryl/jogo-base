using Michsky.MUIP;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUIInfo : MonoBehaviour
{
	private const string c_AccessWorkshopButtonName = "AccessWorkshop";

	private const string c_OtherSettingsButtonName = "OtherSettings";

	private const string c_OtherSettingsEntryName = "OtherSettingsEntry";

	private const string c_OtherSettingsLocalizationKey = "OtherSettings";

	private static SettingsUIInfo instance;

	public ButtonManager changeLanguageButton;

	public ButtonManager resolutionButton;

	public Slider volumeSlider;

	public Slider cameraZoomSlider;

	public ButtonManager screenModeButton;

	private Resolution[] resolutions;

	private int currentResolutionIndex;

	private int currentScreenModeIndex;

	private ButtonManager m_OtherSettingsButton;

	public Camera screenshotCamera;

	public static SettingsUIInfo Instance => null;

	private void Awake()
	{
	}

	public void OnChangeLanguageButtonClicked()
	{
	}

	public void OnChangeScreenModeButtonClicked()
	{
	}

	public void OnChangeResolutionButtonClicked()
	{
	}

	private void UpdateResolutionDisplay()
	{
	}

	public void OnLoadSaveButtonClicked()
	{
	}

	public void OnSaveGameButtonClicked()
	{
	}

	public void OnExportButtonClicked()
	{
	}

	private void OnExportScreenshotOptionClicked()
	{
	}

	private void OnExportHistoryOptionClicked()
	{
	}

	public void OnCloseButtonClicked()
	{
	}

	public void OnQuitGameButtonClicked()
	{
	}

	public void OnOtherSettingsButtonClicked()
	{
	}

	private void RefreshLocalization()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetWindowedMode()
	{
	}

	public void SetFullScreenMode()
	{
	}

	public void SetBorderlessWindowMode()
	{
	}

	public void SwitchToNextResolution()
	{
	}

	private void ApplyCurrentResolution()
	{
	}

	private int GetCurrentResolutionIndex()
	{
		return 0;
	}

	public void InitSettingInfoUI()
	{
	}

	private void EnsureOtherSettingsButton()
	{
	}

	private static Transform FindChildRecursive(Transform _parent, string _childName)
	{
		return null;
	}
}
