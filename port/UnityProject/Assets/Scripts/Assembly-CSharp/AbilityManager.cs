using System.Collections.Generic;
using UnityEngine;

public class AbilityManager
{
	private static AbilityManager _instance;

	private Dictionary<AbilityType, GameObject> abilityPrefabs;

	private GameObject abilityContainer;

	public static AbilityManager Instance => null;

	private AbilityManager()
	{
	}

	private void LoadPrefabs()
	{
	}

	public T CreateAbility<T>(State state, AbilityType type) where T : ProvinceTargetAbility
	{
		return null;
	}
}
