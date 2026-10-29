using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerInputField : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		private UIManager UIManagerAsset;

		public bool overrideColors;

		public bool overrideFonts;

		[Header("Resources")]
		[SerializeField]
		private TextMeshProUGUI mainText;

		[SerializeField]
		private TextMeshProUGUI placeholderText;

		[SerializeField]
		private Image filledImage;

		[SerializeField]
		private Image backgroundImage;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateInputField()
		{
		}
	}
}
