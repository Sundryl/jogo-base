using Michsky.MUIP;
using UnityEngine;

public class ReligionWorkshopUI : MonoBehaviour
{
	private static ReligionWorkshopUI _instance;

	public GameObject religionSetButtonPrefab;

	public RectTransform showReligionSetPanel;

	public ButtonManager closeButton;

	public static ReligionWorkshopUI Instance => null;

	private void Start()
	{
	}

	public void OnOpen()
	{
	}

	private void RefreshReligionSetList()
	{
	}

	private void CreateReligionSetButton(string religionSet)
	{
	}

	private void OnReligionSetButtonClicked(string religionSet)
	{
	}

	private void UploadReligionSetToWorkshop(string religionSet)
	{
	}

	public void OnClose()
	{
	}
}
