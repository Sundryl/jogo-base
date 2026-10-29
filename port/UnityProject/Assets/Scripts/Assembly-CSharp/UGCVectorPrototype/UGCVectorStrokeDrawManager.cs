using System.Collections.Generic;
using Shapes;
using UnityEngine;
using UnityEngine.Rendering;

namespace UGCVectorPrototype
{
	public class UGCVectorStrokeDrawManager : ImmediateModeShapeDrawer
	{
		private class StrokeDefinition
		{
			public readonly List<StrokePath> paths;
		}

		private class StrokePath
		{
			public PolylinePath path;

			public bool closed;

			public PolylineJoins joins;

			public float thickness;

			public Color color;

			public bool drawBehindFill;
		}

		private class StrokeInstance
		{
			public Object owner;

			public Transform transform;

			public StrokeDefinition definition;

			public Color color;

			public float thicknessScale;
		}

		private static UGCVectorStrokeDrawManager s_Instance;

		private readonly Dictionary<Object, StrokeInstance> m_Instances;

		private readonly Dictionary<TextAsset, StrokeDefinition> m_Definitions;

		private readonly Dictionary<int, bool> m_UseRoundJoinByCameraId;

		private const float c_RoundJoinEnableOrthoSize = 22f;

		private const float c_RoundJoinDisableOrthoSize = 26f;

		public static UGCVectorStrokeDrawManager Instance => null;

		public static bool TryGetInstance(out UGCVectorStrokeDrawManager _instance)
		{
			_instance = null;
			return false;
		}

		private void OnDestroy()
		{
		}

		public void Register(Object _owner, TextAsset _svgAsset, List<UGCVectorStrokePath> _paths, Transform _transform, Color _color, bool _forceRebuild = false, float _thicknessScale = 1f)
		{
		}

		public void Unregister(Object _owner)
		{
		}

		public override void DrawShapes(Camera _cam)
		{
		}

		private bool ShouldUseRoundJoin(Camera _cam)
		{
			return false;
		}

		private void DrawStrokePaths(Camera _cam, PolylineJoins _joinMode, bool _drawBehindFill, CompareFunction _zTest)
		{
		}

		private StrokeDefinition BuildDefinition(List<UGCVectorStrokePath> _paths)
		{
			return null;
		}

		private void DisposeDefinition(StrokeDefinition _definition)
		{
		}
	}
}
