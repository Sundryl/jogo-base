using System;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[Serializable]
	public class OutlineEdgePoint
	{
		public Vector2 position;

		public Vector2 normal;

		public Color32 color;

		public OutlineEdgePoint()
		{
		}

		public OutlineEdgePoint(OutlineEdgePoint point)
		{
		}
	}
}
