using UnityEngine;
using UnityEngine.UI;

namespace ColorPickerUtil
{
	public class ColorPickingButton : MonoBehaviour
	{
		public Image targetGraphic;

		public ColorPicker colorPicker;

		public ColorPickerColorEvent onEndPick;

		public ColorPickerColorEvent onCancel;

		public ColorPickerColorEvent onNewColorValueChange;

		public void OnColorPickerOpen()
		{
		}

		private void OnEndPick(Color color)
		{
		}

		private void OnCancel(Color color)
		{
		}

		private void OnNewColorValueChange(Color color)
		{
		}
	}
}
