using UnityEngine;

namespace Cogobyte.Demo.SmartProceduralIndicators
{
	public class DragHandle : MonoBehaviour
	{
		public enum MoveAxis
		{
			X = 0,
			Y = 1,
			Z = 2,
			XY = 3,
			XZ = 4,
			YZ = 5
		}

		public Transform HandleMainTransform;

		public Camera MainCamera;

		public MoveAxis moveAxis;

		private Vector3 Offset;

		public Plane userPlane;

		public float GetSliderValue()
		{
			return 0f;
		}

		private void OnMouseDown()
		{
		}

		private void OnMouseDrag()
		{
		}

		public Vector3 GetPoint()
		{
			return default;
		}

		private Vector3 FindNearestPointOnLine(Vector3 a, Vector3 b, Vector3 p)
		{
			return default;
		}
	}
}
