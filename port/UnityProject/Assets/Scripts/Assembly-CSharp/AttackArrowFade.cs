using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cogobyte.SmartProceduralIndicators;
using UnityEngine;

internal class AttackArrowFade : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFadeInCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackArrowFade _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		private float _003Cduration_003E5__3;

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
		public _003CFadeInCoroutine_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CFadeOutCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackArrowFade _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		private float _003Cduration_003E5__3;

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
		public _003CFadeOutCoroutine_003Ed__13(int _003C_003E1__state)
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

	private SmartArrow smartArrow;

	private Coroutine fadeInCoroutine;

	private Coroutine fadeOutCoroutine;

	public static GameObject controlPointPrefab;

	public int riverID;

	private float speed;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void FadeOut()
	{
	}

	public void FadeIn()
	{
	}

	private void OnMouseDown()
	{
	}

	private void CreateControlPointsForRiver(int riverID)
	{
	}

	[IteratorStateMachine(typeof(_003CFadeInCoroutine_003Ed__12))]
	private IEnumerator FadeInCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeOutCoroutine_003Ed__13))]
	private IEnumerator FadeOutCoroutine()
	{
		return null;
	}

	public void ShowComplete()
	{
	}
}
