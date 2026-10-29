using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CollapsibleSectionUI : MonoBehaviour
{
	public delegate void ExpandEventHandler(CollapsibleSectionUI section);

	public delegate void CollapseEventHandler(CollapsibleSectionUI section);

	[CompilerGenerated]
	private sealed class _003CDelayedLayoutRefresh_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollapsibleSectionUI _003C_003E4__this;

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
		public _003CDelayedLayoutRefresh_003Ed__39(int _003C_003E1__state)
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
	private GameObject m_ContentContainer;

	[SerializeField]
	private Button m_ToggleButton;

	[SerializeField]
	private Image m_ChevronImage;

	[SerializeField]
	private Sprite m_ChevronDownSprite;

	[SerializeField]
	private Sprite m_ChevronUpSprite;

	[SerializeField]
	private bool m_StartExpanded;

	[SerializeField]
	private float m_AnimationDuration;

	[SerializeField]
	private TextMeshProUGUI m_TitleText;

	[SerializeField]
	private bool m_DisableMPImageWhenExpanded;

	[Header("事件")]
	[SerializeField]
	private UnityEvent m_OnExpand;

	[SerializeField]
	private UnityEvent m_OnCollapse;

	[CompilerGenerated]
	private ExpandEventHandler m_OnExpandEvent;

	[CompilerGenerated]
	private CollapseEventHandler m_OnCollapseEvent;

	private List<GameObject> m_InfoRows;

	public GameObject RowInfoPrefab;

	private bool m_IsExpanded;

	private RectTransform m_ContentRectTransform;

	public bool IsExpanded => false;

	public GameObject ContentContainer => null;

	public event ExpandEventHandler OnExpandEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event CollapseEventHandler OnCollapseEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public virtual void UpdateInfo(List<string> _infoListKey, List<string> _infoListValue, TextAlignmentOptions _alignment = TextAlignmentOptions.Left, List<UnityAction> _valueClickActions = null, List<TooltipContentProvider> _tooltipProviders = null)
	{
	}

	private void AdjustRowCount(int _requiredCount)
	{
	}

	private void OnDestroy()
	{
	}

	private void InitializeComponents()
	{
	}

	private void DisableHeaderRaycastTargets()
	{
	}

	public void ToggleContent()
	{
	}

	public void Expand(bool _animate = true)
	{
	}

	public void Collapse(bool _animate = true)
	{
	}

	private void UpdateUI(bool _animate)
	{
	}

	private void UpdateChildLayouts(RectTransform _parent)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedLayoutRefresh_003Ed__39))]
	private IEnumerator DelayedLayoutRefresh()
	{
		return null;
	}

	public void UpdateTitle(string _title)
	{
	}

	public void SetTitleKey(string _titleKey)
	{
	}

	public void AddExpandListener(ExpandEventHandler _callback)
	{
	}

	public void RemoveExpandListener(ExpandEventHandler _callback)
	{
	}

	public void AddCollapseListener(CollapseEventHandler _callback)
	{
	}

	public void RemoveCollapseListener(CollapseEventHandler _callback)
	{
	}

	public void ExpandAndUpdate()
	{
	}

	public void CollapseSection()
	{
	}

	public void ToggleSection()
	{
	}
}
