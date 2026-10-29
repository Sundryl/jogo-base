using System.Collections.Generic;
using UnityEngine;

public class AttackArrowManager
{
	private static AttackArrowManager _instance;

	public GameObject attackArrowPrefab;

	public GameObject attackArrowOutlinePrefab;

	public int objectCount;

	private Queue<GameObject> pool;

	public static AttackArrowManager Instance => null;

	public void Start()
	{
	}

	public GameObject GetObject()
	{
		return null;
	}

	public void ReturnObject(GameObject obj)
	{
	}
}
