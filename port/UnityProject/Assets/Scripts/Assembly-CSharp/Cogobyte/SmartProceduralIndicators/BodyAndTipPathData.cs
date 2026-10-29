using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public class BodyAndTipPathData
	{
		public Vector3 bodyStartPoint;

		public int bodyStartIndex;

		public Quaternion bodyStartRotation;

		public Vector3 bodyEndPoint;

		public int bodyEndIndex;

		public Quaternion bodyEndRotation;

		public List<Vector3> calculatedPath;

		public List<Quaternion> calculatedRotations;

		public Vector3 PathStartPoint;

		public int pathStartIndex;

		public Vector3 PathEndPoint;

		public int pathEndIndex;

		public bool noBody;

		public bool noRender;

		public float sizeFactor;

		public float bodyLength;
	}
}
