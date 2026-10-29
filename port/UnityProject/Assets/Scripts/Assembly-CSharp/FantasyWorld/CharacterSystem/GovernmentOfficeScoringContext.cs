using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	internal sealed class GovernmentOfficeScoringContext
	{
		private readonly State m_State;

		private List<Character> m_StateCharacters;

		private int m_AssignmentsVersion;

		private Dictionary<int, List<GovernmentOfficeAssignment>> m_AssignmentsByHolderId;

		private Dictionary<int, int> m_CentralOfficeCountByFamilyId;

		private Dictionary<int, float> m_RulingRelationAdjustmentByFamilyId;

		private Dictionary<long, float> m_DistrictGeoAdjustmentByDistrictAndFamily;

		private Dictionary<int, List<Province>> m_ProvincesByDistrictId;

		public State State => null;

		public Family RulingFamily { get; }

		public float GovernanceFactor { get; }

		public int LeaderId { get; }

		public List<Character> StateCharacters => null;

		public GovernmentOfficeScoringContext(State _state)
		{
		}

		public List<GovernmentOfficeAssignment> GetHolderAssignments(int _characterId)
		{
			return null;
		}

		public int GetCentralOfficeCountForFamily(int _familyId)
		{
			return 0;
		}

		public float GetRulingRelationAdjustment(Family _family)
		{
			return 0f;
		}

		public float GetDistrictGeoAdjustment(int _districtId, Family _family)
		{
			return 0f;
		}

		private List<Province> GetDistrictProvinces(int _districtId)
		{
			return null;
		}

		private void EnsureAssignmentDerivedData()
		{
		}
	}
}
