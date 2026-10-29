using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[CreateAssetMenu(fileName = "Sphere", menuName = "Cogobyte/ProceduralLibrary/3DMeshes/Sphere", order = 3)]
	public class SphereMesh : SolidMesh
	{
		public float radius;

		[Range(1f, 80f)]
		public int numberOfSectionsParallel;

		[Range(3f, 80f)]
		public int numberOfSectionsMeridian;

		public Gradient[] gradient;

		private void OnValidate()
		{
		}

		public override int getVertexCount()
		{
			return 0;
		}

		public override int getTrisCount()
		{
			return 0;
		}

		public override void generate()
		{
		}
	}
}
