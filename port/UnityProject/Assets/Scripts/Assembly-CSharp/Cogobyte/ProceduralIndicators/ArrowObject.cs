using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class ArrowObject : MonoBehaviour
	{
		public ArrowIndicator arrowIndicator;

		public ArrowPath arrowPath;

		public ArrowTip arrowTail;

		public ArrowTip arrowHead;

		public bool updatesByItself;

		[Range(0f, 10f)]
		public float updateSpeed;

		public bool permanentScriptableObjects;

		private float currentUpdateTime;

		public bool hideIndicator;

		public bool flatShading;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void updateArrowMesh()
		{
		}
	}
}
