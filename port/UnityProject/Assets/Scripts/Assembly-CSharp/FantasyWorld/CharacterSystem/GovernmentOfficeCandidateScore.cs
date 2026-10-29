namespace FantasyWorld.CharacterSystem
{
	public sealed class GovernmentOfficeCandidateScore
	{
		public Character Character { get; set; }

		public float TotalScore { get; set; }

		public float SkillScore { get; set; }

		public float AgeAdjustment { get; set; }

		public float CultureAndReligionAdjustment { get; set; }

		public float FamilyAdjustment { get; set; }

		public float GovernmentAdjustment { get; set; }

		public float WorkloadAdjustment { get; set; }

		public float TraitAdjustment { get; set; }

		public float GenderAdjustment { get; set; }
	}
}
