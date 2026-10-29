using UnityEngine;

namespace FantasyWorld.CharacterSystem
{
	public static class FamilyFateDecision
	{
		private class FateWeights
		{
			public float swearFealty;

			public float partialRestore;

			public float dispossessed;

			public float purged;

			public float exile;

			public void Normalize()
			{
			}
		}

		public static FamilyFate DecideFamilyFate(Family conqueredFamily, State conquerorState, State originalState, War war = null)
		{
			return FamilyFate.SwearFealty;
		}

		private static FateWeights CalculateFateWeights(Family family, State conqueror, State original, War war)
		{
			return null;
		}

		public static void ExecuteFamilyFate(Family family, FamilyFate fate, State conquerorState, int previousProvinceCount = -1, bool isRecordHistoryEvent = true)
		{
		}

		private static void ReduceFamilyWarMerit(Family family)
		{
		}

		private static void ExecuteSwearFealty(Family family, State newState, bool isRecordHistoryEvent = true)
		{
		}

		private static void ExecutePartialRestore(Family family, State conqueror, bool isRecordHistoryEvent = true)
		{
		}

		private static void ExecuteDispossessed(Family family, State conqueror, bool isRecordHistoryEvent = true)
		{
		}

		private static void ExecutePurge(Family family, bool isRecordHistoryEvent = true)
		{
		}

		private static bool CanReclaimProvince(Province province, Family reclaimingFamily, State conqueror)
		{
			return false;
		}

		private static float GetHistoricalClaimStrength(Family family, Province province)
		{
			return 0f;
		}

		private static float GetAverageProvinceCount(State state)
		{
			return 0f;
		}

		private static void GrantProvinceToFamily(Province province, Family family)
		{
		}

		private static void UpdateFamilyMembersAllegiance(Family family, State newState)
		{
		}

		private static Vector3 GetProvincePosition(int provinceId)
		{
			return default;
		}

		private static void ExecuteExile(Family family, State conquerorState, int previousProvinceCount = -1, bool isRecordHistoryEvent = true)
		{
		}
	}
}
