using System;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class SpouseRole : Role
	{
		public int spouseOfId;

		public int stateId;

		public override float GetPowerScore()
		{
			return 0f;
		}
	}
}
