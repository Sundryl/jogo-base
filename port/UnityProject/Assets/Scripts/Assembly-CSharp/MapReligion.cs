using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using csDelaunay;

[Serializable]
public class MapReligion
{
	[JsonProperty]
	private Religion m_Religion;

	[JsonIgnore]
	public int holyProvinceId;

	[JsonIgnore]
	public GameObject religionLabel;

	[JsonIgnore]
	public bool isNeedNameLabelUpdate;

	[JsonIgnore]
	public bool isNeedBorderLineUpdate;

	[JsonIgnore]
	public Vector2f polePos;

	[JsonIgnore]
	public int poleCellIndex;

	[JsonIgnore]
	public Religion Religion => null;

	public MapReligion()
	{
	}

	public MapReligion(string _religionId)
	{
	}

	private Religion CloneReligion(Religion source)
	{
		return null;
	}

	public Color GetReligionColor()
	{
		return default;
	}

	public void SetReligionColor(Color _color)
	{
	}

	public void SetTranslatedName(string translatedName, string language)
	{
	}

	public void AddPractice(string _practice)
	{
	}

	public void RemovePractice(string _practice)
	{
	}

	public List<string> GetAllPracticeKeys()
	{
		return null;
	}

	public bool IsReligionPresentInWorld()
	{
		return false;
	}

	public void SetReligionLabelTriggerCheck(bool isActive)
	{
	}

	public void Clear()
	{
	}

	public string Serialize()
	{
		return null;
	}

	public static MapReligion Deserialize(string json)
	{
		return null;
	}

	public void PostDeserialize()
	{
	}
}
