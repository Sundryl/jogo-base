using Shapes;
using UnityEngine;

public class BrushManager : ImmediateModeShapeDrawer
{
	public int brushHeight;

	private Vector3 position;

	private bool enable;

	private static BrushManager _instance;

	public float minHeight;

	public float maxHeight;

	public Color Color100;

	public Color Color50;

	public Color Color20;

	public static BrushManager Instance => null;

	public override void DrawShapes(Camera cam)
	{
	}

	private float GetCurrentBrushThickness()
	{
		return 0f;
	}

	public SliderValueConnector GetCurrentBrushRadiusSlider()
	{
		return null;
	}

	public SliderValueConnector GetShortcutBrushRadiusSlider()
	{
		return null;
	}

	public float GetCurrentBrushRadius()
	{
		return 0f;
	}

	public bool IsBrushRadiusShortcutActive(float _scrollDelta)
	{
		return false;
	}

	public bool TryAdjustCurrentBrushRadius(float _scrollDelta)
	{
		return false;
	}

	public bool IsBrushHeightShortcutActive(float _scrollDelta)
	{
		return false;
	}

	public bool TryAdjustCurrentBrushHeight(float _scrollDelta)
	{
		return false;
	}

	private Color GetCurrentBrushColor()
	{
		return default;
	}

	private void Update()
	{
	}

	private bool IsEnableBrush()
	{
		return false;
	}

	public void SetEnable(bool e)
	{
	}

	public Color GetColorFromHeight(float height)
	{
		return default;
	}

	public void OnButtonEnableEditClicked()
	{
	}

	private bool IsCtrlPressed()
	{
		return false;
	}

	private bool IsAltPressed()
	{
		return false;
	}

	private bool IsPointerOverBlockedUI()
	{
		return false;
	}
}
