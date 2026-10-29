using Michsky.MUIP;
using UnityEngine;

public class CultureWorkShopUI : MonoBehaviour
{
	private static CultureWorkShopUI _instance;

	public GameObject cultureSetButtonPrefab;

	public RectTransform showCultureSetPanel;

	public ButtonManager closeButton;

	public static CultureWorkShopUI Instance => null;

	private void Start()
	{
	}

	public void OnOpen()
	{
	}

	private void RefreshCultureSetList()
	{
	}

	private void CreateCultureSetButton(string cultureSet)
	{
	}

	private void OnCultureSetButtonClicked(string cultureSet)
	{
	}

	private void UploadCultureSetToWorkshop(string cultureSet)
	{
	}

	public void OnClose()
	{
	}
}
