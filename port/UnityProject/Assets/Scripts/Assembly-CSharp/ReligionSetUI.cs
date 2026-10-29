using System.Collections.Generic;
using UnityEngine;

public class ReligionSetUI : MonoBehaviour
{
	public Dictionary<int, GameObject> ReligionToggleDict;

	public GameObject parentUI;

	public GameObject religionSwitcherPrefab;

	private static ReligionSetUI _instance;

	public static ReligionSetUI Instance => null;

	public void Start()
	{
	}

	public void OnWorkShopButtonClicked()
	{
	}
}
