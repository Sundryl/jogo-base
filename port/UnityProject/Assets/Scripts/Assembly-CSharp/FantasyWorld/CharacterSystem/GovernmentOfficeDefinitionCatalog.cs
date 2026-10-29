using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	public static class GovernmentOfficeDefinitionCatalog
	{
		private static readonly Dictionary<string, GovernmentOfficeDefinition> s_Definitions;

		public static IEnumerable<GovernmentOfficeDefinition> Definitions => null;

		public static bool TryGet(string _officeId, out GovernmentOfficeDefinition _definition)
		{
			_definition = null;
			return false;
		}

		public static GovernmentOfficeDefinition Get(string _officeId)
		{
			return null;
		}
	}
}
