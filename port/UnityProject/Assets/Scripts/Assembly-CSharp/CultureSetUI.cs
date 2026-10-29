using System.Collections.Generic;
using UnityEngine;

public class CultureSetUI : MonoBehaviour
{
	public Dictionary<string, GameObject> CultureToggleDict;

	public GameObject parentUI;

	public GameObject cultureSwitcherPrefab;

	private static CultureSetUI _instance;

	public static CultureSetUI Instance => null;

	public void Start()
	{
	}

	public void OnWorkShopButtonClicked()
	{
	}

	public void CreateCultureSetUISwitcher()
	{
	}
}
