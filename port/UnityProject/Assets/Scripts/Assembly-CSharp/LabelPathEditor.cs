using System.Collections.Generic;
using UnityEngine;

public sealed class LabelPathEditor : MonoBehaviour
{
	[SerializeField]
	private float m_LabelZ;

	[SerializeField]
	private bool m_IsEditing;

	private string m_LabelId;

	private readonly List<Vector3> m_ControlPoints;

	private readonly List<LabelCurveHandle> m_Handles;

	private int m_SelectedIndex;

	private CurvedLabelRenderer m_Curved;

	private LabelPathArrowController m_Arrow;

	public float LabelZ => 0f;

	public void BeginEdit(string _labelId)
	{
	}

	public void EndEdit()
	{
	}

	private void Update()
	{
	}

	public void SetSelectedIndex(int _index)
	{
	}

	public void OnHandleMoved(int _index, Vector3 _worldPos)
	{
	}

	public void OnHandleReleased(int _index)
	{
	}

	private void InsertPoint(Vector3 _worldPos)
	{
	}

	private void RemovePoint(int _index)
	{
	}

	private int FindBestInsertIndex(Vector3 _worldPos)
	{
		return 0;
	}

	private static float GetSegmentProjectionT(Vector3 a, Vector3 b, Vector3 p)
	{
		return 0f;
	}

	private void BuildHandles()
	{
	}

	private void ClearHandles()
	{
	}

	private void RebuildCurved()
	{
	}

	private void EnsureArrowShown()
	{
	}

	private void RefreshArrowPath()
	{
	}

	private void EnsureCurvedEnabled()
	{
	}

	private void LoadPointsFromData()
	{
	}

	private void SavePointsToData()
	{
	}

	private void SyncHandleSelection()
	{
	}

	private Vector3 GetMouseWorldOnLabelPlane()
	{
		return default;
	}
}
