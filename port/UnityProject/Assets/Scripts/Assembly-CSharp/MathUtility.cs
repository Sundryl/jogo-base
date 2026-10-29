using System.Collections.Generic;
using UnityEngine;
using csDelaunay;

public static class MathUtility
{
	public static double Rn(double v, int d = 0)
	{
		return 0.0;
	}

	public static double MinMax(double value, double min, double max)
	{
		return 0.0;
	}

	public static double Lim(double v)
	{
		return 0.0;
	}

	public static double Normalize(double val, double min, double max)
	{
		return 0.0;
	}

	public static double Lerp(double a, double b, double t)
	{
		return 0.0;
	}

	public static (float, float) CalculateLeastSquaresFit(List<Vector2f> points, bool firstPass)
	{
		return default;
	}

	public static Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default;
	}

	public static List<Vector3> CurveBasis(List<Vector3> points, int segmentCount)
	{
		return null;
	}

	public static float DistanceToLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd)
	{
		return 0f;
	}

	public static Vector3 ProjectPointOnLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd)
	{
		return default;
	}

	public static List<Vector3> CurveBasisClosed(List<Vector3> points, int segmentCount)
	{
		return null;
	}

	private static float[] Basis(float t)
	{
		return null;
	}

	private static bool IsClosed(List<Vector3> points)
	{
		return false;
	}

	public static Vector3 CalculateBezierDerivative(float t, Vector3 startPoint, Vector3 controlPoint, Vector3 endPoint)
	{
		return default;
	}
}
