using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public class BezierArrowPath : ArrowPath
	{
		public enum UpDirectionMode
		{
			RelativeToPath = 0,
			DefineEachPoint = 1,
			ConstantUp = 2,
			RelativeToPoint = 3,
			RelativeToLine = 4
		}

		[Serializable]
		public class BezierSpline
		{
			[SerializeField]
			public List<BezierSplinePoint> points;

			public int CurveCount => 0;

			public BezierControlPointMode GetControlPointMode(int index)
			{
				return BezierControlPointMode.Free;
			}

			public void SetControlPointMode(int index, BezierControlPointMode mode)
			{
			}

			public Vector3 GetPoint(int i, float t)
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

		[Serializable]
		public class BezierSplinePoint
		{
			public Vector3 position;

			public Vector3 inTangent;

			public Vector3 outTangent;

			public Vector3 inReferenceUp;

			public Vector3 outReferenceUp;

			public BezierControlPointMode controlPointMode;

			public void MovePoint(Vector3 destination)
			{
			}

			public void MoveInTangentControlPoint(Vector3 destination)
			{
			}

			public void MoveOutTangentControlPoint(Vector3 destination)
			{
			}
		}

		public enum BezierControlPointMode
		{
			Free = 0,
			Aligned = 1,
			Mirrored = 2
		}

		public BezierSpline bezierSpline;

		public int levelOfDetail;

		public Vector3 upDirection;

		public Vector3 upReferencePoint;

		public UpDirectionMode upDirectionType;

		public override void CalculatePath()
		{
		}

		private void OnValidate()
		{
		}

		public Vector3 GetNextUpVector(Vector3 point, Vector3 previousDirection, Vector3 nextDirection, Vector3 previousUpVector, Vector3 upVectorCandidate)
		{
			return default;
		}
	}
}
