using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectContainer : MonoBehaviour
{
	[Tooltip("按钮项的容器对象")]
	[SerializeField]
	private Transform m_ButtonContainer;

	[Tooltip("按钮项的预制体")]
	[SerializeField]
	private GameObject m_ButtonPrefab;

	private List<GameObject> m_ButtonObjects;

	private static SelectContainer s_Instance;

	public Transform ButtonContainer => null;

	public static SelectContainer Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Hide()
	{
	}

	public void ClearButtons()
	{
	}

	public void CreateButtons(List<SelectItemData> _items, UnityAction<string> _onItemSelected)
	{
	}

	public void CreateButtons(List<SelectItemData> _items, UnityAction<string> _onItemSelected, bool _closeOnSelect, Color? _defaultButtonColor)
	{
	}

	private void CreateButtonsInternal(List<SelectItemData> _items, UnityAction<string> _onItemSelected, bool _closeOnSelect, Color? _defaultButtonColor, bool _applyDefaultButtonColor)
	{
	}

	private GameObject CreateButton(SelectItemData _item, UnityAction<string> _onItemSelected, bool _closeOnSelect, Color? _defaultButtonColor, bool _applyDefaultButtonColor)
	{
		return null;
	}

	private void RefreshLayout()
	{
	}

	private void BringPanelToFront()
	{
	}
}
