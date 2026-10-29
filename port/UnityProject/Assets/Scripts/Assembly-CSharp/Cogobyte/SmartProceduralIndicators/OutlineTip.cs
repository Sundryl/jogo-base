using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public class OutlineTip : ArrowTip
	{
		public enum OutlineTipColorMode
		{
			InputColor = 0,
			TwoColorGradient = 1,
			OutlineColor = 2,
			ColorPerEdge = 3,
			ColorPerPoint = 4
		}

		public bool followPath;

		public Outline outline;

		public Vector2 endPointSize;

		public OutlineTipColorMode colorMode;

		public Color32 startPointColor;

		public Color32 endPointColor;

		private List<int> vertexCount;

		private List<int> blockCounters;

		public override bool FollowsPath()
		{
			return false;
		}

		public override int MaxMeshIndex()
		{
			return 0;
		}

		public override void GenerateTip(List<ArrowRenderer> arrowRenderers, BodyAndTipPathData tipData, bool tail, bool renderBackFace, Color32 inputColor, float inputRoll)
		{
		}

		public override Color32 GetDefaultInputColor()
		{
			return default;
		}

		private void RenderVertices(List<ArrowRenderer> arrowRenderers, Vector3 position, Quaternion rotation, Vector2 scale, Color32 inputColor, float tipTravel, float inputRoll)
		{
		}

		private void RenderTriangles(List<ArrowRenderer> arrowRenderers)
		{
		}

		private void RenderStraightBlock(List<ArrowRenderer> arrowRenderers, Vector3 startPoint, Vector3 endPoint, Quaternion rotation, float startUv, float endUv, Vector2 startScale, Vector2 endScale, Color32 startColor, Color32 endColor)
		{
		}

		private void GenerateBackFace(List<ArrowRenderer> arrowRenderers, Vector3 position, Quaternion rotation, Vector3 scale, Color32 color)
		{
		}

		private void GenerateFrontFace(List<ArrowRenderer> arrowRenderers, Vector3 position, Quaternion rotation, Vector3 scale, Color32 color)
		{
		}
	}
}
