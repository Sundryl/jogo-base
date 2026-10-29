using System.Collections.Generic;
using Cogobyte.SmartProceduralIndicators;
using UnityEngine;

namespace Cogobyte.Demo.SmartProceduralIndicators
{
	public class BezierPathDemo : MonoBehaviour
	{
		public Color32 controlPointLineColor;

		public SmartArrow bezierArrow;

		public List<Transform> pointHandle;

		public List<Transform> inTangentHandle;

		public List<Transform> outTangentHandle;

		public GameObject positionHandlePrefab;

		public GameObject simpleLinePrefab;

		public List<SmartArrow> inTangentLine;

		public List<SmartArrow> outTangentLine;

		public void AddPoint()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
