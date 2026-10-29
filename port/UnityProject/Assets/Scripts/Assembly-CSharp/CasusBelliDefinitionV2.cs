using System.Collections.Generic;

public class CasusBelliDefinitionV2
{
	public int Id;

	public string NameKey;

	public List<WarGoalTypeV2> AllowedGoalTypes;

	public bool IsDedicatedAnnexCB;

	public int AnnexThresholdProvinceCount;

	public bool IsInternalCB;

	public bool RequiresUnifierLeader;

	public int MinSameCultureCedeable;

	public bool ForceDecisiveCede;

	public bool AppliesCulturalUnifyBonus;

	public bool RequiresTheocraticAttackerReligiousConflict;

	public bool RequiresBlankConquerableDefender;

	private const float c_HostilityWeight = 0.08f;

	private const float c_ExpansionWeight = 0.08f;

	private const float c_AmbitionWeight = 0.04f;

	private const float c_CulturalUnifyWeight = 0.15f;

	private const float c_BlankOccupationBaseWeight = 0.58f;

	private const float c_BlankOccupationMaxWeight = 0.7f;

	private const float c_CedeAreaAdvantage = 0.65f;

	private const float c_ReparationsRiderChance = 0.35f;

	public bool CanUse(State attacker, State defender)
	{
		return false;
	}

	private bool IsVassalizeFeasible(State defender)
	{
		return false;
	}

	private bool IsAnnexFeasible(State defender)
	{
		return false;
	}

	public List<WarGoalInstanceV2> BuildDefaultGoals(State attacker, State defender)
	{
		return null;
	}

	private static int ChooseOccupyCount(State attacker, State defender, int cedeableCount)
	{
		return 0;
	}

	private static float StrengthAdvantage(State attacker, State defender)
	{
		return 0f;
	}

	public float EvaluateAiWeight(State attacker, State defender)
	{
		return 0f;
	}

	internal static WarGoalInstanceV2 BuildAnnexGoal(int attackerId, int defenderId)
	{
		return null;
	}

	internal static WarGoalInstanceV2 BuildVassalizeGoal(int attackerId, int defenderId)
	{
		return null;
	}

	internal static WarGoalInstanceV2 BuildEnforceReligionGoal(int attackerId, int defenderId)
	{
		return null;
	}

	internal static WarGoalInstanceV2 BuildReparationsGoal(int attackerId, int defenderId, List<int> borderProvinces, bool isPrimary)
	{
		return null;
	}
}
