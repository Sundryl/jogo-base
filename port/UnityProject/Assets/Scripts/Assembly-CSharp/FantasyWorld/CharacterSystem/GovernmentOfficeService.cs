using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	public static class GovernmentOfficeService
	{
		public static GovernmentOfficeAssignment GetAssignment(State _state, string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind = GovernmentOfficeWarSystemKind.None)
		{
			return null;
		}

		public static Character GetHolder(State _state, string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind = GovernmentOfficeWarSystemKind.None)
		{
			return null;
		}

		public static bool CanAppointHolder(State _state, Character _holder, string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind, bool _allowEmergencyWarReuse, out string _failureReason)
		{
			_failureReason = null;
			return false;
		}

		internal static bool IsSlotValidForAppointment(State _state, string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind, out string _failureReason)
		{
			_failureReason = null;
			return false;
		}

		internal static bool CanAppointHolderForValidSlot(State _state, Character _holder, GovernmentOfficeDefinition _definition, string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind, bool _allowEmergencyWarReuse, List<GovernmentOfficeAssignment> _holderAssignments, out string _failureReason)
		{
			_failureReason = null;
			return false;
		}

		private static bool CanAppointHolderInternal(State _state, Character _holder, string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind, bool _allowEmergencyWarReuse, out string _failureReason)
		{
			_failureReason = null;
			return false;
		}

		public static GovernmentOfficeAssignment Appoint(State _state, string _officeId, int _holderCharacterId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind = GovernmentOfficeWarSystemKind.None, bool _isPlayerLocked = false, GovernmentOfficeAppointmentSource _appointmentSource = GovernmentOfficeAppointmentSource.AI)
		{
			return null;
		}

		private static GovernmentOfficeAssignment AppointInternal(State _state, string _officeId, int _holderCharacterId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind, bool _isPlayerLocked, GovernmentOfficeAppointmentSource _appointmentSource)
		{
			return null;
		}

		public static bool Dismiss(State _state, string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind = GovernmentOfficeWarSystemKind.None, string _reason = "dismissed")
		{
			return false;
		}

		public static bool DismissWarOffice(State _state, int _warId, GovernmentOfficeWarSystemKind _warSystemKind, string _reason = "war_ended")
		{
			return false;
		}

		public static int DismissAllForCharacter(Character _character, string _reason)
		{
			return 0;
		}

		public static int DismissAllForState(State _state, string _reason)
		{
			return 0;
		}

		public static void OnProvinceStateChanged(Province _province, State _oldState, State _newState)
		{
		}

		public static void OnDistrictRemoved(int _districtId)
		{
		}

		public static void OnDistrictsRegenerated()
		{
		}

		public static void ReconcileAllStates()
		{
		}

		public static void ReconcileState(State _state, bool _repairStaleRoleMirrors = true)
		{
		}

		private static void ReconcileStateInternal(State _state, bool _repairStaleRoleMirrors)
		{
		}

		private static bool HasDuplicateAssignments(State _state)
		{
			return false;
		}

		private static void ResolveDuplicateAssignments(State _state)
		{
		}

		public static bool IsDistrictAdministrableByState(int _districtId, State _state)
		{
			return false;
		}

		private static bool ValidateOfficeAndScope(State _state, string _officeId, GovernmentOfficeScopeKind _scopeKind, int _scopeId, GovernmentOfficeWarSystemKind _warSystemKind, out string _failureReason)
		{
			_failureReason = null;
			return false;
		}

		private static bool IsAssignmentStructurallyValid(State _state, GovernmentOfficeAssignment _assignment)
		{
			return false;
		}

		private static bool IsHolderStructurallyValid(Character _holder, State _state)
		{
			return false;
		}

		private static bool IsProvinceOwnedByState(Province _province, State _state)
		{
			return false;
		}

		private static bool DismissAssignment(State _state, GovernmentOfficeAssignment _assignment, string _reason)
		{
			return false;
		}

		private static void EnsureRoleMirror(State _state, GovernmentOfficeAssignment _assignment)
		{
		}

		private static GovernmentOfficeRole CreateRoleMirror(GovernmentOfficeAssignment _assignment)
		{
			return null;
		}

		private static void RemoveStaleRoleMirrors(State _state)
		{
		}

		private static void RemoveAllStaleRoleMirrors()
		{
		}

		private static string BuildRoleKey(int _holderId, GovernmentOfficeAssignment _assignment)
		{
			return null;
		}

		private static string BuildRoleKey(int _holderId, GovernmentOfficeRole _role)
		{
			return null;
		}
	}
}
