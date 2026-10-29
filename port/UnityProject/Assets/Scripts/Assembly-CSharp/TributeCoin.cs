using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TributeCoin : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimationSequence_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TributeCoin _003C_003E4__this;

		private float _003CappearTime_003E5__2;

		private float _003CsettleTime_003E5__3;

		private float _003CgatherTime_003E5__4;

		private Vector3 _003CcurrentPos_003E5__5;

		private float _003CspiralRadius_003E5__6;

		private float _003CspiralHeight_003E5__7;

		private float _003CflyTime_003E5__8;

		private Vector3 _003CflyStartPos_003E5__9;

		private Vector3 _003CcontrolPoint_003E5__10;

		private Vector3 _003ClastPos_003E5__11;

		private float _003CexplodeTime_003E5__12;

		private Vector3 _003CfinalScale_003E5__13;

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
		public _003CAnimationSequence_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CLineAnimationSequence_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TributeCoin _003C_003E4__this;

		public float queuePosition;

		private float _003CappearTime_003E5__2;

		private float _003CgatherTime_003E5__3;

		private Vector3 _003CcurrentPos_003E5__4;

		private float _003ClineFormTime_003E5__5;

		private float _003ClineFormDuration_003E5__6;

		private Vector3 _003CgatherPos_003E5__7;

		private Vector3 _003ClinePosition_003E5__8;

		private float _003CflyTime_003E5__9;

		private Vector3 _003CflyStartPos_003E5__10;

		private Vector3 _003CfinalTarget_003E5__11;

		private float _003CfadeTime_003E5__12;

		private Vector3 _003CarrivalScale_003E5__13;

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
		public _003CLineAnimationSequence_003Ed__25(int _003C_003E1__state)
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

	private const float c_AppearDuration = 0.3f;

	private const float c_GatherDuration = 1.2f;

	private const float c_FlyDuration = 2.5f;

	private const float c_FadeOutDuration = 0.2f;

	private const float c_InitialScale = 0.3f;

	private const float c_NormalScale = 0.7f;

	private const float c_BounceScale = 0.85f;

	private const float c_RotationSpeed = 360f;

	private const float c_FloatAmplitude = 0.05f;

	private const float c_FloatSpeed = 3f;

	private const float c_ShineInterval = 1.5f;

	private const float c_TrailLength = 0.5f;

	private TributeAnimationManager m_Manager;

	private SpriteRenderer m_SpriteRenderer;

	private Coroutine m_AnimationCoroutine;

	private Vector3 m_OriginalScale;

	private Color m_OriginalColor;

	private Vector3 m_StartPosition;

	private Vector3 m_GatherPosition;

	private Vector3 m_TargetPosition;

	private float m_StartDelay;

	private void Awake()
	{
	}

	public void PlayAnimation(Vector3 startPos, Vector3 gatherPos, Vector3 targetPos, TributeAnimationManager manager, float startDelay = 0f)
	{
	}

	public void PlayLineAnimation(Vector3 spawnPos, Vector3 startPoint, Vector3 targetPos, TributeAnimationManager manager, float startDelay, float queuePosition)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimationSequence_003Ed__24))]
	private IEnumerator AnimationSequence()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLineAnimationSequence_003Ed__25))]
	private IEnumerator LineAnimationSequence(float queuePosition)
	{
		return null;
	}

	private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default;
	}

	private void OnAnimationComplete()
	{
	}

	public void StopAnimation()
	{
	}

	private void ResetCoin()
	{
	}

	private void OnDisable()
	{
	}
}
