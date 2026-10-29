using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WarManager
{
	[CompilerGenerated]
	private sealed class _003CPeaceAnimation_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform transform;

		private float _003CmoveDuration_003E5__2;

		private float _003CstayDuration_003E5__3;

		private float _003CfadeDuration_003E5__4;

		private Vector3 _003CstartPosition_003E5__5;

		private Vector3 _003CendPosition_003E5__6;

		private SpriteRenderer _003CspriteRenderer_003E5__7;

		private float _003CelapsedTime_003E5__8;

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
		public _003CPeaceAnimation_003Ed__25(int _003C_003E1__state)
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

	private static WarManager _instance;

	private List<War> wars;

	private List<int> activeWarIds;

	public static WarManager Instance => null;

	public War GetWar(int id)
	{
		return null;
	}

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	public static ParsedWarData ParseJsonOnly(string json)
	{
		return null;
	}

	public void ApplyParsedData(ParsedWarData data)
	{
	}

	public void Update()
	{
	}

	public void CheckMaximumDurationWars()
	{
	}

	public List<War> GetActiveWars()
	{
		return null;
	}

	public HashSet<State> GetEnemyStates(State state)
	{
		return null;
	}

	public List<State> GetRegularEnemyStates(State state)
	{
		return null;
	}

	public List<State> GetRebelStates(State state)
	{
		return null;
	}

	public void Start()
	{
	}

	public void Clear()
	{
	}

	public War StartWar(State aggressor, State defender, WarType warType)
	{
		return null;
	}

	public void EndWar(War war, bool isPeaceEnd = false, bool isForceEnd = false)
	{
	}

	public void LeaveWar(War war, State state)
	{
	}

	public void EndAllWars(bool isForceEnd = true)
	{
	}

	private void PlayEndWarAnimation(War war)
	{
	}

	public void PlayPeaceAnimationFor(IEnumerable<State> states)
	{
	}

	[IteratorStateMachine(typeof(_003CPeaceAnimation_003Ed__25))]
	private IEnumerator PeaceAnimation(Transform transform)
	{
		return null;
	}

	internal bool IsAtWar(State state)
	{
		return false;
	}

	internal bool IsAtWarWith(State state1, State state2)
	{
		return false;
	}

	public List<War> GetWars(State state)
	{
		return null;
	}

	public List<War> GetWarsCanbeEnd(State state)
	{
		return null;
	}

	internal War GetWarBetweenStates(State state1, State state2)
	{
		return null;
	}

	public void PostLoadSaveData()
	{
	}
}
