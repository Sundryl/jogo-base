using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("Modern UI Pack/UI Manager/UI Manager (Custom Object)")]
	public class UIManagerCustom : MonoBehaviour
	{
		public enum ObjectType
		{
			Text = 0,
			Image = 1
		}

		public enum ColorType
		{
			Primary = 0,
			Secondary = 1
		}

		public enum FontType
		{
			Primary = 0,
			Secondary = 1
		}

		[Header("Resources")]
		public UIManager UIManagerAsset;

		[Header("Settings")]
		public ObjectType objectType;

		[Header("Color")]
		public ColorType colorType;

		public bool keepAlphaValue;

		public bool useCustomColor;

		[Header("Font")]
		public FontType fontType;

		public bool useCustomFont;

		private Image imageObject;

		private TextMeshProUGUI textObject;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void UpdateElement()
		{
		}
	}
}
