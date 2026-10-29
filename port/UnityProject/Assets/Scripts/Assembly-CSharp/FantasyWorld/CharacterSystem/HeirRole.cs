using System;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class HeirRole : Role
	{
		public int familyId;

		public string inheritanceType;

		public override float GetPowerScore()
		{
			return 0f;
		}
	}
}
