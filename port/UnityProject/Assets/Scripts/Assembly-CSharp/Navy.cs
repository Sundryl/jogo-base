using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Profiling;
using UnityEngine;

public class Navy : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlaySinkAnimation_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Navy _003C_003E4__this;

		private Vector3 _003CstartPos_003E5__2;

		private Vector3 _003CstartScale_003E5__3;

		private Quaternion _003CstartRot_003E5__4;

		private Color _003CstartColor_003E5__5;

		private float _003Celapsed_003E5__6;

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
		public _003CPlaySinkAnimation_003Ed__73(int _003C_003E1__state)
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
	private sealed class _003CMoveCoroutineWrapper_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IEnumerator _routine;

		public Navy _003C_003E4__this;

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
		public _003CMoveCoroutineWrapper_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CRandomMoveInPort_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Navy _003C_003E4__this;

		public int _portProvinceId;

		private int _003Ccell_003E5__2;

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
		public _003CRandomMoveInPort_003Ed__82(int _003C_003E1__state)
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
	private sealed class _003CMoveToCell_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int _targetCell;

		public Navy _003C_003E4__this;

		private float _003Cspeed_003E5__2;

		private List<int>.Enumerator _003C_003E7__wrap2;

		private int _003Ccell_003E5__4;

		private Vector3 _003CtargetPos_003E5__5;

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
		public _003CMoveToCell_003Ed__89(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRandomMoveInHomePort_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Navy _003C_003E4__this;

		private int _003Ccell_003E5__2;

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
		public _003CRandomMoveInHomePort_003Ed__102(int _003C_003E1__state)
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
	private sealed class _003CMoveToCellAndIdleLoiter_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Navy _003C_003E4__this;

		public int _targetCell;

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
		public _003CMoveToCellAndIdleLoiter_003Ed__103(int _003C_003E1__state)
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
	private sealed class _003CIdleLoiterAfterMove_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Navy _003C_003E4__this;

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
		public _003CIdleLoiterAfterMove_003Ed__104(int _003C_003E1__state)
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
	private sealed class _003CRandomMoveInTargetPort_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Navy _003C_003E4__this;

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
		public _003CRandomMoveInTargetPort_003Ed__105(int _003C_003E1__state)
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
	private sealed class _003CRandomMoveInProvince_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int _provinceId;

		public Navy _003C_003E4__this;

		public float _interval;

		private float _003Cspeed_003E5__2;

		private List<int>.Enumerator _003C_003E7__wrap2;

		private int _003Ccell_003E5__4;

		private Vector3 _003CtargetPos_003E5__5;

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
		public _003CRandomMoveInProvince_003Ed__106(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public int navyID;

	public NavyState currentState;

	public int stateID;

	public State state;

	public int homePortProvinceID;

	public int targetPortProvinceID;

	public int targetPortCell;

	public int currentCell;

	public int preCell;

	public float navyCount;

	public static int maxNavyCount;

	public bool isMoving;

	private const float c_BaseSpeed = 2.2f;

	private const float c_DamageInterval = 2f;

	private const float c_BaseDamageToNavy = 40f;

	private const float c_BaseDamageToArmy = 40f;

	private const float c_BaseDamageToMerchant = 120f;

	private const float c_MaritimeAttackMultiplier = 1.5f;

	private const float c_TargetSearchCooldown = 1.2f;

	private const float c_MoveRetryBaseCooldown = 0.8f;

	private const float c_MoveRetryMaxCooldown = 6f;

	private const float c_AIDebugLogInterval = 2.5f;

	private const float c_IdleLoiterMin = 1.8f;

	private const float c_IdleLoiterMax = 3.4f;

	private const float c_SinkAnimDuration = 0.8f;

	private const float c_SinkAnimDropDistance = 0.28f;

	private const float c_SinkAnimEndScaleFactor = 0.28f;

	private const float c_SinkAnimTiltZ = 14f;

	private const float c_InitialNavyCount = 100f;

	private static readonly ProfilerMarker s_UpdateStateProfilerMarker;

	private static readonly ProfilerMarker s_UpdateStateBattleCheckProfilerMarker;

	private static readonly ProfilerMarker s_UpdateAttackingProfilerMarker;

	private static readonly ProfilerMarker s_UpdateIdleProfilerMarker;

	private static readonly ProfilerMarker s_BattleInSeaProvinceProfilerMarker;

	private static readonly ProfilerMarker s_MoveToCellFindPathProfilerMarker;

	private float m_BattleTimer;

	private float m_DamageIntervalRnd;

	private float m_NextTargetSearchTime;

	private float m_NextMoveRetryTime;

	private float m_NextAIDebugLogTime;

	private float m_LastUpdateTime;

	private int m_FailedMoveAttempts;

	private bool m_IsBattleMoving;

	private bool m_IsSinking;

	private bool m_IsSinkAnimationFinished;

	private Coroutine m_MoveCoroutine;

	private SvgIconRenderer m_SvgRenderer;

	private int m_IdleAssignedPortProvinceId;

	private int m_ForwardBasePortProvinceId;

	private float m_NextIdleRedeployTime;

	private bool m_LastIdleWasAtWar;

	private bool m_LastUpdateWasAtWar;

	public bool IsSinking => false;

	public bool IsSinkAnimationFinished => false;

	private Vector3 GetIconWorldPos(int _cell)
	{
		return default;
	}

	private static int ResolveProvinceIdFromCell(int _cell)
	{
		return 0;
	}

	public void SetCurrentCell(int _cell)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void PrepareForReuse()
	{
	}

	public void CleanupForRemoval()
	{
	}

	private void RestoreVisualAndColliderState()
	{
	}

	public void Init(State _state, int _homePortProvinceId, int _navyID)
	{
	}

	public string GetDisplayName()
	{
		return null;
	}

	public void PostLoadSaveData()
	{
	}

	public void UpdateState(float _deltaTime)
	{
	}

	private void HandleWarToPeaceTransition()
	{
	}

	private bool HasPendingAttackTarget()
	{
		return false;
	}

	public bool ShouldDestroy()
	{
		return false;
	}

	public void StartSinkAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CPlaySinkAnimation_003Ed__73))]
	private IEnumerator PlaySinkAnimation()
	{
		return null;
	}

	public float GetStrengthFactor()
	{
		return 0f;
	}

	public void UpdateColor()
	{
	}

	public void UpdateVisibility()
	{
	}

	public void UpdateVisibility(bool _isDisplayArmy)
	{
	}

	private void StartMoveCoroutine(IEnumerator _routine, bool _isBattleMoving)
	{
	}

	[IteratorStateMachine(typeof(_003CMoveCoroutineWrapper_003Ed__79))]
	private IEnumerator MoveCoroutineWrapper(IEnumerator _routine)
	{
		return null;
	}

	private void UpdateIdle()
	{
	}

	public void ResetIdlePortAssignment()
	{
	}

	[IteratorStateMachine(typeof(_003CRandomMoveInPort_003Ed__82))]
	private IEnumerator RandomMoveInPort(int _portProvinceId)
	{
		return null;
	}

	private void UpdateAttacking()
	{
	}

	private void BattleInSeaProvince(Province _seaProvince, float _deltaTime, HashSet<State> _enemyStateSet)
	{
	}

	private static bool TryGetSeaBattleFxPosition(Province _seaProvince, out Vector3 _position)
	{
		_position = default;
		return false;
	}

	private bool HasEnemyUnitsInSeaProvince(Province _seaProvince)
	{
		return false;
	}

	private bool HasEnemyUnitsInSeaProvince(Province _seaProvince, HashSet<State> _enemyStateSet)
	{
		return false;
	}

	private void StopMoveCoroutine()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveToCell_003Ed__89))]
	private IEnumerator MoveToCell(int _targetCell)
	{
		return null;
	}

	private void LogAIDebug(string _message)
	{
	}

	public void AppendDebugInfo(StringBuilder _sb)
	{
	}

	public int GetFailedMoveAttempts()
	{
		return 0;
	}

	public float GetNextMoveRetryTime()
	{
		return 0f;
	}

	public float GetNextTargetSearchTime()
	{
		return 0f;
	}

	public bool IsBattleMoving()
	{
		return false;
	}

	public int GetIdleAssignedPortProvinceId()
	{
		return 0;
	}

	public int GetForwardBasePortProvinceId()
	{
		return 0;
	}

	public bool TryGetCurrentSeaProvinceId(out int _provinceId)
	{
		_provinceId = default;
		return false;
	}

	public bool IsEngagingEnemyInCurrentSeaProvince()
	{
		return false;
	}

	private static int GetFeatureIdSafe(int _cell)
	{
		return 0;
	}

	private static int GetProvinceIdSafe(int _cell)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CRandomMoveInHomePort_003Ed__102))]
	private IEnumerator RandomMoveInHomePort()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveToCellAndIdleLoiter_003Ed__103))]
	private IEnumerator MoveToCellAndIdleLoiter(int _targetCell)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CIdleLoiterAfterMove_003Ed__104))]
	private IEnumerator IdleLoiterAfterMove()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRandomMoveInTargetPort_003Ed__105))]
	private IEnumerator RandomMoveInTargetPort()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRandomMoveInProvince_003Ed__106))]
	private IEnumerator RandomMoveInProvince(int _provinceId, float _interval)
	{
		return null;
	}

	private void TryStartWarPatrolMove()
	{
	}

	private bool TryGetHomePortFallbackCell(out int _cell, out bool _isSameFeatureCell)
	{
		_cell = default;
		_isSameFeatureCell = default;
		return false;
	}

	private bool TryResetToHomePort()
	{
		return false;
	}

	public string Serialize()
	{
		return null;
	}

	public static Navy Deserialize(string _json)
	{
		return null;
	}
}
