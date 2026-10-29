using TMPro;
using UnityEngine;

internal class DescriptionPanelUI : MonoBehaviour
{
	public TextMeshProUGUI EnglishLocalizationText;

	public TextMeshProUGUI ChineseLocalizationText;

	public TextMeshProUGUI TraditionalChineseLocalizationText;

	public TextMeshProUGUI RussianLocalizationText;

	public TextMeshProUGUI SpanishSpainLocalizationText;

	public TextMeshProUGUI PortugueseBrazilLocalizationText;

	public TextMeshProUGUI GermanLocalizationText;

	public TextMeshProUGUI JapaneseLocalizationText;

	public TextMeshProUGUI FrenchLocalizationText;

	public TextMeshProUGUI PolishLocalizationText;

	public TextMeshProUGUI SpanishLatinAmericaLocalizationText;

	public TextMeshProUGUI PortuguesePortugalLocalizationText;

	public TextMeshProUGUI KoreanLocalizationText;

	private static DescriptionPanelUI _instance;

	public static DescriptionPanelUI Instance => null;

	public void DisableAllLocalizationTexts()
	{
	}

	private void Awake()
	{
	}

	public void OnDescriptionPanelUIOpen()
	{
	}

	public void RefreshLocalization()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
