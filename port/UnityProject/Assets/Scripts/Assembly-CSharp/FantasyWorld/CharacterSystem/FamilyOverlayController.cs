using System.Collections.Generic;

namespace FantasyWorld.CharacterSystem
{
	public class FamilyOverlayController
	{
		private static FamilyOverlayController s_Instance;

		private readonly HashSet<int> m_FocusedFamilyIds;

		private int m_FocusedStateId;

		public static FamilyOverlayController Instance => null;

		public bool IsFocusActive => false;

		public int FocusedStateId => 0;

		public IReadOnlyCollection<int> FocusedFamilies => null;

		public void FocusStateFamilies(int stateId)
		{
		}

		public void FocusFamilies(IEnumerable<int> familyIds, int stateId = -1)
		{
		}

		public void FocusSingleFamily(int familyId)
		{
		}

		public void ClearFocus()
		{
		}

		public bool ShouldRenderFamily(int familyId)
		{
			return false;
		}

		private void NotifyVisibilityChanged()
		{
		}
	}
}
