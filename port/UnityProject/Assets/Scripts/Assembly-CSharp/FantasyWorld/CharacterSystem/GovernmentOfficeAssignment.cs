using System;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class GovernmentOfficeAssignment
	{
		public string OfficeId;

		public int HolderCharacterId;

		public int StateId;

		public GovernmentOfficeScopeKind ScopeKind;

		public int ScopeId;

		public GovernmentOfficeWarSystemKind WarSystemKind;

		public double StartTime;

		public bool IsPlayerLocked;

		public GovernmentOfficeAppointmentSource AppointmentSource;

		public PoliticalSystem PoliticalSystemAtAppointment;

		public bool Matches(string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind = GovernmentOfficeWarSystemKind.None)
		{
			return false;
		}

		public string GetIdentityKey()
		{
			return null;
		}

		public static string BuildIdentityKey(string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind)
		{
			return null;
		}

		public static GovernmentOfficeWarSystemKind NormalizeWarSystemKind(GovernmentOfficeScopeKind _scopeKind, GovernmentOfficeWarSystemKind _warSystemKind)
		{
			return GovernmentOfficeWarSystemKind.None;
		}
	}
}
