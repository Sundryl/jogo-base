public class ReformGovernmentEffectV2 : ISettlementEffectV2
{
	public int SourceGoalId { get; }

	public WarGoalTypeV2 SourceGoalType => WarGoalTypeV2.CedeProvince;

	public int BeneficiaryStateId { get; }

	public int TargetStateId { get; }

	public ReformGovernmentEffectV2(int sourceGoalId, int beneficiaryStateId, int targetStateId)
	{
	}

	public SettlementEffectResultV2 Apply(WarV2 war, SettlementPlanV2 plan)
	{
		return null;
	}
}
