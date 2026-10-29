using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RTSClickAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateChevrons_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isAttackMode;

		public RTSClickAnimator _003C_003E4__this;

		public Vector3 centerPos;

		private Vector3[] _003Cdirections_003E5__2;

		private float _003Cduration_003E5__3;

		private float _003CstartScale_003E5__4;

		private float _003CendScale_003E5__5;

		private float _003CstartDistance_003E5__6;

		private float _003CendDistance_003E5__7;

		private Color _003Ccolor_003E5__8;

		private float _003CelapsedTime_003E5__9;

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
		public _003CAnimateChevrons_003Ed__10(int _003C_003E1__state)
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

	private static RTSClickAnimator _instance;

	private Sprite m_ChevronSprite;

	private GameObject[] m_ChevronObjects;

	private SpriteRenderer[] m_ChevronRenderers;

	public static RTSClickAnimator Instance => null;

	private void Awake()
	{
	}

	private void LoadChevronSprite()
	{
	}

	private void CreateChevronObjects()
	{
	}

	public void PlayClickAnimation(Vector3 worldPosition, bool isAttackMode)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateChevrons_003Ed__10))]
	private IEnumerator AnimateChevrons(Vector3 centerPos, bool isAttackMode)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
