using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WarClaimMarker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStrikeSequence_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WarClaimMarker _003C_003E4__this;

		public Color claimantColor;

		private Vector3 _003CstartPosition_003E5__2;

		private float _003Celapsed_003E5__3;

		private Vector3 _003CfadeStartScale_003E5__4;

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
		public _003CStrikeSequence_003Ed__18(int _003C_003E1__state)
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

	private const float c_EntryAngleDeg = 60f;

	private const float c_EntryDistance = 3.2f;

	private const float c_EntryDuration = 0.22f;

	private const float c_ImpactDuration = 0.18f;

	private const float c_ImpactSquashScale = 0.88f;

	private const float c_ShakeAmplitude = 0.06f;

	private const float c_HoldDuration = 3f;

	private const float c_PulseScale = 0.05f;

	private const float c_PulseSpeed = 4f;

	private const float c_FadeOutDuration = 0.6f;

	private const float c_MarkerZ = -0.9f;

	private WarClaimAnimationManager m_Manager;

	private SpriteRenderer m_SpriteRenderer;

	private Coroutine m_AnimationCoroutine;

	private Vector3 m_OriginalPosition;

	private Vector3 m_OriginalScale;

	private void Awake()
	{
	}

	public void PlayStrikeAnimation(Color claimantColor, WarClaimAnimationManager manager)
	{
	}

	[IteratorStateMachine(typeof(_003CStrikeSequence_003Ed__18))]
	private IEnumerator StrikeSequence(Color claimantColor)
	{
		return null;
	}

	private void SetAlpha(Color baseColor, float alpha)
	{
	}

	private void SetPositionAtMarkerZ(Vector3 position)
	{
	}

	private void OnAnimationComplete()
	{
	}

	public void StopAnimation()
	{
	}

	private void OnDisable()
	{
	}
}
