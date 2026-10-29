using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[Serializable]
	public abstract class BodyRenderer : MonoBehaviour
	{
		public abstract void InitializeOutline(List<ArrowRenderer> arrowRenderers, float bodyDisplacement, float colorDisplacement, float bodyLength);

		public abstract void GenerateBody(List<ArrowRenderer> arrowRenderers, BodyRendererInputData bodyChunkData, float generateLength);

		public abstract void GenerateBodyBreak(List<ArrowRenderer> arrowRenderers, BodyRendererInputData bodyChunkData, bool front);

		public abstract bool GenerateTailConnection(List<ArrowRenderer> arrowRenderers, BodyRendererInputData bodyChunkData, ArrowTip arrowTip);

		public abstract bool GenerateHeadConnection(List<ArrowRenderer> arrowRenderers, BodyRendererInputData bodyChunkData, ArrowTip arrowTip);

		public abstract float GetCurrentRoll();

		public abstract Color32 GetCurrentColor();

		public abstract int MaxMeshIndex();

		public static void SetColorsToGradient(List<PathColor> colors, Gradient colorsGradient)
		{
		}
	}
}
