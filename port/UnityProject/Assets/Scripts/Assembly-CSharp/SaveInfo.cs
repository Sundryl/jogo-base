using System;

public class SaveInfo
{
	public string Id { get; private set; }

	public DateTime SaveTime { get; private set; }

	public string FileName { get; private set; }

	public string FilePath { get; private set; }

	public string WorkshopFilePath => null;

	public bool IsWorkshopItem { get; private set; }

	public SaveInfo(string fileName, DateTime saveTime, bool isWorkshopItem, string filePath)
	{
	}
}
