using System.Collections.Generic;
using Shapes;
using UnityEngine;

namespace UGCVectorPrototype
{
	public struct UGCVectorStrokePath
	{
		public List<Vector2> points;

		public Color color;

		public float thickness;

		public bool closed;

		public PolylineJoins joins;

		public LineEndCap endCap;

		public bool drawBehindFill;
	}
}
