using UnityEngine;

namespace Cogobyte.Demo.SmartProceduralIndicators
{
	public class RotateHandle : MonoBehaviour
	{
		public Transform HandleMainTransform;

		public Camera MainCamera;

		private Quaternion Offset;

		private Vector3 MouseDownPosition;

		public Plane userPlane;

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
	}
}
