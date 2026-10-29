using UnityEngine;

namespace Michsky.MUIP
{
	[RequireComponent(typeof(Animator))]
	public class ContextMenuManager : MonoBehaviour
	{
		public enum CameraSource
		{
			Main = 0,
			Custom = 1
		}

		public enum SubMenuBehaviour
		{
			Hover = 0,
			Click = 1
		}

		public enum CursorBoundHorizontal
		{
			Left = 0,
			Right = 1
		}

		public enum CursorBoundVertical
		{
			Bottom = 0,
			Top = 1
		}

		public Canvas mainCanvas;

		public Camera targetCamera;

		public GameObject contextContent;

		public Animator contextAnimator;

		public GameObject contextButton;

		public GameObject contextSeparator;

		public GameObject contextSubMenu;

		[SerializeField]
		private bool debugMode;

		public bool autoSubMenuPosition;

		public SubMenuBehaviour subMenuBehaviour;

		public CameraSource cameraSource;

		public CursorBoundHorizontal horizontalBound;

		public CursorBoundVertical verticalBound;

		[Range(-50f, 50f)]
		public int vBorderTop;

		[Range(-50f, 50f)]
		public int vBorderBottom;

		[Range(-50f, 50f)]
		public int hBorderLeft;

		[Range(-50f, 50f)]
		public int hBorderRight;

		private Vector2 uiPos;

		private Vector3 cursorPos;

		private Vector3 contentPos;

		private Vector3 contextVelocity;

		private RectTransform contextRect;

		private RectTransform contentRect;

		[HideInInspector]
		public bool isOn;

		private void Awake()
		{
		}

		public void CheckForBound()
		{
		}

		public void SetContextMenuPosition()
		{
		}

		public void SetFixedPosition()
		{
		}

		private void ProcessContextRect()
		{
		}

		private void PrintDebug()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void OpenInFixedPosition()
		{
		}

		public void OpenContextMenu()
		{
		}

		public void CloseOnClick()
		{
		}
	}
}
