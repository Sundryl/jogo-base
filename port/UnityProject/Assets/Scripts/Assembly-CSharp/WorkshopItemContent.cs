using System.Collections.Generic;
using UnityEngine;

public class WorkshopItemContent
{
	public const string TAG_MAP = "Map";

	public string contentFolderPath;

	public string itemTitle;

	public string itemDescription;

	public Texture2D previewImage;

	public string ImagePath;

	public List<string> itemTags;

	public ulong workshopId;

	public string changeNote;
}
