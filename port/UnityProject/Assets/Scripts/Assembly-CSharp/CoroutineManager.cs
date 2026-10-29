using System.Collections;
using UnityEngine;

public class CoroutineManager : MonoBehaviour
{
	private static CoroutineManager _instance;

	private static bool s_IsShuttingDown;

	public static CoroutineManager Instance => null;

	public static Coroutine StartManagedCoroutine(IEnumerator coroutine)
	{
		return null;
	}

	public static void StopManagedCoroutine(Coroutine coroutine)
	{
	}

	private void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDestroy()
	{
	}
}
