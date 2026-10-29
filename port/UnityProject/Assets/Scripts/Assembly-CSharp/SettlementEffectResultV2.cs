public class SettlementEffectResultV2
{
	public int SourceGoalId;

	public WarGoalTypeV2 SourceGoalType;

	public int BeneficiaryStateId;

	public int TargetStateId;

	public SettlementEffectStatusV2 Status;

	public string Reason;

	public bool IsSuccessful => false;

	public static SettlementEffectResultV2 Create(ISettlementEffectV2 effect, SettlementEffectStatusV2 status, string reason = null)
	{
		return null;
	}
}
