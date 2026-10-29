using System;

[Serializable]
public class WarGoalInstanceV2
{
	public int Id;

	public WarGoalTypeV2 GoalType;

	public int AddedByStateId;

	public int TargetStateId;

	public int BeneficiaryStateId;

	public WarTargetScopeV2 TargetScope;

	public bool IsPrimaryGoal;

	public bool IsEnforceable()
	{
		return false;
	}
}
