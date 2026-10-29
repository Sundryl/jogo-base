namespace FantasyWorld.CharacterSystem
{
	public sealed class GovernmentOfficeDefinition
	{
		public string OfficeId { get; }

		public GovernmentOfficeCategory Category { get; }

		public GovernmentOfficeScopeKind ScopeKind { get; }

		public GovernmentOfficeAiProfile AiProfile { get; }

		public GovernmentOfficeEffectProfile EffectProfile { get; }

		public GovernmentOfficeDefinition(string _officeId, GovernmentOfficeCategory _category, GovernmentOfficeScopeKind _scopeKind, GovernmentOfficeAiProfile _aiProfile, GovernmentOfficeEffectProfile _effectProfile)
		{
		}
	}
}
