using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberStepper : MonoBehaviour
{
	[SerializeField]
	private TMP_InputField m_InputField;

	[SerializeField]
	private Button m_IncreaseButton;

	[SerializeField]
	private Button m_DecreaseButton;

	[SerializeField]
	private LocalizationText m_LabelText;

	[Header("步进器设置")]
	[SerializeField]
	private float m_StepValue;

	[SerializeField]
	private float m_MinValue;

	[SerializeField]
	private float m_MaxValue;

	[SerializeField]
	private float m_DefaultValue;

	[SerializeField]
	private bool m_IntegerOnly;

	[SerializeField]
	private string m_LabelKey;

	private Action<float> m_OnValueChanged;

	private Action<float> m_OnIncreaseClicked;

	private Action<float> m_OnDecreaseClicked;

	private float m_CurrentValue;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnIncreaseButtonClicked()
	{
	}

	private void OnDecreaseButtonClicked()
	{
	}

	private void OnInputFieldEndEdit(string text)
	{
	}

	private void UpdateInputFieldText()
	{
	}

	public void SetValue(float _value)
	{
	}

	public float GetValue()
	{
		return 0f;
	}

	public int GetIntValue()
	{
		return 0;
	}

	public void SetValueChangedCallback(Action<float> _callback)
	{
	}

	public void SetIncreaseCallback(Action<float> _callback)
	{
	}

	public void SetDecreaseCallback(Action<float> _callback)
	{
	}

	public void SetLabelKey(string _key)
	{
	}

	public void SetStepValue(float _stepValue)
	{
	}

	public void SetMinValue(float _minValue)
	{
	}

	public void SetMaxValue(float _maxValue)
	{
	}

	public void SetIntegerOnly(bool _integerOnly)
	{
	}

	public void SetInteractable(bool _interactable)
	{
	}

	public void ResetToDefault()
	{
	}
}
