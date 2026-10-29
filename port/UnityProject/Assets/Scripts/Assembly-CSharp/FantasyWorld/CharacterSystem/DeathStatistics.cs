using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	public class DeathStatistics
	{
		public int totalDeaths;

		public List<float> deathAges;

		public int deathsBefore40;

		public int deaths40To60;

		public int deaths60To70;

		public int deaths70To80;

		public int deaths80Plus;

		public float GetAverageDeathAge()
		{
			return 0f;
		}

		public float GetAverageDeathAgeBefore40()
		{
			return 0f;
		}
	}
}
