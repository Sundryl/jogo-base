using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WarClaimAnimationManager
{
	[CompilerGenerated]
	private sealed class _003CPlayClaimsCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<WarClaimAnimationData> claims;

		public WarClaimAnimationManager _003C_003E4__this;

		private int _003Ccount_003E5__2;

		private List<WarClaimAnimationData>.Enumerator _003C_003E7__wrap2;

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
		public _003CPlayClaimsCoroutine_003Ed__23(int _003C_003E1__state)
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

	private static WarClaimAnimationManager s_Instance;

	private const string c_IconResourcePath = "Sprites/war-claim-target-icon";

	private static readonly Vector2 s_TargetCenterPivot;

	private const int c_InitialPoolSize = 12;

	private const int c_MaxActiveMarkers = 30;

	private const float c_MarkerZ = -0.9f;

	private const float c_BaseScale = 0.9f;

	private Sprite m_MarkerSprite;

	private readonly Queue<GameObject> m_MarkerPool;

	private readonly List<GameObject> m_ActiveMarkers;

	private readonly List<GameObject> m_StaticMarkers;

	private const int c_MaxStaticMarkers = 200;

	public static WarClaimAnimationManager Instance => null;

	private void Initialize()
	{
	}

	private GameObject CreateMarker()
	{
		return null;
	}

	private GameObject TakeFromPool(bool warnOnGrow)
	{
		return null;
	}

	private GameObject GetFromPool()
	{
		return null;
	}

	public void ReturnToPool(GameObject marker)
	{
	}

	public void ShowStaticClaims(List<WarClaimAnimationData> claims)
	{
	}

	public void ClearStaticClaims()
	{
	}

	public void PlayClaims(List<WarClaimAnimationData> claims)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClaimsCoroutine_003Ed__23))]
	private IEnumerator PlayClaimsCoroutine(List<WarClaimAnimationData> claims)
	{
		return null;
	}

	private static bool TryGetProvinceMarkerPosition(Province _province, out Vector3 _position)
	{
		_position = default;
		return false;
	}

	public void ClearAllMarkers()
	{
	}

	public void Cleanup()
	{
	}
}
