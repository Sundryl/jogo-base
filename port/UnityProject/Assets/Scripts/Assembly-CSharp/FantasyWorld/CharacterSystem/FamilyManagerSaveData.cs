using System;
using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class FamilyManagerSaveData
	{
		public int nextFamilyId;

		public List<Family> families;

		public List<Family> historicalFamilies;
	}
}
