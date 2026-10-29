using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ByteDance.Live.Foundation.Logging;
using ByteDance.LiveOpenSdk;
using ByteDance.LiveOpenSdk.DyCloud;
using ByteDance.LiveOpenSdk.Report;
using UnityEngine;

public class DouyinFantasyMapStartup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForDyCloudManager_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DouyinFantasyMapStartup _003C_003E4__this;

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
		public _003CWaitForDyCloudManager_003Ed__31(int _003C_003E1__state)
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

	private static DouyinFantasyMapStartup instance;

	private ILiveOpenSdk sdk;

	private IDyCloudApi cloudApi;

	private IMessageAckService ackService;

	[SerializeField]
	private string appId;

	private string roomId;

	private string anchorOpenId;

	[SerializeField]
	private bool isDebug;

	[CompilerGenerated]
	private static Action<bool> m_OnSDKInitialized;

	public static DouyinFantasyMapStartup Instance => null;

	public string AccessToken => null;

	public string AppID => null;

	public string RoomId { get; set; }

	public string AnchorOpenId { get; set; }

	public static bool Initialized { get; private set; }

	public ILiveOpenSdk SDK => null;

	public IDyCloudApi CloudApi => null;

	public IMessageAckService AckService => null;

	public static event Action<bool> OnSDKInitialized
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void InitSDK()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForDyCloudManager_003Ed__31))]
	private IEnumerator WaitForDyCloudManager()
	{
		return null;
	}

	private void ParseLaunchArgs()
	{
	}

	private void ValidateInitialization()
	{
	}

	private void OnSDKLog(LogItem logItem)
	{
	}

	private void OnDestroy()
	{
	}
}
