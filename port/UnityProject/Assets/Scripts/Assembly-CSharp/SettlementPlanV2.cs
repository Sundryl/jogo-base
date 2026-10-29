using System.Collections.Generic;

public class SettlementPlanV2
{
	public int WarId;

	public WarSideV2? WinnerSide;

	public WarSideV2? SettlementVictorSide;

	public Dictionary<int, WarOutcome> OutcomeByStateId;

	public List<int> EnforcedWarGoalIds;

	public List<ProvinceTransferTermV2> ProvinceTransfers;

	public List<ProvinceTransferTermV2> AppliedProvinceTransfers;

	public bool IsAnnexation;

	public List<ISettlementEffectV2> Effects;

	public List<SettlementEffectResultV2> EffectResults;
}
