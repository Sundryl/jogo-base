using System;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[Serializable]
	public class ArrowRenderer
	{
		public ArrowMesh arrowMesh;

		public MeshFilter meshFilter;

		[HideInInspector]
		public int lastCachedVertex;

		[HideInInspector]
		public int lastCachedTriangle;
	}
}
