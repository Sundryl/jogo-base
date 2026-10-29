public interface ISettlementEffectV2
{
	int SourceGoalId { get; }

	WarGoalTypeV2 SourceGoalType { get; }

	int BeneficiaryStateId { get; }

	int TargetStateId { get; }

	SettlementEffectResultV2 Apply(WarV2 war, SettlementPlanV2 plan);
}
