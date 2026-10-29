using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ColorPickerUtil
{
	public class ColorSwatch : MonoBehaviour
	{
		[SerializeField]
		private Transform buttonHolder;

		[SerializeField]
		private RectTransform indicator;

		public Image targetGraphic;

		public Image sourceGraphic;

		public List<Color> colors;

		public ColorPickerColorEvent onPickColor;

		private ColorSwatchButton[] buttons;

		private ColorSwatchButton selectedButton;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Initialize()
		{
		}

		private void Refresh(int start = 0)
		{
		}

		public void Deselect()
		{
		}

		public void OnPickColor(ColorSwatchButton btn)
		{
		}

		public void AddColor()
		{
		}

		public void RemoveColor()
		{
		}
	}
}
