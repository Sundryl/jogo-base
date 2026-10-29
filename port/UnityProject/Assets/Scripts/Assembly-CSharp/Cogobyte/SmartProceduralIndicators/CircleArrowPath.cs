using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public class CircleArrowPath : ArrowPath
	{
		public Vector3 center;

		public Vector3 radius;

		public Vector3 axis;

		[Range(3f, 100f)]
		public int levelOfDetail;

		public float startAngle;

		public float endAngle;

		public float upDirectionRollAngle;

		public override void CalculatePath()
		{
		}
	}
}
