using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public static class UIInteractionChecker
{
	private static List<RaycastResult> tempRaycastResults;

	public static bool IsPointerOverUIElement<T>() where T : Component
	{
		return false;
	}
}
