using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[CreateAssetMenu(fileName = "NormalSelectionIndicatorPath", menuName = "Cogobyte/ProceduralIndicators/Selection/NormalSelectionIndicatorPath", order = 1)]
	public class NormalSelectionIndicatorPath : SelectionIndicatorPath
	{
		public AnimationCurve outerWidthFunction;

		public float outerWidthFunctionLength;

		public AnimationCurve innerWidthFunction;

		public float innerWidthFunctionLength;

		public AnimationCurve heightFunction;

		public float heightFunctionLength;

		public Gradient innerColor;

		public Gradient outerColor;

		public bool is3D;

		public bool flatShading;

		public AnimationCurve lowerBoundFunction;

		public float lowerBoundFunctionLength;

		protected List<Vector3> lowerVertices;

		protected List<Vector3> vertices;

		protected List<int> triangles;

		protected List<Color32> vertColors;

		protected List<Vector3> upNormals;

		protected List<Vector3> sideNormals;

		public override void generate()
		{
		}

		public virtual void TransformOffsetVertices()
		{
		}

		public virtual void TransformOffsetNormals()
		{
		}

		public virtual void GenerateVertices()
		{
		}

		public virtual void GenerateLowerVertsFlat()
		{
		}

		public virtual void GenerateLowerVertsSmooth()
		{
		}

		public virtual void GenerateTriangles()
		{
		}

		public virtual void GenerateSideTriangles(int startVertIndexFirst, int startVertIndexSecond)
		{
		}

		public virtual void GenerateBottomTriangles(int startVertIndex)
		{
		}
	}
}
