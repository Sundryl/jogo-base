using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[CreateAssetMenu(fileName = "CustomMesh", menuName = "Cogobyte/ProceduralLibrary/3DMeshes/CustomMesh", order = 2)]
	public class CustomMesh : SolidMesh
	{
		public Mesh customMesh;

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
