using System;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class GovernmentOfficeRole : Role
	{
		public string OfficeId;

		public int StateId;

		public GovernmentOfficeScopeKind ScopeKind;

		public int ScopeId;

		public GovernmentOfficeWarSystemKind WarSystemKind;

		public PoliticalSystem PoliticalSystemAtAppointment;

		public bool Matches(GovernmentOfficeAssignment _assignment)
		{
			return false;
		}

		public bool Matches(int _stateId, string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind)
		{
			return false;
		}

		public override float GetPowerScore()
		{
			return 0f;
		}
	}
}
