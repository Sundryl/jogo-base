using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class BasePanelUI : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CDelayedRefreshLayoutCoroutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int count;

		public RectTransform rectTransform;

		private int _003Ci_003E5__2;

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
		public _003CDelayedRefreshLayoutCoroutine_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CDelayedLayoutRefresh_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BasePanelUI _003C_003E4__this;

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
		public _003CDelayedLayoutRefresh_003Ed__31(int _003C_003E1__state)
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

	[SerializeField]
	[Header("基础组件")]
	protected CanvasGroup m_CanvasGroup;

	[SerializeField]
	protected Button m_CloseButton;

	[SerializeField]
	protected TextMeshProUGUI m_TitleText;

	[SerializeField]
	protected ColorPickerUI ColorPicker;

	[Header("面板设置")]
	[SerializeField]
	protected string m_PanelName;

	[SerializeField]
	protected bool m_CloseOnEscape;

	[SerializeField]
	protected bool m_EnableColorPicker;

	protected Dictionary<string, CollapsibleSectionUI> m_CollapsibleSections;

	protected Coroutine m_CurrentFadeCoroutine;

	public bool IsShowing => false;

	public string PanelName => null;

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Update()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public virtual void BringToFront()
	{
	}

	public void SetPanelPosition(Vector2 anchorMin, Vector2 anchorMax, Vector2 pivot, Vector2 anchoredPosition)
	{
	}

	public void SetPanelSize(Vector2 sizeDelta)
	{
	}

	public virtual void Show(Action _onComplete = null)
	{
	}

	public virtual void Hide(Action _onComplete = null)
	{
	}

	public virtual void SetTitle(string _titleKey, bool _isCustomText = false)
	{
	}

	public void RegisterCollapsibleSection(string _name, CollapsibleSectionUI _section)
	{
	}

	public CollapsibleSectionUI GetCollapsibleSection(string _name)
	{
		return null;
	}

	public virtual void RefreshLayout()
	{
	}

	protected virtual void OnPanelInitialize()
	{
	}

	protected virtual void OnPanelShow()
	{
	}

	protected virtual void OnPanelHide()
	{
	}

	protected virtual void OnCloseButtonClicked()
	{
	}

	protected void DelayedRefreshLayout(RectTransform rectTransform, int count = 2)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedRefreshLayoutCoroutine_003Ed__29))]
	protected IEnumerator DelayedRefreshLayoutCoroutine(RectTransform rectTransform, int count = 2)
	{
		return null;
	}

	protected virtual void RefreshLocalization()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedLayoutRefresh_003Ed__31))]
	private IEnumerator DelayedLayoutRefresh()
	{
		return null;
	}

	protected Transform FindDeepChild(Transform parent, string name)
	{
		return null;
	}
}
