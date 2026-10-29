using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	public static class TitleManager
	{
		private static readonly Dictionary<PoliticalSystem, (string maleKey, string femaleKey)> s_TitleKeys;

		public static string GetTitle(PoliticalSystem politicalSystem, Gender gender, string language = null)
		{
			return null;
		}

		public static string GetFullTitle(Character character, State state)
		{
			return null;
		}

		public static string GetStateFullName(State state)
		{
			return null;
		}
	}
}
