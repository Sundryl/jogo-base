using TMPro;
using UnityEngine;

namespace Michsky.MUIP
{
	public class RangeSlider : MonoBehaviour
	{
		[Header("Settings")]
		[Range(0f, 2f)]
		public int decimalPlaces;

		public float minValue;

		public float maxValue;

		public bool showLabels;

		public bool useWholeNumbers;

		[Header("Min Slider")]
		public RangeMinSlider minSlider;

		public TextMeshProUGUI minSliderLabel;

		[Header("Max Slider")]
		public RangeMaxSlider maxSlider;

		public TextMeshProUGUI maxSliderLabel;

		public float CurrentLowerValue => 0f;

		public float CurrentUpperValue => 0f;

		private void Awake()
		{
		}

		public void CheckForMinState(float value)
		{
		}
	}
}
