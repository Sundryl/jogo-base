using System.Runtime.CompilerServices;
using Shapes;
using UnityEngine;

public class DragPoint : MonoBehaviour
{
	public delegate void PointMovedHandler(Vector3 newPosition);

	[SerializeField]
	[Range(0.1f, 5f)]
	private float m_Radius;

	[Range(1f, 3f)]
	[SerializeField]
	private float m_ColliderRadiusMultiplier;

	private SphereCollider m_SphereCollider;

	private Camera m_MainCamera;

	private bool m_IsDragging;

	private Plane m_DragPlane;

	private Disc m_Disc;

	private bool m_HasMoved;

	private Vector3 m_InitialPosition;

	private Vector3 m_DragOffset;

	private const float c_DragThreshold = 0.005f;

	[CompilerGenerated]
	private PointMovedHandler m_OnPointMoved;

	public int RiverId { get; private set; }

	public int PointIndex { get; private set; }

	public float Radius => 0f;

	public event PointMovedHandler OnPointMoved
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SetContext(int riverId, int pointIndex)
	{
	}

	public void UpdatePointIndex(int pointIndex)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	private void OnMouseDown()
	{
	}

	private void OnMouseDrag()
	{
	}

	private void OnMouseUp()
	{
	}

	private void UpdateColliderRadius()
	{
	}
}
