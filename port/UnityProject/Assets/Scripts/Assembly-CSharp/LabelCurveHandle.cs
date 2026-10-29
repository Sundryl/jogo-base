using Shapes;
using UnityEngine;

public sealed class LabelCurveHandle : MonoBehaviour
{
	[SerializeField]
	private float m_Radius;

	[SerializeField]
	private float m_ColliderRadius;

	[SerializeField]
	private float m_ColliderPadding;

	[SerializeField]
	private float m_ZOffset;

	[SerializeField]
	private string m_ControlPointPrefabPath;

	[SerializeField]
	private Color m_NormalColor;

	[SerializeField]
	private Color m_SelectedColor;

	private SphereCollider m_Collider;

	private Camera m_MainCamera;

	private Plane m_DragPlane;

	private bool m_IsDragging;

	private Vector3 m_DragOffset;

	private GameObject m_VisualInstance;

	private Disc m_Disc;

	private bool m_HasCapturedBaseColor;

	private Material m_OriginalMaterial;

	private bool m_IsSelected;

	public LabelPathEditor Owner { get; private set; }

	public int Index { get; private set; }

	public void Initialize(LabelPathEditor _owner, int _index, Vector3 _position)
	{
	}

	private void EnsureCollider()
	{
	}

	private void EnsureVisual()
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

	public void SetSelected(bool selected)
	{
	}

	private void ApplyVisualState(bool selected)
	{
	}

	private float GetDataZ()
	{
		return 0f;
	}

	private Vector3 ApplyVisualPosition(Vector3 dataPosition)
	{
		return default;
	}

	private void UpdateColliderRadius()
	{
	}

	private float GetDiscRadiusInHandleSpace()
	{
		return 0f;
	}
}
