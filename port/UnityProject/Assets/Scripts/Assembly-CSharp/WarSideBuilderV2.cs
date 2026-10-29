using System.Collections.Generic;

public static class WarSideBuilderV2
{
	public static List<WarParticipantV2> Build(WarDeclarationV2 declaration, double joinedAt)
	{
		return null;
	}

	public static List<WarParticipantV2> BuildInternal(WarDeclarationV2 declaration, double joinedAt)
	{
		return null;
	}

	private static void AddSide(List<WarParticipantV2> result, HashSet<int> seen, State primary, WarSideV2 side, WarRoleV2 primaryRole, double joinedAt)
	{
	}

	private static void AddVassalsAndOverlord(List<WarParticipantV2> result, HashSet<int> seen, State state, WarSideV2 side, double joinedAt)
	{
	}

	private static void AddParticipant(List<WarParticipantV2> result, HashSet<int> seen, State state, WarSideV2 side, WarRoleV2 role, bool isPrimary, double joinedAt)
	{
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}
}
