using System.Collections.Generic;
using Cogobyte.SmartProceduralIndicators;
using UnityEngine;

namespace Cogobyte.Demo.SmartProceduralIndicators
{
	public class BodyTwistAndScaleDemo : MonoBehaviour
	{
		public SliderHandle twist;

		public SmartArrow twistArrow;

		public SmartArrow animatedTwistArrow;

		public SmartArrow sizeArrow;

		public SmartArrow animatedSizeArrow;

		public List<SmartArrow> arrows;

		public Transform sizeHandle;

		private float angle;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
