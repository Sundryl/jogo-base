using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SliderValueConnector : MonoBehaviour
{
	[Serializable]
	public struct SliderSettings
	{
		public float MinValue;

		public float MaxValue;

		public float DefaultValue;

		public SliderSettings(float minValue = 0f, float maxValue = 1f, float defaultValue = 0.5f)
		{
			MinValue = 0f;
			MaxValue = 0f;
			DefaultValue = 0f;
		}
	}

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private TMP_Text valueText;

	[SerializeField]
	private LocalizationText m_TitleText;

	[SerializeField]
	private string m_TitleTextKey;

	[SerializeField]
	private string formatString;

	[Header("Slider Configuration")]
	[SerializeField]
	public SliderSettings m_InitialSettings;

	[SerializeField]
	private bool m_DisableValueTextInput;

	[SerializeField]
	private bool m_AllowInputOutsideSliderRange;

	private readonly UnityEvent<float> m_ValueInputOutsideSliderRangeListeners;

	private TMP_InputField m_ValueInputField;

	private RectTransform m_ValueInputRoot;

	private RectTransform m_ValueInputViewport;

	private TMP_Text m_ValueInputText;

	private RectTransform m_ValueInputTextRectTransform;

	private Vector2 m_ValueInputTextOriginalAnchoredPosition;

	private bool m_HasValueInputTextOriginalAnchoredPosition;

	private Color m_OriginalValueTextColor;

	private bool m_HasOriginalValueTextColor;

	private float m_LastDisplayedValue;

	public float Value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MinValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MaxValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	private void AddListener()
	{
	}

	private void RemoveListener()
	{
	}

	private void UpdateValueText(float value)
	{
	}

	private void EnsureReferences()
	{
	}

	private TMP_Text FindValueText()
	{
		return null;
	}

	private void SetupValueTextInput()
	{
	}

	private void RemoveValueInputListener()
	{
	}

	private void EnsureValueInputObjects()
	{
	}

	private void CopyValueTextStyle()
	{
	}

	private void ConfigureValueInputViewportRect()
	{
	}

	private void ConfigureValueInputTextRect()
	{
	}

	private void OnValueInputSelected(string _text)
	{
	}

	private void OnValueInputChanged(string _text)
	{
	}

	private void OnValueInputDeselected(string _text)
	{
	}

	private void ApplyValueInputFocusedVisual()
	{
	}

	private void SetValueInputNormalVisual()
	{
	}

	private void CacheOriginalValueTextColor()
	{
	}

	private void HideOriginalValueTextVisual()
	{
	}

	private void RestoreOriginalValueTextVisual()
	{
	}

	private void RestoreValueInputTextAnchoredPosition()
	{
	}

	private void OnValueInputEndEdit(string _text)
	{
	}

	public void SetValue(float _value, bool _notifyCallback = true)
	{
	}

	public void SetValueRange(float _minValue, float _maxValue)
	{
	}

	public void ApplySettings(SliderSettings _settings)
	{
	}

	public void InitializeSliderFromSettings()
	{
	}

	public void AddValueChangedListener(UnityAction<float> _listener)
	{
	}

	public void RemoveValueChangedListener(UnityAction<float> _listener)
	{
	}

	public void SetFormatString(string _formatString)
	{
	}

	public void SetTitleLocalizationKey(string _key)
	{
	}

	public void SetValueTextInputEnabled(bool _isEnabled)
	{
	}

	public void SetAllowInputOutsideSliderRange(bool _isAllowed)
	{
	}

	public void AddValueInputOutsideSliderRangeListener(UnityAction<float> _listener)
	{
	}

	public void RemoveValueInputOutsideSliderRangeListener(UnityAction<float> _listener)
	{
	}

	private static bool TryParseFiniteFloat(string _text, out float _value)
	{
		_value = default;
		return false;
	}

	public float GetRecommendedScrollStep(float _normalizedRangeFactor = 0.01f, float _minStep = 0.1f)
	{
		return 0f;
	}

	public bool AdjustValue(float _delta, bool _notifyCallback = true)
	{
		return false;
	}
}
