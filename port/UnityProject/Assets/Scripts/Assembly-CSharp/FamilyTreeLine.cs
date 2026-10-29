using System;
using System.Collections.Generic;
using MPUIKIT;
using UnityEngine;

[Obsolete("FamilyTreeLine is deprecated. FamilyTreeUI now manages MPImage segments directly via LineConnection data structure.")]
public class FamilyTreeLine : MonoBehaviour
{
	public enum LineType
	{
		Parent = 0,
		Child = 1,
		Spouse = 2
	}

	private List<GameObject> m_LineSegments;

	private FamilyTreeNode m_StartNode;

	private FamilyTreeNode m_EndNode;

	private LineType m_LineType;

	[Header("Line Settings")]
	private float m_ParentLineWidth;

	private float m_SpouseLineWidth;

	[SerializeField]
	private Color m_ParentLineColor;

	[SerializeField]
	private Color m_SpouseLineColor;

	public FamilyTreeNode StartNode => null;

	public FamilyTreeNode EndNode => null;

	private void Awake()
	{
	}

	public void Initialize(FamilyTreeNode startNode, FamilyTreeNode endNode, LineType lineType)
	{
	}

	private void ClearLineSegments()
	{
	}

	private void Update()
	{
	}

	private void UpdateLinePosition()
	{
	}

	private void CreateLine()
	{
	}

	private GameObject CreateLineSegment(string segmentName)
	{
		return null;
	}

	private void ConfigureMPImage(MPImage mpImage)
	{
	}

	private void UpdateStraightLine(Vector3 startPos, Vector3 endPos)
	{
	}

	private void UpdateElbowLine(Vector3 startPos, Vector3 endPos)
	{
	}

	private void UpdateLineSegment(GameObject segment, Vector3 start, Vector3 end, bool isVertical)
	{
	}

	private void OnDestroy()
	{
	}
}
