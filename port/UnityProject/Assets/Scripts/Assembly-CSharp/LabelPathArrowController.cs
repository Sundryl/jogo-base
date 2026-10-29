using System.Collections.Generic;
using Cogobyte.SmartProceduralIndicators;
using UnityEngine;

public sealed class LabelPathArrowController : MonoBehaviour
{
	[SerializeField]
	private string m_PrefabPath;

	[SerializeField]
	private float m_LabelZ;

	private GameObject m_ArrowGo;

	private PointListArrowPath m_PointList;

	private SmartArrow m_SmartArrow;

	public void Show(bool _visible)
	{
	}

	public void SetPath(IReadOnlyList<Vector3> _worldPoints)
	{
	}

	public void Cleanup()
	{
	}

	private void EnsureArrow()
	{
	}
}
