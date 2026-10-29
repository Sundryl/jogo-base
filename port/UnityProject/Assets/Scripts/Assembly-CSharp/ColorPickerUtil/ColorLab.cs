using UnityEngine;

namespace ColorPickerUtil
{
	public class ColorLab
	{
		public float L;

		public float a;

		public float b;

		public float alpha;

		public ColorLab()
		{
		}

		public ColorLab(float L, float a, float b)
		{
		}

		public ColorLab(float L, float a, float b, float alpha)
		{
		}

		public ColorLab(Color color)
		{
		}

		public void FromColor(Color color)
		{
		}

		public Color ToColor()
		{
			return default;
		}
	}
}
