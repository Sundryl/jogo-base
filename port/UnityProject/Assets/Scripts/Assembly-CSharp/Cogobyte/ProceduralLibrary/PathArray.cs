using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	public abstract class PathArray : ScriptableObject
	{
		public enum ObstacleCheckMode
		{
			None = 0,
			Parellel = 1,
			Projection = 2
		}

		[NonSerialized]
		public List<Vector3> path;

		public Vector3 translation;

		public Vector3 rotation;

		public Vector3 scale;

		public ObstacleCheckMode obstacleCheck;

		public Vector3 obstacleCheckDirection;

		public LayerMask obstacleLayer;

		public float distanceFromGround;

		[NonSerialized]
		public float maxPathLength;

		public bool closed;

		public bool counterClockwise;

		public virtual void CalculatePath()
		{
		}

		public void ObstacleCheck()
		{
		}

		public void ParralelObstacleCheck(List<Vector3> checkedPath)
		{
		}

		public void ProjectionObstacleCheck(List<Vector3> checkedPath)
		{
		}

		public void ParralelObstacleCheckPoint(ref Vector3 point)
		{
		}

		public void ProjectionObstacleCheckPoint(ref Vector3 point)
		{
		}
	}
}
