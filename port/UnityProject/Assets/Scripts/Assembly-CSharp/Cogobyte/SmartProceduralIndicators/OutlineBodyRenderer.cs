using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public class OutlineBodyRenderer : BodyRenderer
	{
		public enum OutlineBodyRendererColorMode
		{
			ColorAlongBody = 0,
			ColorAlongBodyGradient = 1,
			OutlineColor = 2,
			ColorPerEdge = 3,
			ColorPerPoint = 4
		}

		public enum CurveFunctionMode
		{
			Fixed = 0,
			Function = 1,
			FunctionLength = 2
		}

		public Outline outline;

		public OutlineBodyRendererColorMode colorMode;

		public List<PathColor> colors;

		public Gradient colorsGradient;

		public Vector2 size;

		public float roll;

		public AnimationCurve[] curveFunction;

		public CurveFunctionMode[] curveModes;

		public int lod;

		public bool smoothPath;

		public bool scaleCorners;

		public bool dashed;

		public float emptyLength;

		public float dashLength;

		public List<BodyTipMeshItem> tailMeshConnector;

		public List<BodyTipMeshItem> headMeshConnector;

		private bool m_dashing;

		private bool m_switchDash;

		private float m_dashChunk;

		private int m_currentColorKey;

		private Color32 m_colorValue;

		private float[] m_curveCurrentValue;

		private float[] m_timeFormat;

		private int[] m_currentFunctionKey;

		private int m_nextLengthIndex;

		private float[] m_nextLength;

		private float m_bodyTraveled;

		private bool m_firstBlockRendered;

		private List<int> m_vertexCount;

		private List<int> m_blockCounters;

		private Vector2 m_lastTurnScale;

		private Quaternion m_lastTurnRotation;

		public void OnValidate()
		{
		}

		public override int MaxMeshIndex()
		{
			return 0;
		}

		public override float GetCurrentRoll()
		{
			return 0f;
		}

		public override Color32 GetCurrentColor()
		{
			return default;
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

		private Vector2 GetTurnScale(Quaternion lastRotation, Quaternion nextRotation)
		{
			return default;
		}

		private void RenderVertices(List<ArrowRenderer> arrowRenderers, Vector3 position, Quaternion rotation, Vector2 scale, Quaternion normalsRotation, float uvY)
		{
		}

		private void RenderTriangles(List<ArrowRenderer> arrowRenderers)
		{
		}

		private void ConsumeEmptySpace(float length, float bodyLength)
		{
		}

		private void AddExtrudedOutline(List<ArrowRenderer> arrowRenderers, Vector3 startPoint, Vector3 endPoint, Quaternion startRot, Quaternion endRot, Quaternion normalRotation, float uVY, Vector2 startScale, Vector2 endScale, bool smoothPath, float bodyLength)
		{
		}

		private void RenderTipConnector(List<ArrowRenderer> arrowRenderers, Vector3 position, Quaternion rotation, Vector3 innerScale, Vector3 outerScale, List<BodyTipMeshItem> tipConnectors)
		{
		}

		private void RenderBodyBreak(List<ArrowRenderer> arrowRenderers, Vector3 position, Quaternion rotation, List<MeshItem> breakMeshes)
		{
		}
	}
}
