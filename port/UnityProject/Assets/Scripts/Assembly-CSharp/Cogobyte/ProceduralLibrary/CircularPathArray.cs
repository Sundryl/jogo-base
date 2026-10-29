using System;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	[CreateAssetMenu(fileName = "CircularPathArray", menuName = "Cogobyte/ProceduralLibrary/PathArrays/CircularPathArray", order = 2)]
	public class CircularPathArray : PathArray
	{
		public float radius;

		[Range(3f, 250f)]
		public int levelOfDetail;

		private float height;

		public override void CalculatePath()
		{
		}
	}
}
