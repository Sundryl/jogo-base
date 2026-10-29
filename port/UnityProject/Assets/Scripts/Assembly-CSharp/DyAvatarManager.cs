using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DyAvatarManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadAvatarWithTimeout_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DyAvatarManager _003C_003E4__this;

		public string userId;

		public Image image;

		public Action<bool> onComplete;

		private float _003Celapsed_003E5__2;

		private float _003CtimeoutDuration_003E5__3;

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
		public _003CLoadAvatarWithTimeout_003Ed__7(int _003C_003E1__state)
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
	private sealed class _003CFetchUserAvatar_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string userId;

		public DyAvatarManager _003C_003E4__this;

		private UnityWebRequest _003CwebRequest_003E5__2;

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
		public _003CFetchUserAvatar_003Ed__8(int _003C_003E1__state)
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

	private string accessToken;

	private Dictionary<string, Texture2D> avatarCache;

	private Dictionary<string, bool> loadingStatus;

	public static DyAvatarManager _instance;

	public static DyAvatarManager Instance => null;

	public void LoadUserAvatar(Image image, string userId, Action<bool> onComplete)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAvatarWithTimeout_003Ed__7))]
	private IEnumerator LoadAvatarWithTimeout(Image image, string userId, Action<bool> onComplete)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFetchUserAvatar_003Ed__8))]
	private IEnumerator FetchUserAvatar(string userId)
	{
		return null;
	}
}
