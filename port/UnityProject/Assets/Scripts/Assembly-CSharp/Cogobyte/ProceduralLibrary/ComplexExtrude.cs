using System;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	public class ComplexExtrude : SolidMesh
	{
		public Primitive[] polygonsToExtrude;

		public Matrix4x4[] extrudePath;

		public int[] openCloseExtrude;

		public float uvMidBorder;

		[NonSerialized]
		public int vertexNumber;

		[NonSerialized]
		public int trisNumber;

		[NonSerialized]
		public int vertIndex;

		[NonSerialized]
		public int trisIndex;

		[NonSerialized]
		public int uvIndex;

		[NonSerialized]
		public float maxPathLength;

		[NonSerialized]
		public float currentPathLength;

		[NonSerialized]
		public Outline[] nextOutline;

		[NonSerialized]
		public Outline[] previousOutline;

		public bool useShapeColors;

		public Gradient[] colorFunctions;

		public virtual void generateOutlineVertices(int polyIndex)
		{
		}

		public virtual void generateShapeVertices(int polyIndex, bool startShape)
		{
		}

		private void generateOutlineTriangles(int polyIndex)
		{
		}

		private void generateBeginShapeTriangles(int polyIndex, int beforeVertIndex)
		{
		}

		private void generateEndShapeTriangles(int polyIndex, int beforeVertIndex)
		{
		}

		public void extrudeOnePart(int polyIndex)
		{
		}

		public int findStartIndex(Outline[] outline, Vector3 angleVector)
		{
			return 0;
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
