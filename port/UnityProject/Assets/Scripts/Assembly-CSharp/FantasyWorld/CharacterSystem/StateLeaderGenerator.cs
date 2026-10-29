namespace FantasyWorld.CharacterSystem
{
	public static class StateLeaderGenerator
	{
		public static void GenerateLeadersForAllStates()
		{
		}

		public static Character GenerateLeaderForState(State state, out string resolvedMapCultureId)
		{
			resolvedMapCultureId = null;
			return null;
		}

		private static Gender DetermineLeaderGender(PoliticalSystem politicalSystem)
		{
			return Gender.Male;
		}

		private static void EnhanceLeaderAttributes(Character leader, PoliticalSystem politicalSystem)
		{
		}

		private static void AssignLeaderToFamily(Character leader, State state)
		{
		}
	}
}
