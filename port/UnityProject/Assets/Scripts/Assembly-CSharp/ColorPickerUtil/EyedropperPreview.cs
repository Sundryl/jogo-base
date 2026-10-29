using UnityEngine;
using UnityEngine.UI;

namespace ColorPickerUtil
{
	public class EyedropperPreview : MonoBehaviour
	{
		public RawImage image;

		public Image grid;

		public Image gridCenter;

		[Range(1f, 10f)]
		public float gridLineWidth;

		[Range(1f, 10f)]
		public int resolution;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		public void RefreshGrid()
		{
		}
	}
}
