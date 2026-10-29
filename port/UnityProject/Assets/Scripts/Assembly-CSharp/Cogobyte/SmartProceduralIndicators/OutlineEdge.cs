using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[Serializable]
	public class OutlineEdge
	{
		[Min(0f)]
		public int meshIndex;

		public List<OutlineEdgePoint> points;

		public Color32 color;

		public OutlineEdge()
		{
		}

		public OutlineEdge(OutlineEdge edge)
		{
		}

		public void CaluclateNormals()
		{
		}

		public void SetPointsColors(Color32 color)
		{
		}

		public void SetPointsColors(Gradient gradient)
		{
		}

		public void FlipHorizontal()
		{
		}

		public void FlipVertical()
		{
		}

		public void FlipAxes()
		{
		}
	}
}
