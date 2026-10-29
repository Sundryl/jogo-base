using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Michsky.MUIP
{
	public class DemoElementSway : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		[CompilerGenerated]
		private sealed class _003CDissolveHelper_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DemoElementSway _003C_003E4__this;

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
			public _003CDissolveHelper_003Ed__27(int _003C_003E1__state)
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
		private sealed class _003CHighlightHelper_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DemoElementSway _003C_003E4__this;

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
			public _003CHighlightHelper_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CActiveHelper_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DemoElementSway _003C_003E4__this;

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
			public _003CActiveHelper_003Ed__29(int _003C_003E1__state)
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
		private sealed class _003CWMSelectHelper_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DemoElementSway _003C_003E4__this;

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
			public _003CWMSelectHelper_003Ed__30(int _003C_003E1__state)
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
		private sealed class _003CWMDeselectHelper_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DemoElementSway _003C_003E4__this;

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
			public _003CWMDeselectHelper_003Ed__31(int _003C_003E1__state)
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

		[Header("Resources")]
		[SerializeField]
		private DemoElementSwayParent swayParent;

		[SerializeField]
		private Canvas mainCanvas;

		[SerializeField]
		private RectTransform swayObject;

		[SerializeField]
		private CanvasGroup normalCG;

		[SerializeField]
		private CanvasGroup highlightedCG;

		[SerializeField]
		private CanvasGroup selectedCG;

		[SerializeField]
		[Header("Settings")]
		private float smoothness;

		[SerializeField]
		private float transitionSpeed;

		[SerializeField]
		[Range(0f, 1f)]
		private float dissolveAlpha;

		[SerializeField]
		[Header("Events")]
		private UnityEvent onClick;

		private bool allowSway;

		[HideInInspector]
		public bool wmSelected;

		private Vector3 cursorPos;

		private Vector2 defaultPos;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void ProcessOverlay()
		{
		}

		private void ProcessSSC()
		{
		}

		private void ProcessWorldSpace()
		{
		}

		public void Dissolve()
		{
		}

		public void Highlight()
		{
		}

		public void Active()
		{
		}

		public void WindowManagerSelect()
		{
		}

		public void WindowManagerDeselect()
		{
		}

		public void OnPointerEnter(PointerEventData data)
		{
		}

		public void OnPointerExit(PointerEventData data)
		{
		}

		public void OnPointerClick(PointerEventData data)
		{
		}

		[IteratorStateMachine(typeof(_003CDissolveHelper_003Ed__27))]
		private IEnumerator DissolveHelper()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CHighlightHelper_003Ed__28))]
		private IEnumerator HighlightHelper()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CActiveHelper_003Ed__29))]
		private IEnumerator ActiveHelper()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWMSelectHelper_003Ed__30))]
		private IEnumerator WMSelectHelper()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWMDeselectHelper_003Ed__31))]
		private IEnumerator WMDeselectHelper()
		{
			return null;
		}
	}
}
