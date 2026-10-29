using System;
using Cogobyte.ProceduralLibrary;
using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[Serializable]
	public class SelectionIndicatorPath : SolidMesh
	{
		public PathArray pathArray;

		public void prepareGradient(ref Gradient grad)
		{
		}
	}
}
