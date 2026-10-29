using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[CreateAssetMenu(fileName = "BrokenSelectionIndicatorPath", menuName = "Cogobyte/ProceduralIndicators/Selection/BrokenSelectionIndicatorPath", order = 3)]
	public class BrokenSelectionIndicatorPath : NormalSelectionIndicatorPath
	{
		[Range(1E-05f, 1000f)]
		public int numberOfBrokenLines;

		[Range(0f, 1f)]
		public float percentageOfEmptySpace;

		protected List<int> brokenOpenClosePath;

		public override void generate()
		{
		}

		public override void GenerateVertices()
		{
		}

		public override void GenerateLowerVertsSmooth()
		{
		}

		public override void GenerateTriangles()
		{
		}

		public override void GenerateSideTriangles(int startVertIndexFirst, int startVertIndexSecond)
		{
		}

		public override void GenerateBottomTriangles(int startVertIndex)
		{
		}
	}
}
