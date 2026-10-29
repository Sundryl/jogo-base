using UnityEngine;
using UnityEngine.UI;

internal class ImportHeightMapUI : MonoBehaviour
{
	private static ImportHeightMapUI _instance;

	public Slider SeaLevelGraySlider;

	public LocalizationTextWithAdditionalText sealevalGrayValueText;

	public static ImportHeightMapUI Instance => null;

	private void Awake()
	{
	}

	public void UpdateSelevelRelatedText()
	{
	}
}
