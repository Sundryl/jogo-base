using System;
using System.Collections.Generic;
using UnityEngine;
using csDelaunay;

public static class BorderCalculationHelper
{
	public static bool IsOnBorderCell(int cellIndex)
	{
		return false;
	}

	public static bool IsOnTopBorder(int cellIndex)
	{
		return false;
	}

	public static void IdentifyBorderCells<TData>(List<int> borderCells, TData[] dataCache, TData currentData, int cellIndex, Func<TData, bool> isValidData)
	{
	}

	public static void ExtractBorderSegments<TData>(List<int> borderCells, TData[] dataCache, TData currentData, Action<Vector2f, Vector2f> addBorderPoint)
	{
	}

	public static List<List<Vector2f>> ConnectBorderPoints(List<Vector2f> borderPoints)
	{
		return null;
	}

	public static List<List<Vector3>> SmoothBorderLines(List<List<Vector2f>> segments)
	{
		return null;
	}

	public static List<List<Vector2f>> ConnectBorderSegments(List<Tuple<Vector2f, Vector2f>> segments)
	{
		return null;
	}

	private static bool TriangleIsCCW(Vector2f a, Vector2f b, Vector2f c)
	{
		return false;
	}

	private static Vector3[] GetLineVertices(List<Vector2f> vertices, float z = -0.003f)
	{
		return null;
	}
}
