using System;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class NationalLeaderRole : Role
	{
		public string title;

		public double reignStartTime;

		public int stateId;

		public override float GetPowerScore()
		{
			return 0f;
		}
	}
}
