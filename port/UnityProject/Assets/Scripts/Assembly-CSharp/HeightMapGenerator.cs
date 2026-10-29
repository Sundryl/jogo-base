using System.Collections.Generic;

public class HeightMapGenerator
{
	private static readonly Dictionary<int, float> blobPowerMap;

	private static readonly Dictionary<int, float> linePowerMap;

	private World world;

	private List<int> heights;

	private float blobPower;

	private float linePower;

	private int graphWidth;

	private int graphHeight;

	public static float GetLinePower(int cells)
	{
		return 0f;
	}

	public static float GetBlobPower(int cells)
	{
		return 0f;
	}

	public HeightMapGenerator(World map)
	{
	}

	public void GenerateHeightMap(int templateID)
	{
	}

	private void GenerateFromTemplate(int id = 0)
	{
	}

	private void addHill(string count, string height, string rangeX, string rangeY)
	{
	}

	private void addPit(string count, string height, string rangeX, string rangeY)
	{
	}

	private void addRange(string count, string height, string rangeX, string rangeY)
	{
	}

	private void addTrough(string count, string height, string rangeX, string rangeY)
	{
	}

	private void addStrait(string w, string direction = "vertical")
	{
	}

	private void smooth(string Frequency = "2", string Add = "0")
	{
	}

	private void mask(string P = "1")
	{
	}

	private void addStep(string tool, string a2, string a3, string a4, string a5)
	{
	}

	public static float GetPointInRange(string range, float length)
	{
		return 0f;
	}

	private static float Rand(float min, float max)
	{
		return 0f;
	}

	private void Modify(string range, string Add = "0", string Mult = "1", string? Power = null)
	{
	}

	public void Modify(string range, float? add, float mult = 1f, float? power = null)
	{
	}

	public static Dictionary<int, int> GetHeightMap(HashSet<int> cells, int centerCell, int centerHeight)
	{
		return null;
	}

	public static List<int> PlaceHill(int centerCell, int h)
	{
		return null;
	}

	public static void ModifyCells(List<int> cells, string operation, float value, string range = "all")
	{
	}
}
