internal static class WarV2EventText
{
	public static string Name(int stateId, bool isExport)
	{
		return null;
	}

	public static string CasusBelliName(int casusBelliId, bool font)
	{
		return null;
	}

	public static string GoalDesc(WarGoalTypeV2 type, int size, bool font)
	{
		return null;
	}

	public static string ReasonName(WarEndReasonV2 reason, bool font)
	{
		return null;
	}

	public static string Duration(int months, bool font)
	{
		return null;
	}

	public static WarGoalTypeV2 ParseGoal(string s)
	{
		return WarGoalTypeV2.CedeProvince;
	}

	public static WarSideV2 ParseSide(string s)
	{
		return WarSideV2.Attacker;
	}

	public static WarEndReasonV2 ParseReason(string s)
	{
		return WarEndReasonV2.GoalsAchieved;
	}
}
