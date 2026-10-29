using System;
using System.Collections.Generic;
using UnityEngine;

namespace Michsky.MUIP
{
	public class ListView : MonoBehaviour
	{
		[Serializable]
		public class ListItem
		{
			public string itemTitle;

			[HideInInspector]
			public ListRow row0;

			[HideInInspector]
			public ListRow row1;

			[HideInInspector]
			public ListRow row2;
		}

		[Serializable]
		public class ListRow
		{
			public RowType rowType;

			public Sprite rowIcon;

			public string rowText;

			public bool usePreferredWidth;

			public int preferredWidth;

			[Range(0.1f, 1f)]
			public float iconScale;
		}

		public enum RowType
		{
			Icon = 0,
			Text = 1
		}

		public enum RowCount
		{
			One = 0,
			Two = 1,
			Three = 2
		}

		public Transform itemParent;

		public GameObject itemPreset;

		public GameObject scrollbar;

		public bool initializeOnAwake;

		public bool showScrollbar;

		public RowCount rowCount;

		[SerializeField]
		public List<ListItem> listItems;

		private void Awake()
		{
		}

		public void InitializeItems()
		{
		}
	}
}
