using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public sealed class CustomMapImageDragHandler : MonoBehaviour
{
	[SerializeField]
	private string m_Id;

	[SerializeField]
	private bool m_EnableDrag;

	private SpriteRenderer m_SpriteRenderer;

	private BoxCollider2D m_BoxCollider;

	private Camera m_CachedCamera;

	private Vector3 m_DragOffset;

	private bool m_IsDragging;

	private int m_LastPointerDownFrame;

	public string Id => null;

	public void Initialize(string _id, SpriteRenderer _spriteRenderer = null)
	{
	}

	public void SetActiveForDrag(bool _isActive)
	{
	}

	public void RefreshCollider()
	{
	}

	private void OnMouseDown()
	{
	}

	public bool TryBeginPointerDown()
	{
		return false;
	}

	private void OnMouseDrag()
	{
	}

	private void OnMouseUp()
	{
	}

	private Camera GetCamera()
	{
		return null;
	}

	private Vector3 GetMouseWorldPosition(Camera _camera)
	{
		return default;
	}
}
