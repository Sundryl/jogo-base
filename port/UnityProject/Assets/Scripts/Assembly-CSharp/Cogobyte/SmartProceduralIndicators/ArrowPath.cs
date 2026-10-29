using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public abstract class ArrowPath : MonoBehaviour
	{
		public bool local;

		public bool obstacleCheck;

		public LayerMask obstacleCheckLayer;

		public float distanceFromObstacle;

		public float obstacleCheckRayLength;

		protected List<Vector3> calculatedPath;

		protected List<Quaternion> calculatedRotations;

		protected float m_pathLength;

		protected Transform m_myTransform;

		public List<Vector3> GetCalculatedPath()
		{
			return null;
		}

		public List<Quaternion> GetCalculatedRotation()
		{
			return null;
		}

		public float GetPathLength()
		{
			return 0f;
		}

		public virtual void GetBodyAndTipData(SmartArrow smartArrow, BodyAndTipPathData bodyTipPathData)
		{
		}

		public abstract void CalculatePath();

		public virtual void CalculatePathLength()
		{
		}

		public virtual void ObstacleCheck()
		{
		}

		public virtual void ConvertToLocal()
		{
		}
	}
}
