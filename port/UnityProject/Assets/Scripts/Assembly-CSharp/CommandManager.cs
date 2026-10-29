using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class CommandManager
{
	[CompilerGenerated]
	private sealed class _003CPlayArmySpawnAnimation_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Army army;

		private float _003Cduration_003E5__2;

		private float _003CstartScale_003E5__3;

		private float _003CtargetScale_003E5__4;

		private float _003Celapsed_003E5__5;

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
		public _003CPlayArmySpawnAnimation_003Ed__12(int _003C_003E1__state)
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

	private static CommandManager s_Instance;

	private static string[] allTraits;

	public static CommandManager Instance => null;

	public void StartWar(int aggressorId, int defenderId)
	{
	}

	public void EndWar(int state1Id, int state2Id)
	{
	}

	public void CreateAlliance(int sourceStateID, int targetStateID)
	{
	}

	public void ForceRebellion(int stateId)
	{
	}

	public void PlaceArmies(int stateId, int count, bool isElite = false)
	{
	}

	public void AddTrait(int stateId, string traitName)
	{
	}

	public void RemoveTrait(int stateId, string traitName)
	{
	}

	private bool IsValidStateId(int stateId)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CPlayArmySpawnAnimation_003Ed__12))]
	private IEnumerator PlayArmySpawnAnimation(Army army)
	{
		return null;
	}

	public void NoCurruption(int stateId)
	{
	}

	public void EnableAllTraits(int stateId)
	{
	}

	internal bool ExitAlliance(int stateId)
	{
		return false;
	}

	public void TryJoinAlliance(int stateId, int targetStateId)
	{
	}

	public void TryDeclareWarToAll(int stateId)
	{
	}

	internal void LeaveAlliance(int i)
	{
	}

	internal void DestroyArmy(int stateId, float percent)
	{
	}

	internal void EndAllWar(int stateId)
	{
	}

	public void SetPoliticalSystem(int stateId, PoliticalSystem politicalSystem)
	{
	}

	public void SetEthnicAttribute(int stateId, EthnicAttribute ethnicAttribute)
	{
	}

	internal string ReducedCorruption(int stateId)
	{
		return null;
	}

	internal void EnableRandom2Traits(int stateId, out string trait1, out string trait2)
	{
		trait1 = null;
		trait2 = null;
	}

	internal void EnableRandom3Traits(int stateId, out string trait1, out string trait2, out string trait3)
	{
		trait1 = null;
		trait2 = null;
		trait3 = null;
	}
}
