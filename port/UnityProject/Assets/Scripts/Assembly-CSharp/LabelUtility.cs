using System;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;

public static class LabelUtility
{
	public struct LabelSettings
	{
		public float FontSizeMax;

		public float FontSizeMin;

		public float Width;

		public float Height;

		public bool IsBold;

		public Vector3 Position;
	}

	private const string c_RuntimeLabelMaterialNamePrefix = "RuntimeLabelMaterial_";

	[JsonIgnore]
	private static float _nameLabelScale;

	[JsonIgnore]
	private static Color _nameLabelColor;

	[JsonIgnore]
	public static float NameLabelScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public static Color NameLabelColor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public static float CalculateLabelScale(int cellCount)
	{
		return 0f;
	}

	public static float CalculateFontSize(float scale)
	{
		return 0f;
	}

	public static LabelSettings CalculateLabelSettings(string text, float availableLength, float availableHeight, float scale, Vector3 position = default(Vector3))
	{
		return default;
	}

	public static void ApplyLabelSettings(TextMeshPro textMesh, LabelSettings settings, Color labelColor, string text, Color color = default(Color))
	{
	}

	public static void UpdateLabelMaterial(Color color, Material material)
	{
	}

	public static Color GetCustomLabelFaceColor(Color _textColor)
	{
		return default;
	}

	public static Color GetCustomLabelOutlineColor(Color _textColor, Color _outlineColor)
	{
		return default;
	}

	public static void ApplyCustomLabelVisual(TextMeshPro textMesh, Color textColor, Color outlineColor, float outlineWidth, float faceDilate = 0.12f)
	{
	}

	public static void ApplyCustomLabelVisual(TextMeshPro textMesh, Color baseColor)
	{
	}

	public static string GetStateLabelName(State state)
	{
		return null;
	}

	public static bool IsStatePassable(int stateId, int cell)
	{
		return false;
	}

	public static bool IsAlliancePassable(int allianceId, int cell)
	{
		return false;
	}

	public static bool IsReligionPassable(string religionId, int cell)
	{
		return false;
	}

	public static bool IsFamilyPassable(int familyId, int cell)
	{
		return false;
	}

	public static bool IsCulturePassable(string cultureName, int cell)
	{
		return false;
	}

	public static bool IsDistrictPassable(int districtId, int cell)
	{
		return false;
	}

	public static void GetAvailableLength<T>(T entityId, int cell, Func<T, int, bool> isPassableFunc, out int startCell, out int endCell, out float length)
	{
		startCell = default;
		endCell = default;
		length = default;
	}

	public static Color GetStateLabelColor(State state)
	{
		return default;
	}

	public static GameObject CreateNameLabel(string labelName, Color color, Vector3 position, float scale = -1f)
	{
		return null;
	}

	public static bool UpdateLabelByLocalization(TextMeshPro textMeshPro, Color color)
	{
		return false;
	}

	private static Material CreateRuntimeLabelMaterial(TMP_FontAsset font, Color color)
	{
		return null;
	}

	private static bool IsRuntimeLabelMaterial(Material material)
	{
		return false;
	}

	private static void DestroyRuntimeLabelMaterial(Material material, Material replacement = null)
	{
	}
}
