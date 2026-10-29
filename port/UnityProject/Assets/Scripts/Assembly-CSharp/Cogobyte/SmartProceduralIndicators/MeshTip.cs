using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public class MeshTip : ArrowTip
	{
		[Min(0f)]
		public float lengthScale;

		public List<MeshItem> meshes;

		public List<MeshItem> backFaceMeshes;

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
