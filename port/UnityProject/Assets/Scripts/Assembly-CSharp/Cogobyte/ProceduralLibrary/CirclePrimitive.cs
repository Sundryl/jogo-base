using System;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	[CreateAssetMenu(fileName = "CirclePrimitive", menuName = "Cogobyte/ProceduralLibrary/Primitives/CirclePrimitive", order = 2)]
	public class CirclePrimitive : Primitive
	{
		public float radius;

		[Range(3f, 80f)]
		public int numberOfSectors;

		[Range(1f, 80f)]
		public int numberOfSectorSections;

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
