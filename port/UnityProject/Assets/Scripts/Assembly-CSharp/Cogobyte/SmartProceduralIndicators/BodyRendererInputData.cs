using System;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[Serializable]
	public class BodyRendererInputData
	{
		public Vector3 startPosition;

		public Vector3 endPosition;

		public Quaternion lastRotation;

		public Quaternion rotation;

		public Quaternion nextRotation;

		public float chunkLength;

		public float traveledPath;

		public float bodyLength;

		public bool lastRender;
	}
}
