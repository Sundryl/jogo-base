public class WarReparationsEffectV2 : ISettlementEffectV2
{
	private const float c_ReparationRatio = 0.5f;

	private const int c_ReparationIncomeMonths = 6;

	public int SourceGoalId { get; }

	public WarGoalTypeV2 SourceGoalType => WarGoalTypeV2.CedeProvince;

	public int BeneficiaryStateId { get; }

	public int TargetStateId { get; }

	public WarReparationsEffectV2(int sourceGoalId, int beneficiaryStateId, int targetStateId)
	{
	}

	public SettlementEffectResultV2 Apply(WarV2 war, SettlementPlanV2 plan)
	{
		return null;
	}

	private static State ResolveState(int stateId)
	{
		return null;
	}
}
