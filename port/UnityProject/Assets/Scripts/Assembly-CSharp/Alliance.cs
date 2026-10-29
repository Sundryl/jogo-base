using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;
using csDelaunay;

public class Alliance
{
	[CompilerGenerated]
	private sealed class _003CAllianceAnimation_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CAllianceAnimation_003Ed__46(int _003C_003E1__state)
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

	public double timeStampJoinNewMember;

	public double timeStampStart;

	public List<State> states;

	public List<int> stateIds;

	public int state1;

	public int state2;

	public int i;

	public string name;

	public Dictionary<string, string> translatedNames;

	public bool isUnbreakable;

	[JsonIgnore]
	public bool isNeedLabelUpdate;

	[JsonIgnore]
	public bool isNeedBorderLineUpdate;

	[JsonIgnore]
	public Vector2f polePos;

	[JsonIgnore]
	public int poleCellIndex;

	[JsonIgnore]
	public GameObject allianceLabelObject;

	public bool isDisbanded;

	[JsonProperty]
	public Color color { get; set; }

	private Alliance()
	{
	}

	public Alliance(State state1, State state2)
	{
	}

	public string SerializeAlliance()
	{
		return null;
	}

	public static Alliance DeserializeAlliance(string json)
	{
		return null;
	}

	private static double ParseDoubleFlexible(Dictionary<string, object> _data, string _key)
	{
		return 0.0;
	}

	public bool IsAcceptable(State state)
	{
		return false;
	}

	public bool IsAtWar()
	{
		return false;
	}

	public bool IsNeighbor(State state)
	{
		return false;
	}

	internal void Join(State state)
	{
	}

	internal void Leave(State state, bool isForced = false)
	{
	}

	public string GetName()
	{
		return null;
	}

	public string GetTranslatedName()
	{
		return null;
	}

	private State GetStateById(int _stateId)
	{
		return null;
	}

	public void SetNewName(string _newName)
	{
	}

	public void SetTranslatedNames(Dictionary<string, string> _translations)
	{
	}

	public void ResetNameBasedOnTranslatedName(string _language)
	{
	}

	private void InitializeDefaultName()
	{
	}

	private void EnsureDefaultNameCached()
	{
	}

	private string GetCachedName(string _language)
	{
		return null;
	}

	private string GenerateDefaultName()
	{
		return null;
	}

	private void CacheTranslation(string _language, string _text)
	{
	}

	private void RefreshAllianceLabels()
	{
	}

	private string GetLocalizedStateName(State _state)
	{
		return null;
	}

	internal int GetAge()
	{
		return 0;
	}

	internal void DestroyedBy(State state, bool isForced = false)
	{
	}

	internal void PlayAllianceAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CAllianceAnimation_003Ed__46))]
	private IEnumerator AllianceAnimation(Transform transform)
	{
		return null;
	}

	internal bool IsValid()
	{
		return false;
	}

	internal void Disband()
	{
	}

	internal void RemoveDeadMembers()
	{
	}

	private void MarkAsDisbanded()
	{
	}

	public void AssignInitialColorFromStrongestState()
	{
	}

	public void UpdateColor(Color newColor)
	{
	}

	private void UpdateAllStatesInAllianceView()
	{
	}

	private void UpdateStateInAllianceView(State state)
	{
	}

	public void SetAllianceLabelTriggerCheck(bool isActive)
	{
	}

	public void ClearAllianceLabel()
	{
	}

	internal void MarkVisualDirty()
	{
	}
}
