using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "FontDropdownCatalog", menuName = "UI/Font Dropdown Catalog")]
public sealed class FontDropdownCatalog : ScriptableObject
{
	[Serializable]
	public sealed class FontEntry
	{
		public string Id;

		public string DisplayName;

		public TMP_FontAsset FontAsset;
	}

	[SerializeField]
	private List<FontEntry> m_Fonts;

	private static FontDropdownCatalog s_CachedInstance;

	public IReadOnlyList<FontEntry> Entries => null;

	public static FontDropdownCatalog Load()
	{
		return null;
	}

	public FontEntry FindEntry(string id)
	{
		return null;
	}

	public bool TryGetFont(string id, out TMP_FontAsset fontAsset)
	{
		fontAsset = null;
		return false;
	}
}
