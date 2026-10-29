using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	[ExecuteInEditMode]
	public class ButtonManager : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, ISubmitHandler
	{
		public enum AnimationSolution
		{
			Custom = 0,
			ScriptBased = 1
		}

		public enum RippleUpdateMode
		{
			Normal = 0,
			UnscaledTime = 1
		}

		[Serializable]
		public class Padding
		{
			public int left;

			public int right;

			public int top;

			public int bottom;
		}

		[CompilerGenerated]
		private sealed class _003CLayoutFix_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ButtonManager _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLayoutFix_003Ed__85(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSetNormal_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ButtonManager _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSetNormal_003Ed__86(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSetHighlight_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ButtonManager _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSetHighlight_003Ed__87(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSetDisabled_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ButtonManager _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSetDisabled_003Ed__88(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCheckForDoubleClick_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ButtonManager _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCheckForDoubleClick_003Ed__89(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CInitUINavigation_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ButtonManager _003C_003E4__this;

			public Navigation nav;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitUINavigation_003Ed__90(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public Sprite buttonIcon;

		public string buttonText;

		[Range(0.1f, 10f)]
		public float iconScale;

		[Range(10f, 200f)]
		public float textSize;

		public bool autoFitContent;

		public Padding padding;

		[Range(0f, 100f)]
		public int spacing;

		public HorizontalLayoutGroup disabledLayout;

		public HorizontalLayoutGroup normalLayout;

		public HorizontalLayoutGroup highlightedLayout;

		[SerializeField]
		private HorizontalLayoutGroup mainLayout;

		[SerializeField]
		private ContentSizeFitter mainFitter;

		[SerializeField]
		private ContentSizeFitter targetFitter;

		[SerializeField]
		private RectTransform targetRect;

		public CanvasGroup normalCG;

		public CanvasGroup highlightCG;

		public CanvasGroup disabledCG;

		public TextMeshProUGUI normalText;

		public TextMeshProUGUI highlightedText;

		public TextMeshProUGUI disabledText;

		public Image normalImage;

		public Image highlightImage;

		public Image disabledImage;

		public AudioSource soundSource;

		[SerializeField]
		private GameObject rippleParent;

		public bool isInteractable;

		public bool enableIcon;

		public bool enableText;

		public bool useCustomContent;

		[SerializeField]
		private bool useCustomTextSize;

		public bool checkForDoubleClick;

		public bool enableButtonSounds;

		public bool useHoverSound;

		public bool useClickSound;

		public AudioClip hoverSound;

		public AudioClip clickSound;

		public bool useUINavigation;

		public Navigation.Mode navigationMode;

		public GameObject selectOnUp;

		public GameObject selectOnDown;

		public GameObject selectOnLeft;

		public GameObject selectOnRight;

		public bool wrapAround;

		public bool useRipple;

		[Range(0.1f, 1f)]
		public float doubleClickPeriod;

		[Range(0.25f, 15f)]
		public float fadingMultiplier;

		[SerializeField]
		private AnimationSolution animationSolution;

		public UnityEvent onClick;

		public UnityEvent onDoubleClick;

		public UnityEvent onHover;

		public UnityEvent onLeave;

		[SerializeField]
		private RippleUpdateMode rippleUpdateMode;

		[SerializeField]
		private Canvas targetCanvas;

		public Sprite rippleShape;

		[Range(0.1f, 5f)]
		public float speed;

		[Range(0.5f, 25f)]
		public float maxSize;

		public Color startColor;

		public Color transitionColor;

		[SerializeField]
		private bool renderOnTop;

		[SerializeField]
		private bool centered;

		private bool isInitialized;

		public bool isForceHighlighed;

		private Button targetButton;

		private bool isPointerOn;

		private bool waitingForDoubleClickInput;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Initialize()
		{
		}

		public void UpdateUI()
		{
		}

		public void SetText(string text)
		{
		}

		public void SetIcon(Sprite icon)
		{
		}

		public void Interactable(bool value)
		{
		}

		public void AddUINavigation()
		{
		}

		public void CreateRipple(Vector2 pos)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		[IteratorStateMachine(typeof(_003CLayoutFix_003Ed__85))]
		private IEnumerator LayoutFix()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSetNormal_003Ed__86))]
		private IEnumerator SetNormal()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSetHighlight_003Ed__87))]
		private IEnumerator SetHighlight()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSetDisabled_003Ed__88))]
		private IEnumerator SetDisabled()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckForDoubleClick_003Ed__89))]
		private IEnumerator CheckForDoubleClick()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInitUINavigation_003Ed__90))]
		private IEnumerator InitUINavigation(Navigation nav)
		{
			return null;
		}
	}
}
