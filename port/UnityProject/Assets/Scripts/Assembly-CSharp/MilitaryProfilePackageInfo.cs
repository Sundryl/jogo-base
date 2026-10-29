using System;

[Serializable]
public class MilitaryProfilePackageInfo
{
	public string Key { get; set; }

	public string DisplayName { get; set; }

	public string FolderName { get; set; }

	public string PackageRootPath { get; set; }

	public string WorkshopItemId { get; set; }

	public string TooltipText { get; set; }

	public MilitaryProfilePackageSource Source { get; set; }
}
