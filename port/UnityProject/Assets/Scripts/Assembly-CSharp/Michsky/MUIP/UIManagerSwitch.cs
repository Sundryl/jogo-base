using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerSwitch : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		private UIManager UIManagerAsset;

		[HideInInspector]
		public bool overrideColors;

		[SerializeField]
		[Header("Resources")]
		private Image border;

		[SerializeField]
		private Image background;

		[SerializeField]
		private Image handleOn;

		[SerializeField]
		private Image handleOff;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateSwitch()
		{
		}
	}
}
