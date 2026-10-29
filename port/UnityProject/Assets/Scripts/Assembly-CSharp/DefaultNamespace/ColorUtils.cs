using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
	public class ColorUtils
	{
		public struct HSL
		{
			public double Hue;

			public double Saturation;

			public double Luminance;

			public HSL(int H, int S, int L)
			{
				Hue = 0.0;
				Saturation = 0.0;
				Luminance = 0.0;
			}

			private double HueToRGB(double arg1, double arg2, double H)
			{
				return 0.0;
			}

			public Color TurnToRGB()
			{
				return default;
			}

			public static HSL TurnToHSL(Color C)
			{
				return default;
			}
		}

		public static List<string> c12;

		public static List<string> colorsExtension;

		public static List<Color> douyinColors;

		private static List<string> c8;

		private static List<string> c20;

		private static Gradient _gradient;

		public static List<Color> GetColors(int number)
		{
			return null;
		}

		public static List<Color> GetBaseColors()
		{
			return null;
		}

		public static List<Color> GetStatePaletteColors()
		{
			return null;
		}

		public static List<Color> GetStateRandomColorSource()
		{
			return null;
		}

		public static Color GetSeededRandomColorForNewStateSource(int seed)
		{
			return default;
		}

		public static List<Color> GetExtraColors()
		{
			return null;
		}

		public static List<Color> GetColorsUnique(int number)
		{
			return null;
		}

		public static Color HexToColor(string hex)
		{
			return default;
		}

		static ColorUtils()
		{
		}

		public static Color Overlay(Color baseColor, Color blendColor)
		{
			return default;
		}

		public static Color Overlay(Color baseColor, Color blendColor, float opacity)
		{
			return default;
		}

		public static Color GetColorBasedOnHeight(float height, float minHeight, float maxHeight)
		{
			return default;
		}

		public static void SetRandomStateColor(State state)
		{
		}

		public static void SetStateColor(State state)
		{
		}

		public static Color AdjustColor(Color color, float saturationIncrease, float valueDecrease)
		{
			return default;
		}

		public static Color SRGBToLinear(Color srgbColor)
		{
			return default;
		}

		private static float SRGBToLinearChannel(float srgbChannel)
		{
			return 0f;
		}

		public static Color GetRandomColor()
		{
			return default;
		}

		public static Color GetMixedColor(Color color, float mix = 0.2f, float bright = 0.05f)
		{
			return default;
		}

		internal static Color GetRandomColorForNewState()
		{
			return default;
		}

		internal static string ColorToHex(Color color)
		{
			return null;
		}

		public static Color ResolveColorConflict(Color currentColor, HashSet<Color> neighborColors, List<Color> baseColors)
		{
			return default;
		}

		public static (Color, int) GetLeastUsedColor<T>(IEnumerable<T> objects, Func<T, Color> colorGetter)
		{
			return default;
		}

		public static bool ColorEquals(Color color1, Color color2, float tolerance = 0.01f)
		{
			return false;
		}
	}
}
