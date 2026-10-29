using System.Collections.Generic;
using Shapes;
using Unity.VectorGraphics;
using UnityEngine;

namespace UGCVectorPrototype
{
	public static class UGCVectorSvgStrokeBuilder
	{
		public const string c_NoStrokeError = "SVG 未解析到可用描边";

		public static bool HasUsableStrokes(string _svgText, out string _error)
		{
			_error = null;
			return false;
		}

		public static bool TryBuildStrokes(string _svgText, UGCVectorIconViewBox _viewBox, UGCVectorSvgStrokeOptions _options, out List<UGCVectorStrokePath> _paths, out string _error)
		{
			_paths = null;
			_error = null;
			return false;
		}

		private static float GetAverageScale(Matrix2D _matrix)
		{
			return 0f;
		}

		private static bool TryGetStrokeColor(Stroke _stroke, float _worldOpacity, out Color _color)
		{
			_color = default;
			return false;
		}

		private static Dictionary<SceneNode, string> BuildNodeIdByNodeMap(Dictionary<string, SceneNode> _nodeIds)
		{
			return null;
		}

		private static Dictionary<SceneNode, SceneNode> BuildParentByNodeMap(SceneNode _root)
		{
			return null;
		}

		private static bool IsNodeStrokeMarkedBehind(SceneNode _node, Dictionary<SceneNode, string> _nodeIdByNode, Dictionary<SceneNode, SceneNode> _parentByNode)
		{
			return false;
		}

		private static bool IsBackStrokeMarker(string _nodeId)
		{
			return false;
		}

		private static void AppendSegmentPoints(BezierSegment _segment, float _maxSegmentLength, List<Vector2> _points, float _minPointDistSq)
		{
		}

		private static void NormalizePoints(List<Vector2> _points, float _centerX, float _centerY, float _scale, float _minPointDistSq)
		{
		}

		private static void RemoveDuplicateLoopPoint(List<Vector2> _points, float _minPointDistSq)
		{
		}

		private static PolylineJoins ConvertCorner(PathCorner _corner)
		{
			return PolylineJoins.Simple;
		}

		private static LineEndCap ConvertEnding(PathEnding _head, PathEnding _tail)
		{
			return LineEndCap.None;
		}
	}
}
