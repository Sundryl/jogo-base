using TMPro;
using UnityEngine;

namespace Michsky.MUIP
{
	[RequireComponent(typeof(CustomInputField))]
	public class SliderInput : MonoBehaviour
	{
		[Header("Resources")]
		[SerializeField]
		private SliderManager sliderManager;

		private CustomInputField muipField;

		private TMP_InputField inputField;

		[Header("Settings")]
		[Range(1f, 10f)]
		public int maxChar;

		[Range(0f, 4f)]
		public int decimals;

		private void Awake()
		{
		}

		private void SetText(float value)
		{
		}

		private void SetValue()
		{
		}
	}
}
