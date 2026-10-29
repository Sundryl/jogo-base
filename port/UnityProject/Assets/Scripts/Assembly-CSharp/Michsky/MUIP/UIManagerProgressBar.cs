using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerProgressBar : MonoBehaviour
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
		private Image bar;

		[SerializeField]
		private Image background;

		[SerializeField]
		private TextMeshProUGUI label;

		private bool dynamicUpdateEnabled;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateProgressBar()
		{
		}
	}
}
