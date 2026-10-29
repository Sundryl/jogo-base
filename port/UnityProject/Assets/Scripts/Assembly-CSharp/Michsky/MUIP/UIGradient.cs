using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Modern UI Pack/Effects/UI Gradient")]
	public class UIGradient : BaseMeshEffect
	{
		public enum Type
		{
			Horizontal = 0,
			Vertical = 1,
			Diamond = 2
		}

		public enum Blend
		{
			Override = 0,
			Add = 1,
			Multiply = 2
		}

		[SerializeField]
		private Type _gradientType;

		[SerializeField]
		private Blend _blendMode;

		[SerializeField]
		private bool _modifyVertices;

		[SerializeField]
		[Range(-1f, 1f)]
		private float _offset;

		[Range(0.1f, 10f)]
		[SerializeField]
		private float _zoom;

		[SerializeField]
		private Gradient _effectGradient;

		public Blend BlendMode
		{
			get
			{
				return Blend.Override;
			}
			set
			{
			}
		}

		public Gradient EffectGradient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Type GradientType
		{
			get
			{
				return Type.Horizontal;
			}
			set
			{
			}
		}

		public bool ModifyVertices
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Offset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Zoom
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void ModifyMesh(VertexHelper helper)
		{
		}

		private Rect GetBounds(List<UIVertex> vertices)
		{
			return default;
		}

		private void SplitTrianglesAtGradientStops(List<UIVertex> _vertexList, Rect bounds, float zoomOffset, VertexHelper helper)
		{
		}

		private float[] GetPositions(List<UIVertex> _vertexList, int index)
		{
			return null;
		}

		private List<float> FindStops(float zoomOffset, Rect bounds)
		{
			return null;
		}

		private UIVertex CreateSplitVertex(UIVertex vertex1, UIVertex vertex2, float stop)
		{
			return default;
		}

		private Color BlendColor(Color colorA, Color colorB)
		{
			return default;
		}
	}
}
