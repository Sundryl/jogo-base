using System.Collections.Generic;
using FantasyWorld.CharacterSystem;

public static class GovernmentOfficeEffects
{
	private const float c_CentralIncomeCombinedCap = 0.12f;

	private const float c_LocalIncomeCombinedCap = 0.12f;

	public static float GetCentralIncomeMultiplier(State _state)
	{
		return 0f;
	}

	public static float GetGovernorIncomeMultiplier(Province _province)
	{
		return 0f;
	}

	public static float GetGovernorRebellionChanceMultiplier(Province _province)
	{
		return 0f;
	}

	public static float GetDistrictGovernorIncomeMultiplier(Province _province)
	{
		return 0f;
	}

	public static float GetDistrictGovernorRebellionChanceMultiplier(Province _province)
	{
		return 0f;
	}

	public static float GetLocalIncomeMultiplier(Province _province)
	{
		return 0f;
	}

	public static float GetLocalRebellionChanceMultiplier(Province _province)
	{
		return 0f;
	}

	public static float GetAverageLocalRebellionChanceMultiplier(State _state, IEnumerable<Province> _candidateProvinces)
	{
		return 0f;
	}

	public static float GetMilitaryLeadershipSkill(State _state, Campaign _campaign)
	{
		return 0f;
	}

	public static Character GetMilitaryLeader(State _state, Campaign _campaign)
	{
		return null;
	}

	public static float CalculateSkillSuitability(string _officeId, Character _character)
	{
		return 0f;
	}

	public static float CalculateNormalizedSuitability(string _officeId, Character _character)
	{
		return 0f;
	}

	private static float GetNormalizedDistrictGovernorSuitability(Province _province)
	{
		return 0f;
	}

	private static float GetNormalizedOfficeSuitability(State _state, string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId)
	{
		return 0f;
	}

	private static bool IsValidHolder(Character _character, State _state)
	{
		return false;
	}

	private static GovernmentOfficeEffectProfile GetEffectProfile(string _officeId)
	{
		return null;
	}
}
