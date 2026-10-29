using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(ButtonManager))]
	public class UIManagerButton : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		private bool outlineMode;

		[Header("Resources")]
		[SerializeField]
		private UIManager UIManagerAsset;

		public ButtonManager buttonManager;

		[HideInInspector]
		public bool overrideColors;

		[HideInInspector]
		public bool overrideFonts;

		[HideInInspector]
		public Image disabledBackground;

		[HideInInspector]
		public Image normalBackground;

		[HideInInspector]
		public Image highlightedBackground;

		[HideInInspector]
		public Image disabledIcon;

		[HideInInspector]
		public Image normalIcon;

		[HideInInspector]
		public Image highlightedIcon;

		[HideInInspector]
		public TextMeshProUGUI disabledText;

		[HideInInspector]
		public TextMeshProUGUI normalText;

		[HideInInspector]
		public TextMeshProUGUI highlightedText;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateButton()
		{
		}
	}
}
