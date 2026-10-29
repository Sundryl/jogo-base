using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using csDelaunay;

public class CellData
{
	[JsonProperty]
	public int CellCount { get; set; }

	[JsonProperty]
	public List<int> Elevation { get; set; }

	[JsonProperty]
	public List<float> Precipitation { get; set; }

	[JsonProperty]
	public List<float> Flux { get; set; }

	[JsonProperty]
	public List<int> River { get; set; }

	[JsonProperty]
	public List<float> Temperature { get; set; }

	[JsonProperty]
	public List<int> Biom { get; set; }

	[JsonProperty]
	public List<float> Moisture { get; set; }

	[JsonProperty]
	public List<float> Score { get; set; }

	[JsonProperty]
	public List<float> Population { get; set; }

	[JsonProperty]
	public List<float> Confluence { get; set; }

	[JsonProperty]
	public List<int> Haven { get; set; }

	[JsonProperty]
	public List<int> Harbor { get; set; }

	[JsonProperty]
	public List<int> Feature { get; set; }

	[JsonProperty]
	public List<int> Type { get; set; }

	[JsonProperty]
	public List<int> Culture { get; set; }

	[JsonProperty]
	public List<int> Burg { get; set; }

	[JsonIgnore]
	public List<int> Road { get; set; }

	[JsonIgnore]
	public List<int> CrossRoad { get; set; }

	[JsonProperty]
	public List<int> State { get; set; }

	[JsonIgnore]
	public List<int> Border { get; set; }

	[JsonProperty]
	public List<float> BattleScore { get; set; }

	[JsonProperty]
	public List<int> Province { get; set; }

	[JsonProperty]
	public List<int> DrawProvince { get; set; }

	[JsonIgnore]
	public List<List<Vector2f>> Vertices { get; set; }

	[JsonIgnore]
	public List<List<Vector2>> UVs { get; set; }

	[JsonIgnore]
	public List<List<int>> Triangles { get; set; }

	[JsonIgnore]
	public List<List<Vector3>> MeshVertices { get; set; }

	[JsonIgnore]
	public List<Vector3> WorldPos { get; set; }

	[JsonIgnore]
	public List<Vector2> Pos { get; set; }

	public List<SerializableVector2> SerializablePos { get; set; }

	[JsonIgnore]
	public List<List<int>> Neighbor { get; set; }

	[JsonIgnore]
	public List<Vector3> Normal { get; set; }

	[JsonProperty]
	public List<Feature> FeatureCulster { get; set; }

	[JsonConstructor]
	public CellData()
	{
	}

	public CellData(int CellCount)
	{
	}

	private static List<int> CreateFilledIntList(int _count, int _value)
	{
		return null;
	}

	private static List<float> CreateFilledFloatList(int _count, float _value)
	{
		return null;
	}

	private static List<Vector3> CreateFilledVector3List(int _count, Vector3 _value)
	{
		return null;
	}

	private static List<int> EnsureIntList(List<int> _list, int _count, int _defaultValue)
	{
		return null;
	}

	private static List<float> EnsureFloatList(List<float> _list, int _count, float _defaultValue)
	{
		return null;
	}

	private static List<Vector3> EnsureVector3List(List<Vector3> _list, int _count, Vector3 _defaultValue)
	{
		return null;
	}

	public void Init(int CellCount)
	{
	}

	public void ReInitMapData(int CellCount)
	{
	}

	public void ClickReInitMapData(int CellCount)
	{
	}

	public void PrepareToJson()
	{
	}

	public void PostLoadFromJson()
	{
	}
}
