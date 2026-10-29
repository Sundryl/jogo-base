using Cogobyte.ProceduralLibrary;
using UnityEngine;

namespace Cogobyte.ProceduralIndicators
{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class SelectionIndicator : MonoBehaviour
	{
		public PathArray pathArray;

		public SelectionIndicatorPath selectionIndicatorPath;

		public bool updatesByItself;

		[Range(0f, 100f)]
		public float updateSpeed;

		public bool permanentScriptableObjects;

		private float currentUpdateTime;

		public bool hideIndicator;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void updateIndicatorMesh()
		{
		}
	}
}
