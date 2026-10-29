using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class MeshObject : MonoBehaviour
	{
		public ProceduralMesh generatedMesh;

		private void Update()
		{
		}
	}
}
