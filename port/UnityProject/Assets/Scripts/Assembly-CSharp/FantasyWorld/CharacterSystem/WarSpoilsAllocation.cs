using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	public static class WarSpoilsAllocation
	{
		private class AllocationPlan : List<Allocation>
		{
		}

		private class Allocation
		{
			public Province province;

			public Family family;

			public float score;
		}

		public static void AllocateConqueredProvince(Province province, State conquerorState)
		{
		}

		private static bool TryImmediateAllocation(Province province, State conqueror)
		{
			return false;
		}

		private static Army FindConqueringArmy(Province province)
		{
			return null;
		}

		private static bool IsAdjacentToFamily(Province province, Family family)
		{
			return false;
		}

		public static void ProcessTerritorialRedistribution(State state)
		{
		}

		private static List<Province> GetPendingProvinces(State state)
		{
			return null;
		}

		private static List<Family> GetParticipatingFamilies(State state)
		{
			return null;
		}

		private static AllocationPlan CreateAllocationPlan(List<Province> provinces, List<Family> families, State state)
		{
			return null;
		}

		private static float CalculateProvinceValueForFamily(Province province, Family family, State state)
		{
			return 0f;
		}

		private static float CalculateGeographicalScore(Province province, Family family)
		{
			return 0f;
		}

		private static float CalculateProvinceProximity(int province1Id, int province2Id)
		{
			return 0f;
		}

		private static float CalculateBalanceScore(Family family, State state)
		{
			return 0f;
		}

		private static void ExecuteAllocationPlan(AllocationPlan plan)
		{
		}

		private static void GrantProvinceToFamily(Province province, Family family)
		{
		}

		private static void ResetFamilyRedistributionStatus(State state)
		{
		}
	}
}
