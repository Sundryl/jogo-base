using System;
using UnityEngine;
using UnityEngine.Events;

namespace ColorPickerUtil
{
	[Serializable]
	public class ColorPickerColorEvent : UnityEvent<Color>
	{
	}
}
