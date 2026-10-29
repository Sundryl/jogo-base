using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerDropdownItem : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		private UIManager UIManagerAsset;

		public bool overrideColors;

		public bool overrideFonts;

		[Header("Resources")]
		[SerializeField]
		private Image itemBackground;

		[SerializeField]
		private Image itemIcon;

		[SerializeField]
		private TextMeshProUGUI itemText;

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
