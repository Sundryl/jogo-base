using UnityEngine;
using UnityEngine.UI;

namespace ColorPickerUtil
{
	[RequireComponent(typeof(Button))]
	public class ColorSwatchButton : MonoBehaviour
	{
		private ColorSwatch colorSwatch;

		private Button btn;

		private int index;

		public int Index => 0;

		public void Initialize(ColorSwatch colorSwatch, int index)
		{
		}

		public void SetColor(Color c)
		{
		}

		private void OnClick()
		{
		}
	}
}
