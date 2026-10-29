using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameInputListComponent : MonoBehaviour
{
	[Header("引用")]
	[SerializeField]
	private TMP_InputField m_InputField;

	[SerializeField]
	private Button m_TranslateButton;

	[SerializeField]
	private Button m_DeleteButton;

	[SerializeField]
	private LocalizationTmpInputField m_LocalizationInputField;

	private Action<string> m_OnInputValueChanged;

	private Action<string> m_OnTranslateButtonClicked;

	private Action m_OnDeleteButtonClicked;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void InitializeComponents()
	{
	}

	private void InitializeListeners()
	{
	}

	private void RemoveListeners()
	{
	}

	private void OnInputFieldValueChanged(string _value)
	{
	}

	private void OnTranslateButtonClick()
	{
	}

	private void OnDeleteButtonClick()
	{
	}

	public void SetInputText(string _text)
	{
	}

	public void SetInputText(string _text, string _language)
	{
	}

	public string GetInputText()
	{
		return null;
	}

	public void SetInputFieldInteractable(bool _interactable)
	{
	}

	public void SetTranslateButtonInteractable(bool _interactable)
	{
	}

	public void SetDeleteButtonInteractable(bool _interactable)
	{
	}

	public void SetOnInputValueChangedCallback(Action<string> _callback)
	{
	}

	public void SetOnTranslateButtonClickedCallback(Action<string> _callback)
	{
	}

	public void SetOnDeleteButtonClickedCallback(Action _callback)
	{
	}
}
