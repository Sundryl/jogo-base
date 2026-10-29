using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerProgressBarLoop : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		private UIManager UIManagerAsset;

		public bool hasBackground;

		public bool useRegularBackground;

		public bool overrideColors;

		[Header("Resources")]
		public Image bar;

		[HideInInspector]
		public Image background;

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
