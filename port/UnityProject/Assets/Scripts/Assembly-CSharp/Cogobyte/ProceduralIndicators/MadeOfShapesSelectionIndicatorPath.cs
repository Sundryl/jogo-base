using System.Collections.Generic;
using Cogobyte.ProceduralLibrary;
using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[CreateAssetMenu(fileName = "MadeOfShapesSelectionIndicatorPath", menuName = "Cogobyte/ProceduralIndicators/Selection/MadeOfShapesSelectionIndicatorPath", order = 2)]
	public class MadeOfShapesSelectionIndicatorPath : SelectionIndicatorPath
	{
		public MeshesList customShapes;

		public List<float> SpaceTakenByShape;

		public bool useShapeColors;

		public Gradient colorFunction;

		private List<Color32> madeOfShapesColors;

		public override void generate()
		{
		}
	}
}
