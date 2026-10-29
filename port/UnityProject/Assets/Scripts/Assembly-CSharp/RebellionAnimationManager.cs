using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RebellionAnimationManager
{
	[CompilerGenerated]
	private sealed class _003CPlayConquestFlagsCoroutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<ConquestFlagAnimationData> conquestFlags;

		public RebellionAnimationManager _003C_003E4__this;

		private int _003Ccount_003E5__2;

		private List<ConquestFlagAnimationData>.Enumerator _003C_003E7__wrap2;

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
		public _003CPlayConquestFlagsCoroutine_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003CPlayMultipleFlagsCoroutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<Province> provinces;

		public RebellionAnimationManager _003C_003E4__this;

		public RebellionType type;

		private int _003Ccount_003E5__2;

		private List<Province>.Enumerator _003C_003E7__wrap2;

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
		public _003CPlayMultipleFlagsCoroutine_003Ed__22(int _003C_003E1__state)
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

	private static RebellionAnimationManager s_Instance;

	private GameObject m_RebelFlagPrefab;

	private readonly Queue<GameObject> m_FlagPool;

	private readonly List<GameObject> m_ActiveFlags;

	private const int c_InitialPoolSize = 20;

	private const int c_MaxActiveFlags = 30;

	private const string c_ConquestFlagIconResourcePath = "Sprites/conquest-flag-icon";

	private Sprite m_ConquestFlagSprite;

	private Sprite m_DefaultFlagSprite;

	public static RebellionAnimationManager Instance => null;

	private void Initialize()
	{
	}

	private GameObject CreateFlag()
	{
		return null;
	}

	private GameObject GetFromPool()
	{
		return null;
	}

	public void ReturnToPool(GameObject flag)
	{
	}

	private Sprite GetConquestFlagSprite()
	{
		return null;
	}

	public void PlayProvinceRebellion(Province province)
	{
	}

	public void PlayFamilyRebellion(List<Province> provinces)
	{
	}

	public void PlayCivilWar(List<Province> provinces)
	{
	}

	public void PlayConquest(List<ConquestFlagAnimationData> conquestFlags)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayConquestFlagsCoroutine_003Ed__21))]
	private IEnumerator PlayConquestFlagsCoroutine(List<ConquestFlagAnimationData> conquestFlags)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayMultipleFlagsCoroutine_003Ed__22))]
	private IEnumerator PlayMultipleFlagsCoroutine(List<Province> provinces, RebellionType type)
	{
		return null;
	}

	public void ClearAllFlags()
	{
	}

	public void Cleanup()
	{
	}
}
