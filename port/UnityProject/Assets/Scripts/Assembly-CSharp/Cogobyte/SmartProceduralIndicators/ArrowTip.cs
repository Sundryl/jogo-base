using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	public abstract class ArrowTip : MonoBehaviour
	{
		public Vector3 size;

		public virtual float GetLength()
		{
			return 0f;
		}

		public virtual bool FollowsPath()
		{
			return false;
		}

		public abstract int MaxMeshIndex();

		public abstract Color32 GetDefaultInputColor();

		public abstract void GenerateTip(List<ArrowRenderer> arrowRenderers, BodyAndTipPathData tipData, bool tail, bool renderBackFace, Color32 inputColor, float inputRoll);
	}
}
