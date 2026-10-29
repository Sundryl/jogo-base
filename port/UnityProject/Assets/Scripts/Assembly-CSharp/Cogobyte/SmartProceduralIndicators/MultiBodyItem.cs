using System;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[Serializable]
	public class MultiBodyItem
	{
		public enum LengthMode
		{
			Fixed = 0,
			Percentage = 1,
			Fill = 2
		}

		public BodyRenderer bodyRenderer;

		public LengthMode lengthMode;

		[Min(0.1f)]
		public float length;

		[Range(0.001f, 1f)]
		public float percentage;

		public float displacement;

		public float colorDisplacement;
	}
}
