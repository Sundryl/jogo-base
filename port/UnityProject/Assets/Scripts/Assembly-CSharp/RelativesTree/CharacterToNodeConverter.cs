using System.Collections.Generic;
using FantasyWorld.CharacterSystem;

namespace RelativesTree
{
	public static class CharacterToNodeConverter
	{
		public static List<Node> ConvertCharactersToNodes(List<Character> characters)
		{
			return null;
		}

		private static void AddSiblingRelations(Character character, List<Character> allCharacters, Dictionary<int, Node> nodeMap, Node node)
		{
		}

		public static List<Character> ExtractFamilyCharacters(FantasyWorld.CharacterSystem.Family family, int characterId, int maxGenerations = 3)
		{
			return null;
		}

		public static Options CreateDefaultOptions(int rootCharacterId)
		{
			return null;
		}
	}
}
