using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	public class ProgressBar : MonoBehaviour
	{
		[Serializable]
		public class ProgressBarEvent : UnityEvent<float>
		{
		}

		public float currentPercent;

		[Range(0f, 100f)]
		public int speed;

		public float minValue;

		public float maxValue;

		public float valueLimit;

		public Image loadingBar;

		public TextMeshProUGUI textPercent;

		public bool isOn;

		public bool restart;

		public bool invert;

		public bool addPrefix;

		public bool addSuffix;

		public string prefix;

		public string suffix;

		public bool isLooped;

		[Range(0f, 5f)]
		public int decimals;

		public ProgressBarEvent onValueChanged;

		[HideInInspector]
		public Slider eventSource;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void UpdateUI()
		{
		}

		public void InitializeEvents()
		{
		}

		public void ClearEvents()
		{
		}

		public void ChangeValue(float newValue)
		{
		}
	}
}
