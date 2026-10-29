using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public class PointListArrowPath : ArrowPath
	{
		public enum UpDirectionMode
		{
			RelativeToPath = 0,
			ConstantUp = 1,
			RelativeToPoint = 2,
			RelativeToLine = 3
		}

		public List<Vector3> customPath;

		public Vector3 upDirection;

		public Vector3 upReferencePoint;

		public UpDirectionMode upDirectionType;

		[Range(1f, 100f)]
		public int obstacleCheckLevelOfDetail;

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
