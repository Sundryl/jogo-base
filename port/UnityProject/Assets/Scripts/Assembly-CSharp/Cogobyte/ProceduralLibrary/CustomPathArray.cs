using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	[CreateAssetMenu(fileName = "CustomPathArray", menuName = "Cogobyte/ProceduralLibrary/PathArrays/CustomPathArray", order = 1)]
	public class CustomPathArray : PathArray
	{
		public List<Vector3> customPath;

		[Range(1f, 100f)]
		public int levelOfDetailAlongPath;

		private static float errorRate;

		private void OnValidate()
		{
		}

		public override void CalculatePath()
		{
		}
	}
}
