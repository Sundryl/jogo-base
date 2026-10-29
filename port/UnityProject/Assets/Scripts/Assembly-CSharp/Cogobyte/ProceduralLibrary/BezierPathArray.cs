using System;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	[CreateAssetMenu(fileName = "BezierPathArray", menuName = "Cogobyte/ProceduralLibrary/PathArrays/BezierPathArray", order = 1)]
	public class BezierPathArray : PathArray
	{
		public BezierSpline bezierSpline;

		public int levelOfDetail;

		private void OnValidate()
		{
		}

		public override void CalculatePath()
		{
		}
	}
}
