using UnityEngine;

namespace Michsky.MUIP
{
	public class ListViewItem : MonoBehaviour
	{
		[Header("Settings")]
		public ListViewRow row0;

		public ListViewRow row1;

		public ListViewRow row2;

		[Header("References")]
		public ListView.RowCount rowCount;

		public ListView.ListRow row0Ref;

		public ListView.ListRow row1Ref;

		public ListView.ListRow row2Ref;

		public void PassReferences()
		{
		}
	}
}
