using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RebellionFlag : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimationSequence_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RebellionFlag _003C_003E4__this;

		private float _003CimpactTime_003E5__2;

		private Vector3 _003CtargetScale_003E5__3;

		private float _003CsettleTime_003E5__4;

		private float _003CsettleDuration_003E5__5;

		private Vector3 _003CcurrentStartScale_003E5__6;

		private float _003CanimationTime_003E5__7;

		private float _003CtotalAnimationDuration_003E5__8;

		private float _003CfadeOutTime_003E5__9;

		private Vector3 _003CcurrentScale_003E5__10;

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
		public _003CAnimationSequence_003Ed__28(int _003C_003E1__state)
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
	private sealed class _003CConquestAnimationSequence_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RebellionFlag _003C_003E4__this;

		public Color previousOwnerColor;

		public Color newOwnerColor;

		private Vector3 _003CstartPosition_003E5__2;

		private float _003Celapsed_003E5__3;

		private Vector3 _003CplantedPosition_003E5__4;

		private Vector3 _003CfadeStartScale_003E5__5;

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
		public _003CConquestAnimationSequence_003Ed__29(int _003C_003E1__state)
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

	private const float c_FadeInDuration = 0.3f;

	private const float c_FadeOutDuration = 0.5f;

	private const float c_FloatAmplitude = 0.15f;

	private const float c_FloatSpeed = 2.5f;

	private const float c_RotationAmplitude = 8f;

	private const float c_RotationSpeed = 2f;

	private const float c_PulseScale = 0.15f;

	private const float c_PulseSpeed = 4f;

	private const float c_ImpactScale = 1.5f;

	private const float c_ImpactDuration = 0.15f;

	private const float c_ShakeAmplitude = 0.05f;

	private const float c_ConquestDropHeight = 1.1f;

	private const float c_ConquestPlantDuration = 0.42f;

	private const float c_ConquestSettleDuration = 0.12f;

	private const float c_ConquestTurnHalfDuration = 0.22f;

	private const float c_ConquestNewOwnerHoldDuration = 0.45f;

	private const float c_ConquestFadeDuration = 0.38f;

	private RebellionAnimationManager m_Manager;

	private SpriteRenderer m_SpriteRenderer;

	private Coroutine m_AnimationCoroutine;

	private Vector3 m_OriginalPosition;

	private Vector3 m_OriginalScale;

	private Color m_OriginalColor;

	private RebellionType m_CurrentType;

	private void Awake()
	{
	}

	public void PlayAnimation(RebellionType type, RebellionAnimationManager manager)
	{
	}

	public void PlayConquestAnimation(Color previousOwnerColor, Color newOwnerColor, RebellionAnimationManager manager)
	{
	}

	private void SetColorByType(RebellionType type)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimationSequence_003Ed__28))]
	private IEnumerator AnimationSequence()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CConquestAnimationSequence_003Ed__29))]
	private IEnumerator ConquestAnimationSequence(Color previousOwnerColor, Color newOwnerColor)
	{
		return null;
	}

	private void OnAnimationComplete()
	{
	}

	public void StopAnimation()
	{
	}

	private void ResetFlag()
	{
	}

	private void OnDisable()
	{
	}
}
