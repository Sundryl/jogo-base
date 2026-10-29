using System.Collections.Generic;
using UnityEngine;

public static class StateBorderHighlightManager
{
	private class ContextHighlightData
	{
		public readonly Dictionary<int, Color?> StateColors;

		public readonly Dictionary<int, Color?> AllianceColors;
	}

	private static readonly Dictionary<string, ContextHighlightData> s_ContextHighlights;

	private static readonly List<string> s_ContextOrder;

	private static readonly HashSet<int> s_CurrentlyHighlightedStates;

	private static readonly HashSet<int> s_CurrentlyHighlightedAlliances;

	private static string s_ActiveContextKey;

	public static void SetStateHighlight(string contextKey, int stateId, Color? color = null)
	{
	}

	public static void ClearStateHighlight(string contextKey, int stateId)
	{
	}

	public static void ClearContext(string contextKey)
	{
	}

	public static void SetAllianceHighlight(string contextKey, int allianceId, Color? color = null)
	{
	}

	public static void ClearAllianceHighlight(string contextKey, int allianceId)
	{
	}

	public static void BringContextToFront(string contextKey)
	{
	}

	private static ContextHighlightData GetOrCreateContext(string contextKey)
	{
		return null;
	}

	private static void TouchContext(string contextKey)
	{
	}

	private static void ActivateContext(string contextKey)
	{
	}

	private static void ActivateLatestContext()
	{
	}

	private static void CleanupContextIfEmpty(string contextKey, ContextHighlightData context)
	{
	}

	private static void ApplyContextHighlights(string contextKey)
	{
	}

	private static void ApplyStateHighlight(int stateId, Color? color)
	{
	}

	private static void RemoveStateHighlight(int stateId)
	{
	}

	private static void ApplyAllianceHighlight(int allianceId, Color? color)
	{
	}

	private static void RemoveAllianceHighlight(int allianceId)
	{
	}

	private static void ClearAllRendererHighlights()
	{
	}
}
