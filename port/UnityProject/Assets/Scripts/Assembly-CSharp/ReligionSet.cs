using System;
using System.Collections.Generic;

[Serializable]
public class ReligionSet
{
	public string name;

	public string folderPath;

	public ReligionSetType type;

	public bool isVirtual;

	public List<Religion> religions;

	public int GetReligionCount()
	{
		return 0;
	}

	public bool ContainsReligion(string religionName)
	{
		return false;
	}

	public Religion GetReligionByName(string religionName)
	{
		return null;
	}

	public void AddReligion(Religion religion)
	{
	}

	public bool RemoveReligion(string religionName)
	{
		return false;
	}

	public string GetDisplayName()
	{
		return null;
	}
}
