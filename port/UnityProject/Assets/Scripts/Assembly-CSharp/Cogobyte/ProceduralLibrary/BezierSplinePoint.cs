using System;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	public class BezierSplinePoint
	{
		public Vector3 position;

		public Vector3 backControlPoint;

		public Vector3 frontControlPoint;

		public BezierControlPointMode controlPointMode;

		public void MovePoint(Vector3 destination)
		{
		}

		public void MoveFrontControlPoint(Vector3 destination)
		{
		}

		public void MoveBackControlPoint(Vector3 destination)
		{
		}
	}
}
