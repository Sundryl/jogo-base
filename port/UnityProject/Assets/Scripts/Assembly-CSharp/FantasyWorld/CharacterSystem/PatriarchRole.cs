using System;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class PatriarchRole : Role
	{
		public int familyId;

		public override float GetPowerScore()
		{
			return 0f;
		}
	}
}
