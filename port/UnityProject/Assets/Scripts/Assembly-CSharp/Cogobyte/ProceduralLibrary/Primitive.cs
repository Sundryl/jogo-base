using System;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	public abstract class Primitive : ProceduralMesh
	{
		public Outline[] outline;

		[NonSerialized]
		public float outlineMaxDistance;

		public bool twoSided;

		public Outline[] getOutline()
		{
			return null;
		}

		public virtual void updateOutline()
		{
		}

		public void generateOtherSide()
		{
		}
	}
}
