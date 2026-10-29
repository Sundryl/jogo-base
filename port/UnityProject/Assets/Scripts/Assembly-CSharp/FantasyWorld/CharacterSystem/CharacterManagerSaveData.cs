using System;
using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class CharacterManagerSaveData
	{
		public int nextCharacterId;

		public List<Character> characters;
	}
}
