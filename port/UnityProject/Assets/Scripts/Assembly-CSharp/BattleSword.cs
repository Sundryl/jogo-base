using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleSword : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CZoomOut_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BattleSword _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private float _003CcurrentTime_003E5__3;

		private Vector3 _003CstartScale_003E5__4;

		private Vector3 _003CendScale_003E5__5;

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
		public _003CZoomOut_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CUpdatePos_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BattleSword _003C_003E4__this;

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
		public _003CUpdatePos_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CZoomIn_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BattleSword _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private float _003CcurrentTime_003E5__3;

		private Vector3 _003CstartScale_003E5__4;

		private Vector3 _003CendScale_003E5__5;

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
		public _003CZoomIn_003Ed__18(int _003C_003E1__state)
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

	public Province province;

	public bool isEnd;

	private Animator animator;

	private Coroutine updatePosCoroutine;

	private Vector3 startScale;

	private Vector3 endScale;

	private const float c_AnimatorPausedSpeed = 0f;

	private const float c_AnimatorNormalSpeed = 1f;

	private bool m_IsAnimatorReady;

	private bool m_IsManagedByFxSystem;

	private bool m_HasManagedWorldPos;

	private Vector3 m_ManagedWorldPos;

	public void Start()
	{
	}

	private void Update()
	{
	}

	public void CheckStatus()
	{
	}

	private void UpdateAnimatorSpeedByPauseState()
	{
	}

	[IteratorStateMachine(typeof(_003CZoomOut_003Ed__16))]
	private IEnumerator ZoomOut()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUpdatePos_003Ed__17))]
	private IEnumerator UpdatePos()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CZoomIn_003Ed__18))]
	private IEnumerator ZoomIn()
	{
		return null;
	}

	public void ConfigureManagedMode(Vector3 _worldPos)
	{
	}

	public void UpdateManagedPosition(Vector3 _worldPos)
	{
	}

	private bool TryGetUnitsCenterPosition(out Vector3 _position)
	{
		_position = default;
		return false;
	}

	private void PlayDefaultAnimState()
	{
	}
}
