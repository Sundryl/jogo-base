using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Shapes;
using UnityEngine;

public class AttackArrowRenderer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFadeInCoroutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public AttackArrowRenderer _003C_003E4__this;

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
		public _003CFadeInCoroutine_003Ed__27(int _003C_003E1__state)
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

	public Vector3 startPoint;

	public Vector3 controlPoint;

	public Vector3 endPoint;

	public Color startColor;

	public Color endColor;

	private int numPoints;

	public int sourceProvince;

	public int targetProvince;

	public State state;

	public State TargetState;

	private AnimationCurve widthCurve;

	public float outlineWidthOffset;

	public float growthDuration;

	private float growthProgress;

	private bool m_IsFadingIn;

	private Coroutine m_FadeInCoroutine;

	public GameObject polylineGo;

	public GameObject polylineOutlineGo;

	public GameObject ArrowTipMeshGo;

	public GameObject ArrowTipMeshOutlineGo;

	public float offsetBezierStart;

	public float offsetBezierEnd;

	private List<PolylinePoint> calculatedPoints;

	private List<PolylinePoint> calculatedOutlinePoints;

	private void Start()
	{
	}

	public void CheckVisibility()
	{
	}

	public void FadeIn(float duration)
	{
	}

	[IteratorStateMachine(typeof(_003CFadeInCoroutine_003Ed__27))]
	private IEnumerator FadeInCoroutine(float duration)
	{
		return null;
	}

	private void UpdateBezierCurveWithGrowth(float growthProgress)
	{
	}

	private void UpdateArrowTipTransform()
	{
	}

	private float EvaluateWidth(float t)
	{
		return 0f;
	}

	internal void SetEnabled(bool isEnabled, bool isForceFull = true)
	{
	}

	public void SetTransparency(float transparency)
	{
	}
}
