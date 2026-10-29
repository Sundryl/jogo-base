using UnityEngine;

namespace ColorPickerUtil
{
	public class ColorHex
	{
		public string hex;

		public float alpha;

		public static bool IsValid(string hex)
		{
			return false;
		}

		public ColorHex()
		{
		}

		public ColorHex(string hex)
		{
		}

		public ColorHex(string hex, float alpha)
		{
		}

		public ColorHex(Color color)
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
