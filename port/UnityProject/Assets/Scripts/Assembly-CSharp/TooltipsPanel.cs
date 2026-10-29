using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TooltipsPanel : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI textComponent;

	[SerializeField]
	private Button ContinueButton;

	private void Awake()
	{
	}

	public void SetText(string message)
	{
	}

	public void OnPanelOpen(string tooltipsContent, UnityAction action)
	{
	}

	public void OnPanelClose()
	{
	}
}
