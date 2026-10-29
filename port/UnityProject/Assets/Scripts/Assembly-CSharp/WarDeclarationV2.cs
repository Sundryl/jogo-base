using System.Collections.Generic;

public class WarDeclarationV2
{
	public int AttackerId;

	public int DefenderId;

	public int CasusBelliId;

	public List<WarGoalInstanceV2> InitialGoals;

	public bool IsInternalWar;

	public WarType LegacyWarType;

	public int RebelStateId;

	public int MotherStateId;
}
