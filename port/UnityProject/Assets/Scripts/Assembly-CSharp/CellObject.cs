using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using csDelaunay;

public class CellObject : MonoBehaviour
{
	private static MouseSelection _mouseSelection;

	private static World map;

	private static Color highlightColor;

	private static Stopwatch clickTimer;

	private Color originalColor;

	private Vector3 screenPoint;

	private Vector3 offset;

	private Renderer rend;

	public static Dictionary<Site, CellObject> SiteCells { get; private set; }

	public Site Site { get; set; }

	static CellObject()
	{
	}

	public static MouseSelection GetSelection()
	{
		return null;
	}

	public void SetSite(Site site)
	{
	}

	public bool IsSelected()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}
}
