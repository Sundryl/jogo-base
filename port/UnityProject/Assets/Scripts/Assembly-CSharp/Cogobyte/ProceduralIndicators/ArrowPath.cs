using System;
using System.Collections.Generic;
using Cogobyte.ProceduralLibrary;
using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[Serializable]
	[CreateAssetMenu(fileName = "ArrowPath", menuName = "Cogobyte/ProceduralIndicators/Arrows/ArrowPath", order = 2)]
	public class ArrowPath : ScriptableObject
	{
		public enum ArrowPathMode
		{
			None = 0,
			Extrude = 1,
			MadeOfShapes = 2,
			BrokenExtrude = 3
		}

		public enum ArrowPathType
		{
			Function = 0,
			PointArray = 1,
			PathArray = 2
		}

		[SerializeField]
		public ArrowTip arrowTail;

		[SerializeField]
		public ArrowTip arrowHead;

		public ArrowPathMode arrowPathMode;

		[Range(1f, 1000f)]
		public int levelOfDetailAlongPath;

		public ArrowPathType arrowPathType;

		public PathArray pathArray;

		public List<Vector3> editedPath;

		public Vector3 startPoint;

		public Vector3 endPoint;

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

		public MeshesList customShapes;

		public bool atPathPoints;

		public List<float> distanceBetweenShapes;

		public float brokenLineLength;

		public float brakeLength;

		public Matrix4x4[] extrudePoints;

		public int[] openClosed;

		public Primitive[] primitives;

		public Vector3[] path;

		public List<Vector3> fullPath;

		private float pathLength;

		public Gradient[] colorFunctions;

		public bool useShapeColors;

		private static float errorRate;

		public float defaultRotateAngle;

		public List<Color32> madeOfShapesColors;

		public bool invalidPath;

		private void OnValidate()
		{
		}

		public static void ValidateAnimationFunction(AnimationCurve curve, float startValue, float endValue)
		{
		}

		public void CalculatePath()
		{
		}

		private void increasePathPercentage(ref int currentKeyIndex, ref float currentPercentage, ref int[] currentKey)
		{
		}

		public void generate()
		{
		}

		private void Extrude(Vector3[] path)
		{
		}

		public Quaternion calculateUpDownQuaternion(Vector3 pathDiff)
		{
			return default;
		}

		public Quaternion calculateLeftRightQuaternion(Vector3 pathDiff)
		{
			return default;
		}

		public void GenerateMadeOfShapes(List<Vector3> vertices, List<int> triangles, List<Vector3> normals)
		{
		}

		public void calculateArrowHeadStartPoints()
		{
		}

		public Vector3[] LineSphereIntersection(Vector3 center, float radius, Vector3 rayStart, Vector3 rayEnd)
		{
			return null;
		}
	}
}
