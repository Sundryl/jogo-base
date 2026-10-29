using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerModalWindow : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		private UIManager UIManagerAsset;

		[Header("Resources")]
		[SerializeField]
		private Image background;

		[SerializeField]
		private Image contentBackground;

		[SerializeField]
		private Image icon;

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private TextMeshProUGUI description;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateModalWindow()
		{
		}
	}
}
