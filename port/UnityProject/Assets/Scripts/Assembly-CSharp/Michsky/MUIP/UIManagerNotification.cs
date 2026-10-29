using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerNotification : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		private UIManager UIManagerAsset;

		[HideInInspector]
		public bool overrideColors;

		[HideInInspector]
		public bool overrideFonts;

		[Header("Resources")]
		[SerializeField]
		private Image background;

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

		private void UpdateNotification()
		{
		}
	}
}
