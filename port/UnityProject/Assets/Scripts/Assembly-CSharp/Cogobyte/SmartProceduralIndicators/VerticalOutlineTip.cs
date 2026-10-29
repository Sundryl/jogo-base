using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public class VerticalOutlineTip : ArrowTip
	{
		public enum VerticalOutlineTipColorMode
		{
			InputColor = 0,
			OutlineColor = 1,
			ColorPerEdge = 2,
			ColorPerPoint = 3
		}

		[Min(0f)]
		public float lengthScale;

		public Outline outline;

		public List<MeshItem> backFaceMeshes;

		public VerticalOutlineTipColorMode colorMode;

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
	}
}
