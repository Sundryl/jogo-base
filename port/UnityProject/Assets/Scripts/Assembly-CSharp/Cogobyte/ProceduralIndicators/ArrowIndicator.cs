using System;
using Cogobyte.ProceduralLibrary;
using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[Serializable]
	public class ArrowIndicator : SolidMesh
	{
		[SerializeField]
		public ArrowPath arrowPath;

		public ComplexExtrude extrudeObject;

		private int extrudePathIndex;

		[NonSerialized]
		public bool saveToSolid;

		public void generateArrowTail()
		{
		}

		public void generateArrowPath()
		{
		}

		public void generateArrowHead()
		{
		}

		public override void generate()
		{
		}
	}
}
