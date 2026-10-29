using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[AddComponentMenu("Modern UI Pack/Layout Group/Radial Layout Group")]
	public class RadialLayoutGroup : LayoutGroup
	{
		public enum Direction
		{
			Clockwise = 0,
			Counterclockwise = 1,
			Bidirectional = 2
		}

		public enum ConstraintMode
		{
			Interval = 0,
			Range = 1
		}

		[SerializeField]
		private Direction refLayoutDir;

		[SerializeField]
		private float refRadiusStart;

		[SerializeField]
		private float refRadiusDelta;

		[SerializeField]
		private float refRadiusRange;

		[SerializeField]
		private float refAngleDelta;

		[SerializeField]
		private float refAngleStart;

		[SerializeField]
		private float refAngleCenter;

		[SerializeField]
		private float refAngleRange;

		[SerializeField]
		private bool refChildRotate;

		private List<RectTransform> childList;

		private List<ILayoutIgnorer> ignoreList;

		private static readonly Vector2 center;

		public Direction layoutDir
		{
			get
			{
				return Direction.Clockwise;
			}
			set
			{
			}
		}

		public float radiusStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float radiusDelta
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float radiusRange
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angleDelta
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angleStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angleCenter
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angleRange
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool childRotate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public override void CalculateLayoutInputHorizontal()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		private void CalculateChildrenPositions()
		{
		}

		private void EnsureParameters(int childCount)
		{
		}

		private void EnsureAngleParameters(int childCount)
		{
		}

		private void EnsureRadiusParameters(int childCount)
		{
		}

		private void ProcessOneChild(RectTransform child, float angle, float radius)
		{
		}
	}
}
