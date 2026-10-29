using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerSlider : MonoBehaviour
	{
		[SerializeField]
		[Header("Settings")]
		private UIManager UIManagerAsset;

		public bool hasLabel;

		public bool hasPopupLabel;

		[HideInInspector]
		public bool overrideColors;

		[HideInInspector]
		public bool overrideFonts;

		[Header("Resources")]
		[SerializeField]
		private Image background;

		[SerializeField]
		private Image bar;

		[SerializeField]
		private Image handle;

		[HideInInspector]
		public TextMeshProUGUI label;

		[HideInInspector]
		public TextMeshProUGUI popupLabel;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateSlider()
		{
		}
	}
}
