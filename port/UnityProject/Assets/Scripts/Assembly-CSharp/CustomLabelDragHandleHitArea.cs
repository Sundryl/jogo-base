using UnityEngine;

internal sealed class CustomLabelDragHandleHitArea : MonoBehaviour
{
	private CustomLabelDragHandleGizmo m_Owner;

	private CustomLabelHandleDragMode m_Mode;

	private BoxCollider m_Collider;

	internal void Initialize(CustomLabelDragHandleGizmo owner, CustomLabelHandleDragMode mode)
	{
	}

	public void SetBounds(Vector3 center, Vector3 size)
	{
	}

	public void SetInteractable(bool interactable)
	{
	}

	private void EnsureCollider()
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
}
