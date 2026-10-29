using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using csDelaunay;

[Serializable]
public class District
{
	public int id;

	public Dictionary<string, string> translatedNames;

	public string colorString;

	public bool useCustomColor;

	public string autoAssignedColorString;

	public List<int> provinceIDs;

	public int centerProvinceID;

	[JsonIgnore]
	public List<Province> provinces;

	[JsonIgnore]
	public Vector2f polePos;

	[JsonIgnore]
	public int poleCellIndex;

	[JsonIgnore]
	public GameObject districtLabelObject;

	[JsonIgnore]
	public bool isNeedNameLabelUpdate;

	[JsonIgnore]
	public bool isNeedBorderLineUpdate;

	[JsonIgnore]
	public string DisplayName => null;

	public bool IsDistrictPresentInWorld()
	{
		return false;
	}

	public void SetDistrictLabelTriggerCheck(bool isActive)
	{
	}

	public void SetNewName(string newName)
	{
	}

	public void SetTranslatedNames(Dictionary<string, string> names)
	{
	}

	public bool TryGetColor(out Color color)
	{
		color = default;
		return false;
	}

	public void SetColor(Color color)
	{
	}

	public void ClearColor()
	{
	}

	public string GetTranslatedName(string language)
	{
		return null;
	}

	public string Serialize()
	{
		return null;
	}

	public District CloneForSnapshot()
	{
		return null;
	}

	public static District Deserialize(string json)
	{
		return null;
	}

	public void PostLoadSaveData()
	{
	}

	private static string ResolveLanguageOrDefault()
	{
		return null;
	}
}
