namespace FantasyWorld.CharacterSystem
{
	public sealed class GovernmentOfficeEffectProfile
	{
		public float EconomicModifierCap { get; }

		public float RebellionModifierCap { get; }

		public float LeadershipModifierCap { get; }

		public GovernmentOfficeEffectProfile(float _economicModifierCap = 0f, float _rebellionModifierCap = 0f, float _leadershipModifierCap = 0f)
		{
		}
	}
}
