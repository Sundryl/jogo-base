using System;

namespace UGCVectorPrototype
{
	[Serializable]
	public class UGCVectorIconMeshData
	{
		public float[] vertices;

		public int[] triangles;

		public float[] colors;

		public float[] bary;

		public float[] edgeMask;

		public int[] partId;
	}
}
