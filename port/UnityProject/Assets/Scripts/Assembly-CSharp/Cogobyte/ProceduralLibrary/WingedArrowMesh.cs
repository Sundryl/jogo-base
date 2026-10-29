using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[CreateAssetMenu(fileName = "WingedArrowMesh", menuName = "Cogobyte/ProceduralLibrary/3DMeshes/WingedArrowMesh", order = 4)]
	public class WingedArrowMesh : SolidMesh
	{
		public float length;

		public float leftLength;

		public float rightLength;

		public float leftWingWidth;

		public float rightWingWidth;

		public float startWidth;

		public float endWidth;

		public float leftBackDistance;

		public float rightBackDistance;

		public Color32 leftColor;

		public Color32 color;

		public Color32 rightColor;

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
