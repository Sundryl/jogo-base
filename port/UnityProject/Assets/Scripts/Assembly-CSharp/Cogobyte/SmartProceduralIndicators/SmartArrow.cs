using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[RequireComponent(typeof(MeshFilter))]
	[RequireComponent(typeof(MeshRenderer))]
	public class SmartArrow : MonoBehaviour
	{
		public List<ArrowRenderer> arrowRenderers;

		public ArrowPath arrowPath;

		public float StartPercentage;

		public float EndPercentage;

		public ArrowTip arrowTail;

		public ArrowTip arrowHead;

		public float displacement;

		public List<MultiBodyItem> bodyRenderers;

		private Transform arrowTransform;

		private int m_bodyIndex;

		private float m_bodyChunkLength;

		private BodyRendererInputData m_bodyChunkData;

		private BodyAndTipPathData m_bodyTipData;

		public void Awake()
		{
		}

		public GameObject AddMeshFilter(Material material)
		{
			return null;
		}

		public void Validate()
		{
		}

		public void OnValidate()
		{
		}

		public void UpdateArrow(bool updatePath = true, bool updateBodyTipData = true)
		{
		}

		private void GenerateMultiBodySwitch(ref float PathChunkLength)
		{
		}
	}
}
