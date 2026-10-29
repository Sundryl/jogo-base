using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TributeAnimationManager
{
	[CompilerGenerated]
	private sealed class _003CPlayTributeSequence_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<Province> provinces;

		public State vassalState;

		public TributeAnimationManager _003C_003E4__this;

		public Vector3 targetPosition;

		private List<Province> _003CselectedProvinces_003E5__2;

		private int _003CcoinCount_003E5__3;

		private List<GameObject> _003Ccoins_003E5__4;

		private Vector3 _003CstartPoint_003E5__5;

		private int _003Ci_003E5__6;

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
		public _003CPlayTributeSequence_003Ed__17(int _003C_003E1__state)
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

	private static TributeAnimationManager s_Instance;

	private GameObject m_CoinPrefab;

	private readonly Queue<GameObject> m_CoinPool;

	private readonly List<GameObject> m_ActiveCoins;

	private const int c_InitialPoolSize = 30;

	private const int c_MaxActiveCoins = 50;

	private const float c_CoinSpawnInterval = 0.08f;

	public static TributeAnimationManager Instance => null;

	private void Initialize()
	{
	}

	private GameObject CreateCoin()
	{
		return null;
	}

	private GameObject GetFromPool()
	{
		return null;
	}

	public void ReturnToPool(GameObject coin)
	{
	}

	public void PlayTributeAnimation(State vassalState, State overlordState)
	{
	}

	public void PlayProvinceTributeAnimation(Province province, State overlordState)
	{
	}

	private Vector3 GetStateLabelPosition(State state)
	{
		return default;
	}

	[IteratorStateMachine(typeof(_003CPlayTributeSequence_003Ed__17))]
	private IEnumerator PlayTributeSequence(List<Province> provinces, Vector3 targetPosition, State vassalState, State overlordState)
	{
		return null;
	}

	public void ClearAllCoins()
	{
	}

	public void Cleanup()
	{
	}
}
