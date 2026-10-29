using System.Collections.Generic;
using UnityEngine;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class UIManagerHSelector : MonoBehaviour
	{
		[SerializeField]
		[Header("Settings")]
		private UIManager UIManagerAsset;

		[HideInInspector]
		public bool overrideColors;

		[HideInInspector]
		public bool overrideFonts;

		[Header("Resources")]
		[SerializeField]
		private List<GameObject> images;

		[SerializeField]
		private List<GameObject> imagesHighlighted;

		[SerializeField]
		private List<GameObject> texts;

		private Color latestColor;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateSelector()
		{
		}
	}
}
