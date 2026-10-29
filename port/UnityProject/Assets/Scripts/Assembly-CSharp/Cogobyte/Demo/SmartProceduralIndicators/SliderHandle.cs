using UnityEngine;

namespace Cogobyte.Demo.SmartProceduralIndicators
{
	public class SliderHandle : MonoBehaviour
	{
		public Transform HandleMainTransform;

		public Camera MainCamera;

		private Plane userPlane;

		public float maxLength;

		public float GetSliderValue()
		{
			return 0f;
		}

		private void OnMouseDrag()
		{
		}

		public Vector3 GetPoint()
		{
			return default;
		}

		private Vector3 GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end)
		{
			return default;
		}
	}
}
