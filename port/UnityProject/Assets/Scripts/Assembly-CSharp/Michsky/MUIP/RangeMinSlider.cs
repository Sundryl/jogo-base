using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	public class RangeMinSlider : Slider
	{
		[Header("RESOURCES")]
		public RangeMaxSlider maxSlider;

		public TextMeshProUGUI label;

		public string numberFormat;

		protected override void Set(float input, bool sendCallback)
		{
		}

		public void Refresh(float input)
		{
		}
	}
}
