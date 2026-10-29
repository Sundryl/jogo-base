using System;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[Serializable]
	public class PathColor
	{
		public enum PathColorMode
		{
			Percentage = 0,
			Fixed = 1
		}

		public PathColorMode colorMode;

		[Range(0f, 1f)]
		public float percentage;

		[Min(0.01f)]
		public float length;

		public Color32 startColor;

		public Color32 endColor;

		public PathColor()
		{
		}

		public PathColor(PathColor p)
		{
		}
	}
}
