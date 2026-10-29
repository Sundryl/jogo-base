using System;

namespace UGCVectorPrototype
{
	[Serializable]
	public struct UGCVectorSvgImportOptions
	{
		public int curveSegments;

		public int circleSegments;

		public float mergePointEpsilon;

		public static UGCVectorSvgImportOptions Default => default;
	}
}
