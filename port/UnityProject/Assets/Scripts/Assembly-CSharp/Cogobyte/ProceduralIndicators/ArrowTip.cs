using System;
using System.Collections.Generic;
using Cogobyte.ProceduralLibrary;
using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[Serializable]
	[CreateAssetMenu(fileName = "ArrowTip", menuName = "Cogobyte/ProceduralIndicators/Arrows/ArrowTip", order = 3)]
	public class ArrowTip : ScriptableObject
	{
		public enum ArrowTipMode
		{
			None = 0,
			Mesh = 1,
			Extrude = 2
		}

		public enum ArrowTipPathType
		{
			Function = 0,
			FollowMainPath = 1
		}

		[NonSerialized]
		public ArrowPath arrowPath;

		public Vector3 size;

		public ArrowTipMode arrowTipMode;

		[Range(1f, 100f)]
		public int levelOfDetailAlongPath;

		public ArrowTipPathType arrowTipPathType;

		public float pathAlongXFunctionLength;

		public AnimationCurve pathAlongXFunction;

		public float pathAlongYFunctionLength;

		public AnimationCurve pathAlongYFunction;

		public float pathAlongZFunctionLength;

		public AnimationCurve pathAlongZFunction;

		public float widthFunctionLength;

		public AnimationCurve widthFunction;

		public float heightFunctionLength;

		public AnimationCurve heightFunction;

		public float rotationFunctionLength;

		public AnimationCurve rotateFunction;

		public PrimitivesList templatePrimitives;

		public float shapeFunctionLength;

		public AnimationCurve shapeFunction;

		public SolidMesh mesh;

		public Matrix4x4[] extrudePoints;

		public int[] openClosed;

		public Primitive[] primitives;

		public int direction;

		public List<Vector3> path;

		private float pathLength;

		public Vector3 start;

		public Vector3 end;

		private static float errorRate;

		public bool invalidTip;

		public float defaultRotateAngle;

		private void OnValidate()
		{
		}

		public float getLength()
		{
			return 0f;
		}

		public bool getClosed()
		{
			return false;
		}

		public void calculatePath()
		{
		}

		private void increasePathPercentage(ref int currentKeyIndex, ref float currentPercentage, ref int[] currentKey)
		{
		}

		public void generate()
		{
		}

		public void generateMesh(List<Vector3> vertices, List<int> triangles, List<Vector3> normals)
		{
		}
	}
}
