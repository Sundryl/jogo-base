using System.Collections.Generic;
using UnityEngine;

public static class UIPauseStateManager
{
	private static readonly HashSet<int> s_ActivePauseOwners;

	private static bool s_HasCapturedPauseRestoreState;

	private static bool s_RestorePauseStateAfterUiCloses;

	public static void AcquirePause(Object owner)
	{
	}

	public static void ReleasePause(Object owner)
	{
	}

	public static void NotifyUserToggledPauseState()
	{
	}
}
