using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddItemUIComponent : MonoBehaviour
{
	[SerializeField]
	private TMP_InputField m_InputField;

	[SerializeField]
	private Button m_Button;

	private Action<string> m_OnButtonClickedCallback;

	private void Awake()
	{
	}

	private void OnButtonClicked()
	{
	}

	public void SetButtonCallback(Action<string> _callback)
	{
	}

	public void ClearInput()
	{
	}

	public string GetInputText()
	{
		return null;
	}

	public void SetInputText(string _text)
	{
	}

	private void OnDestroy()
	{
	}
}
