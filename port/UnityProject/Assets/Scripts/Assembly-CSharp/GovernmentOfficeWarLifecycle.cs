using System.Collections.Generic;
using FantasyWorld.CharacterSystem;

public static class GovernmentOfficeWarLifecycle
{
	private sealed class ActiveWarOffice
	{
		public State State;

		public int WarId;

		public GovernmentOfficeWarSystemKind WarSystemKind;
	}

	public static void FillActiveWarVacanciesForState(State _state)
	{
	}

	public static void ReconcileActiveWarOffices()
	{
	}

	private static void AddActiveOffice(ISet<string> _activeKeys, ICollection<ActiveWarOffice> _activeVacancies, State _state, int _warId, GovernmentOfficeWarSystemKind _warSystemKind)
	{
	}

	private static string BuildKey(int _stateId, int _warId, GovernmentOfficeWarSystemKind _warSystemKind)
	{
		return null;
	}

	private static State ResolveState(int _stateId)
	{
		return null;
	}

	private static bool IsEligibleParticipant(State _state)
	{
		return false;
	}
}
