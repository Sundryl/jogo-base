using System.Collections.Generic;
using UnityEngine;

public static class PathUtility
{
	private const int c_BaseInterpolationPoints = 6;

	private const float c_PointsPerUnit = 1f;

	private const int c_MaxInterpolationPoints = 12;

	private static int CalculateInterpolationPoints(float _segmentLength)
	{
		return 0;
	}

	public static List<Vector3> BuildSmoothPath(IReadOnlyList<Vector3> _points, float _curveAmount = 0.5f)
	{
		return null;
	}

	public static float GetPathLength(IReadOnlyList<Vector3> _path)
	{
		return 0f;
	}

	public static Vector3 SampleByDistance(IReadOnlyList<Vector3> _path, float _distance)
	{
		return default;
	}

	public static Vector2 SampleTangentDirByDistance(IReadOnlyList<Vector3> _path, float _distance)
	{
		return default;
	}
}
