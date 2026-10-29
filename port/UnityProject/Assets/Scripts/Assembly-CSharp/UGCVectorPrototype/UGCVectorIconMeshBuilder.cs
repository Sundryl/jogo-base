using UnityEngine;

namespace UGCVectorPrototype
{
	public static class UGCVectorIconMeshBuilder
	{
		public static bool BuildMesh(UGCVectorIconJsonData data, Mesh mesh)
		{
			return false;
		}

		private static bool ValidateMeshData(UGCVectorIconMeshData data, out int vertexCount)
		{
			vertexCount = default;
			return false;
		}
	}
}
