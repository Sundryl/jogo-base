using System.Collections.Generic;
using Shapes;
using UnityEngine;

public class RTSController : ImmediateModeShapeDrawer
{
	public enum CommandMode
	{
		Attack = 0
	}

	private static RTSController _instance;

	private bool m_IsRTSMode;

	private State m_CurrentRTSState;

	private CommandMode m_CurrentCommandMode;

	private bool m_IsSelecting;

	private Vector3 m_SelectionStartPos;

	private Vector3 m_SelectionEndPos;

	private List<Army> m_SelectedArmies;

	private bool m_IsRightMouseHeld;

	private float m_RightMouseHoldTime;

	private Vector2 m_RightMouseDownScreenPos;

	private float m_RightMouseDragThreshold;

	private bool m_HasRightMouseDragged;

	private Texture2D m_AttackCursor;

	private Texture2D m_DefaultCursor;

	private int m_CursorSize;

	private Vector2 m_CursorHotspot;

	private Color m_SelectionBoxColor;

	private Color m_SelectionBoxBorderColor;

	public static RTSController Instance => null;

	public bool IsRTSMode => false;

	public State CurrentRTSState => null;

	private void Awake()
	{
	}

	private void LoadCursors()
	{
	}

	private Texture2D ResizeTexture(Texture2D source, int targetWidth, int targetHeight)
	{
		return null;
	}

	private Vector2 ComputeHotspotTopLeftFirstOpaque(Texture2D tex)
	{
		return default;
	}

	private Texture2D RecolorPreserveAlpha(Texture2D source, Color targetColor)
	{
		return null;
	}

	public void EnterRTSMode(State state)
	{
	}

	public void ExitRTSMode()
	{
	}

	private void ClearSelection()
	{
	}

	private void AddToSelection(Army army)
	{
	}

	public void RemoveFromSelection(Army army)
	{
	}

	private void Update()
	{
	}

	private void HandleCommandModeSwitch()
	{
	}

	private void SetCommandMode(CommandMode mode)
	{
	}

	private void HandleSelection()
	{
	}

	private void PerformSelection()
	{
	}

	private void HandleBoxSelection(Vector3 min, Vector3 max)
	{
	}

	private void HandleRightClick()
	{
	}

	private Vector3 GetMouseWorldPosition()
	{
		return default;
	}

	public override void DrawShapes(Camera cam)
	{
	}

	public List<Army> GetSelectedArmies()
	{
		return null;
	}
}
