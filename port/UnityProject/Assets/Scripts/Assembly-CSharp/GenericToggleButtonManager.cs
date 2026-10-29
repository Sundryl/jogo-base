using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class GenericToggleButtonManager : MonoBehaviour
{
	public delegate bool GetEnabledStateDelegate(object key);

	public delegate void SetEnabledStateDelegate(object key, bool isEnabled);

	public delegate List<object> GetAllKeysDelegate();

	public delegate string GetKeyDisplayNameDelegate(object key);

	private Dictionary<object, GameObject> m_ToggleDict;

	[SerializeField]
	private GameObject m_TogglePrefab;

	[SerializeField]
	private Transform m_ButtonContainer;

	[SerializeField]
	private string m_ToggleType;

	private CanvasGroup m_CanvasGroup;

	private static GenericToggleButtonManager s_Instance;

	private GetEnabledStateDelegate m_LastGetEnabledState;

	private SetEnabledStateDelegate m_LastSetEnabledState;

	private GetAllKeysDelegate m_LastGetAllKeys;

	private GetKeyDisplayNameDelegate m_LastGetKeyDisplayName;

	public static GenericToggleButtonManager Instance => null;

	private void Start()
	{
	}

	public void Show(GetEnabledStateDelegate getEnabledState, SetEnabledStateDelegate setEnabledState, GetAllKeysDelegate getAllKeys, GetKeyDisplayNameDelegate getKeyDisplayName = null)
	{
	}

	public void Hide()
	{
	}

	private void RefreshLayout()
	{
	}

	public void ClearToggleButtons()
	{
	}

	private void CreateToggleButtons(GetEnabledStateDelegate getEnabledState, SetEnabledStateDelegate setEnabledState, GetAllKeysDelegate getAllKeys, GetKeyDisplayNameDelegate getKeyDisplayName)
	{
	}

	public void RefreshAllToggleButtons(GetEnabledStateDelegate getEnabledState, GetKeyDisplayNameDelegate getKeyDisplayName = null)
	{
	}

	public void Refresh()
	{
	}
}
