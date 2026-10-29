using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;
using UnityEngine;

namespace UGCVectorPrototype
{
	public static class UGCVectorSvgImporter
	{
		private struct SvgParseContext
		{
			public Matrix4x4 transform;

			public int partId;

			public float opacity;
		}

		private struct SvgShape
		{
			public List<List<Vector2>> contours;

			public Color color;

			public int partId;
		}

		private struct Loop
		{
			public List<Vector2> points;

			public float signedArea;
		}

		private struct VertexMeta
		{
			public int loopType;

			public int loopId;

			public int loopIndex;

			public int loopCount;

			public VertexMeta(int loopType, int loopId, int loopIndex, int loopCount)
			{
				this.loopType = 0;
				this.loopId = 0;
				this.loopIndex = 0;
				this.loopCount = 0;
			}
		}

		private static class SvgPathParser
		{
			public static List<List<Vector2>> Parse(string d, UGCVectorSvgImportOptions options)
			{
				return null;
			}

			private static void AddCubic(List<Vector2> contour, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, int segments)
			{
			}

			private static void AddQuadratic(List<Vector2> contour, Vector2 p0, Vector2 p1, Vector2 p2, int segments)
			{
			}

			private static bool ReadPoint(string d, ref int index, out Vector2 point)
			{
				point = default;
				return false;
			}

			private static bool ReadFlag(string d, ref int index, out int flag)
			{
				flag = default;
				return false;
			}

			private static bool ReadFloat(string d, ref int index, out float value)
			{
				value = default;
				return false;
			}

			private static void SkipSeparators(string d, ref int index)
			{
			}

			private static void AddArc(List<Vector2> contour, Vector2 p0, Vector2 p1, float rx, float ry, float xAxisRotDeg, bool largeArc, bool sweep, int minSegments)
			{
			}
		}

		private static readonly Regex TransformRegex;

		private static readonly Regex NumberRegex;

		private const int LoopTypeOuter = 0;

		private const int LoopTypeHole = 1;

		public static bool TryConvertSvgToIconJson(string svgText, out UGCVectorIconJsonData data, out string error)
		{
			data = null;
			error = null;
			return false;
		}

		public static bool TryConvertSvgToIconJson(string svgText, out UGCVectorIconJsonData data, out string error, UGCVectorSvgImportOptions options)
		{
			data = null;
			error = null;
			return false;
		}

		public static bool TryConvertSvgToJsonString(string svgText, out string json, out string error)
		{
			json = null;
			error = null;
			return false;
		}

		public static bool TryConvertSvgToJsonString(string svgText, out string json, out string error, UGCVectorSvgImportOptions options)
		{
			json = null;
			error = null;
			return false;
		}

		private static void ParseNode(XmlNode node, SvgParseContext parent, List<SvgShape> shapes, UGCVectorSvgImportOptions options)
		{
		}

		private static void ParsePathElement(XmlElement element, SvgParseContext context, List<SvgShape> shapes, UGCVectorSvgImportOptions options)
		{
		}

		private static void ParseRectElement(XmlElement element, SvgParseContext context, List<SvgShape> shapes, UGCVectorSvgImportOptions options)
		{
		}

		private static void ParseCircleElement(XmlElement element, SvgParseContext context, List<SvgShape> shapes, UGCVectorSvgImportOptions options)
		{
		}

		private static void ParseEllipseElement(XmlElement element, SvgParseContext context, List<SvgShape> shapes, UGCVectorSvgImportOptions options)
		{
		}

		private static void ParsePolygonElement(XmlElement element, SvgParseContext context, List<SvgShape> shapes, UGCVectorSvgImportOptions options, bool closed)
		{
		}

		private static void AddShape(List<List<Vector2>> contours, Color color, int partId, List<SvgShape> shapes)
		{
		}

		private static void TransformContour(List<Vector2> contour, Matrix4x4 transform)
		{
		}

		private static void CleanupContour(List<Vector2> contour, float epsilon)
		{
		}

		private static UGCVectorIconViewBox ParseViewBox(XmlElement element)
		{
			return default;
		}

		private static UGCVectorIconViewBox ComputeViewBoxFromShapes(List<SvgShape> shapes)
		{
			return default;
		}

		private static void NormalizeShapes(List<SvgShape> shapes, UGCVectorIconViewBox viewBox)
		{
		}

		private static bool BuildMeshData(List<SvgShape> shapes, UGCVectorSvgImportOptions options, out UGCVectorIconMeshData meshData, out string error)
		{
			meshData = null;
			error = null;
			return false;
		}

		private static void AddVertex(Vector2 pos, Color color, Vector3 bary, Vector3 edgeMask, int partId, List<float> vertices, List<float> colors, List<float> barycentrics, List<float> edgeMasks, List<int> partIds)
		{
		}

		private static List<Loop> BuildLoops(List<List<Vector2>> contours)
		{
			return null;
		}

		private static void MergePolygonWithHoles(List<Vector2> outer, List<Loop> holes, out List<Vector2> merged, out List<VertexMeta> meta)
		{
			merged = null;
			meta = null;
		}

		private static void MergeSingleHole(List<Vector2> hole, int holeId, ref List<Vector2> outer, ref List<VertexMeta> outerMeta)
		{
		}

		private static int GetRightmostPointIndex(List<Vector2> points)
		{
			return 0;
		}

		private static int FindBridgeIndex(List<Vector2> outer, Vector2 holePoint)
		{
			return 0;
		}

		private static bool IsBoundaryEdge(VertexMeta a, VertexMeta b)
		{
			return false;
		}

		private static float SignedArea(List<Vector2> points)
		{
			return 0f;
		}

		private static bool IsPointInPolygon(List<Vector2> polygon, Vector2 point)
		{
			return false;
		}

		private static Loop EnsureOrientation(Loop loop, bool isHole)
		{
			return default;
		}

		private static bool TryGetFillColor(XmlElement element, SvgParseContext context, out Color color)
		{
			color = default;
			return false;
		}

		private static Dictionary<string, string> ParseStyle(string styleText)
		{
			return null;
		}

		private static string GetStyleOrAttribute(XmlElement element, Dictionary<string, string> styleMap, string key)
		{
			return null;
		}

		private static bool TryGetPartId(XmlElement element, out int partId)
		{
			partId = default;
			return false;
		}

		private static float ParseFloatAttribute(XmlElement element, string name, float fallback)
		{
			return 0f;
		}

		private static float ParseFloatString(string text, float fallback)
		{
			return 0f;
		}

		private static string SanitizeNumberText(string text)
		{
			return null;
		}

		private static float[] ParseFloatList(string text)
		{
			return null;
		}

		private static List<Vector2> ParsePoints(string text)
		{
			return null;
		}

		private static bool TryParseColor(string text, out Color color)
		{
			color = default;
			return false;
		}

		private static byte ParseHexByte(string hex)
		{
			return 0;
		}

		private static Matrix4x4 ParseTransform(string text)
		{
			return default;
		}

		private static List<Vector2> BuildRectContour(float x, float y, float width, float height, float rx, float ry, UGCVectorSvgImportOptions options)
		{
			return null;
		}

		private static List<Vector2> BuildEllipseContour(float cx, float cy, float rx, float ry, int segments)
		{
			return null;
		}

		private static void AddArc(List<Vector2> points, float cx, float cy, float rx, float ry, float startDeg, float endDeg, int segments)
		{
		}
	}
}
