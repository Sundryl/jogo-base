using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public class PointToPointArrowPath : ArrowPath
	{
		public Vector3 pointA;

		public Vector3 pointB;

		public Vector3 upDirection;

		[Range(1f, 100f)]
		public int obstacleCheckLevelOfDetail;

		public override void CalculatePath()
		{
		}
	}
}
