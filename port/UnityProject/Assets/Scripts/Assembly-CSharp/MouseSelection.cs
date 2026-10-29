using System.Collections.Generic;
using csDelaunay;

public class MouseSelection
{
	private const float EPSILON = 0.005f;

	private List<LR> edgeOrientations;

	private List<Edge> edges;

	private List<Vector2f> region;

	public HashSet<CellObject> SelectedCells { get; set; }

	public HashSet<CellObject> BoundaryCells { get; set; }

	public void AddCell(CellObject cellObject)
	{
	}

	public void RemoveCell(CellObject cellObject)
	{
	}

	public void Clear()
	{
	}

	public List<Vector2f> Region(Rectf clippingBounds)
	{
		return null;
	}

	private static bool CloseEnough(Vector2f p0, Vector2f p1)
	{
		return false;
	}

	private void ReorderEdges()
	{
	}

	private List<Vector2f> ClipToBounds(Rectf bounds)
	{
		return null;
	}

	private void Connect(ref List<Vector2f> points, int j, Rectf bounds, bool closingUp = false)
	{
	}
}
