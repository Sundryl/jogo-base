using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	public class BezierSpline
	{
		[SerializeField]
		public List<BezierSplinePoint> points;

		[SerializeField]
		public bool loop;

		public int CurveCount => 0;

		public BezierControlPointMode GetControlPointMode(int index)
		{
			return BezierControlPointMode.Free;
		}

		public void SetControlPointMode(int index, BezierControlPointMode mode)
		{
		}

		public Vector3 GetPoint(float t)
		{
			return default;
		}

		public Vector3 GetVelocity(float t)
		{
			return default;
		}

		public Vector3 GetDirection(float t)
		{
			return default;
		}

		public void DeleteCurve(int index)
		{
		}

		public void SplitCurve(int index)
		{
		}

		public void AddCurve()
		{
		}

		public void Reset()
		{
		}
	}
}
