using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerDropdown : MonoBehaviour
	{
		[HideInInspector]
		public bool overrideColors;

		[HideInInspector]
		public bool overrideFonts;

		[Header("Resources")]
		[SerializeField]
		private UIManager UIManagerAsset;

		[SerializeField]
		private Image background;

		[SerializeField]
		private Image contentBackground;

		[SerializeField]
		private Image mainIcon;

		[SerializeField]
		private TextMeshProUGUI mainText;

		[SerializeField]
		private Image expandIcon;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateDropdown()
		{
		}
	}
}
