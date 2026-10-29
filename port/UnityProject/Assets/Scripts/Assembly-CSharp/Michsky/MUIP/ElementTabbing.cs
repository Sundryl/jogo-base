using UnityEngine;

namespace Michsky.MUIP
{
	[AddComponentMenu("Modern UI Pack/Tools/Element Tabbing")]
	public class ElementTabbing : MonoBehaviour
	{
		public enum ObjectType
		{
			Button = 0,
			InputField = 1
		}

		private int currentIndex;

		private bool catchedObject;

		private ObjectType type;

		private void Update()
		{
		}

		private void SelectElement(int index)
		{
		}
	}
}
