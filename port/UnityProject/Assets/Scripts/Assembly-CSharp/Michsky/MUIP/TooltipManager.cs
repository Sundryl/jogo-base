using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	public class TooltipManager : MonoBehaviour
	{
		public enum CameraSource
		{
			Main = 0,
			Custom = 1
		}

		public enum TransitionMode
		{
			Damp = 0,
			Snap = 1
		}

		public Canvas mainCanvas;

		public GameObject tooltipObject;

		public GameObject tooltipContent;

		public Camera targetCamera;

		[Range(0.01f, 0.5f)]
		public float tooltipSmoothness;

		[Range(5f, 10f)]
		public float dampSpeed;

		public float preferredWidth;

		public bool allowUpdate;

		public bool checkDispose;

		public CameraSource cameraSource;

		public TransitionMode transitionMode;

		[Range(-50f, 50f)]
		public int vBorderTop;

		[Range(-50f, 50f)]
		public int vBorderBottom;

		[Range(-50f, 50f)]
		public int hBorderLeft;

		[Range(-50f, 50f)]
		public int hBorderRight;

		[SerializeField]
		private int xLeft;

		[SerializeField]
		private int xRight;

		[SerializeField]
		private int yTop;

		[SerializeField]
		private int yBottom;

		[HideInInspector]
		public LayoutElement contentLE;

		[HideInInspector]
		public TooltipContent currentTooltip;

		private Vector2 uiPos;

		private Vector3 cursorPos;

		private Vector3 contentPos;

		private Vector3 tooltipVelocity;

		private RectTransform contentRect;

		private RectTransform tooltipRect;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void CheckForPosition()
		{
		}

		private void CheckForBounds()
		{
		}
	}
}
