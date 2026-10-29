using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public class ShapesBodyRenderer : BodyRenderer
	{
		[Serializable]
		public class MeshShape
		{
			public float spaceBefore;

			public float spaceAfter;

			public Vector3 offset;

			public Vector3 rotation;

			public Vector3 scale;

			public List<MeshItem> meshes;
		}

		public enum ShapesBodyRendererColorMode
		{
			ColorAlongBody = 0,
			ColorAlongBodyGradient = 1
		}

		public enum RemainingSpaceMode
		{
			Scale = 0,
			Hide = 1,
			Render = 2
		}

		public List<MeshShape> shapes;

		public ShapesBodyRendererColorMode colorMode;

		public List<PathColor> colors;

		public Gradient colorsGradient;

		public RemainingSpaceMode remainingSpaceMode;

		private float m_colorLength;

		private int m_colorIndex;

		private int m_shapeIndex;

		private float m_shapePathChunk;

		private float m_traveledBodyLength;

		public void OnValidate()
		{
		}

		public override float GetCurrentRoll()
		{
			return 0f;
		}

		public override Color32 GetCurrentColor()
		{
			return default;
		}

		public override int MaxMeshIndex()
		{
			return 0;
		}

		public override void InitializeOutline(List<ArrowRenderer> arrowRenderers, float bodyDisplacement, float colorDisplacement, float bodyLength)
		{
		}

		public override void GenerateBody(List<ArrowRenderer> arrowRenderers, BodyRendererInputData bodyChunkData, float generateLength)
		{
		}

		public override void GenerateBodyBreak(List<ArrowRenderer> arrowRenderers, BodyRendererInputData bodyChunkData, bool front)
		{
		}

		public override bool GenerateTailConnection(List<ArrowRenderer> arrowRenderers, BodyRendererInputData bodyChunkData, ArrowTip arrowTip)
		{
			return false;
		}

		public override bool GenerateHeadConnection(List<ArrowRenderer> arrowRenderers, BodyRendererInputData bodyChunkData, ArrowTip arrowTip)
		{
			return false;
		}
	}
}
