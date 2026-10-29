using TMPro;
using UnityEngine;

namespace Michsky.MUIP
{
	public class PBFilled : MonoBehaviour
	{
		[Header("Resources")]
		public TextMeshProUGUI minLabel;

		public TextMeshProUGUI maxLabel;

		[Header("Settings")]
		[Range(0f, 100f)]
		public int transitionAfter;

		public Color minColor;

		public Color maxColor;

		private ProgressBar progressBar;

		private Animator barAnimatior;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
