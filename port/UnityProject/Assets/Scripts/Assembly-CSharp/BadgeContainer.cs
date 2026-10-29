using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BadgeContainer : MonoBehaviour
{
	public delegate void BadgeContainerRemoveHandler(string traitKey);

	[CompilerGenerated]
	private sealed class _003CDelayedRebuild_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BadgeContainer _003C_003E4__this;

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
		public _003CDelayedRebuild_003Ed__21(int _003C_003E1__state)
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

	[Header("Badge设置")]
	public GameObject badgeItemPrefab;

	[Tooltip("自动刷新布局的延迟时间(秒)")]
	[Header("布局设置")]
	public float rebuildDelay;

	[Tooltip("面板最大宽度")]
	public float panelMaxWidth;

	[Tooltip("Badge之间的水平间距")]
	public float horizontalSpacing;

	[Tooltip("行之间的垂直间距")]
	public float verticalSpacing;

	[Header("随机属性设置")]
	[Tooltip("是否在启动时添加随机属性")]
	public bool addRandomTraitsOnStart;

	[Tooltip("随机属性的名称列表")]
	private List<string> activeTraits;

	private Dictionary<string, GameObject> badgeItems;

	private Dictionary<string, BadgeItem> badgeComponents;

	private Coroutine rebuildCoroutine;

	private RectTransform containerRect;

	[CompilerGenerated]
	private BadgeContainerRemoveHandler m_OnBadgeRemoved;

	public event BadgeContainerRemoveHandler OnBadgeRemoved
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

	public void AddTrait(string traitText, string traitKey)
	{
	}

	private void HandleBadgeRemoved(string traitKey)
	{
	}

	public void RemoveTrait(string traitKey)
	{
	}

	public void ScheduleRebuild()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedRebuild_003Ed__21))]
	private IEnumerator DelayedRebuild()
	{
		return null;
	}

	private void RebuildParentLayout()
	{
	}

	private void CalculateCustomLayout()
	{
	}

	public List<string> GetActiveTraits()
	{
		return null;
	}

	public bool HasTrait(string traitKey)
	{
		return false;
	}

	public int GetTraitCount()
	{
		return 0;
	}

	public void ClearAllTraits()
	{
	}
}
