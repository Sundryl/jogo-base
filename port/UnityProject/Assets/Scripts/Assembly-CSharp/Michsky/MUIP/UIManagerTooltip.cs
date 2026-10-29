using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerTooltip : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		private UIManager UIManagerAsset;

		[Header("Resources")]
		[SerializeField]
		private Image background;

		[SerializeField]
		private TextMeshProUGUI text;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateTooltip()
		{
		}
	}
}
