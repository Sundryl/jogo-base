using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerToggle : MonoBehaviour
	{
		[SerializeField]
		[Header("Settings")]
		private UIManager UIManagerAsset;

		[SerializeField]
		[Header("Resources")]
		private Image border;

		[SerializeField]
		private Image background;

		[SerializeField]
		private Image check;

		[SerializeField]
		private TextMeshProUGUI onLabel;

		[SerializeField]
		private TextMeshProUGUI offLabel;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateToggle()
		{
		}
	}
}
