using System;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	[CreateAssetMenu(fileName = "PlanePrimitive", menuName = "Cogobyte/ProceduralLibrary/Primitives/PlanePrimitive", order = 3)]
	public class PlanePrimitive : Primitive
	{
		public float width;

		public float length;

		[Range(1f, 100f)]
		public int numberOfSectionsByWidth;

		[Range(1f, 100f)]
		public int numberOfSectionsByLength;

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

		public override void updateOutline()
		{
		}
	}
}
