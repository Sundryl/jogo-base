using UnityEngine;
using UnityEngine.EventSystems;

namespace Michsky.MUIP
{
	[RequireComponent(typeof(Animator))]
	public class WindowManagerButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		public bool enableMobileMode;

		[HideInInspector]
		public Animator buttonAnimator;

		private void Awake()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
