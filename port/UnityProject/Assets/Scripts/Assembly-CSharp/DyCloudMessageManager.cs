using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ByteDance.LiveOpenSdk.DyCloud;
using ByteDance.LiveOpenSdk.Report;
using ByteDance.LiveOpenSdk.Room;
using UnityEngine;

public class DyCloudMessageManager : MonoBehaviour
{
	public delegate void MessageHandler(DyCloudSocketMessage message);

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DyCloudMessageManager _003C_003E4__this;

		private DateTime _003CwaitStart_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<IRoomInfo> _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CStartGame_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public DyCloudMessageManager _003C_003E4__this;

		private IDyCloudHttpResponse _003Cresponse_003E5__2;

		private TaskAwaiter<IDyCloudHttpResponse> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CFinishGame_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public DyCloudMessageManager _003C_003E4__this;

		public List<UserRoundData> userResults;

		public long roundID;

		public List<GroupResult> groupResults;

		private TaskAwaiter<IDyCloudHttpResponse> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003CInitializeCoroutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DyCloudMessageManager _003C_003E4__this;

		private bool _003CinitSuccess_003E5__2;

		private Task _003CinitTask_003E5__3;

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
		public _003CInitializeCoroutine_003Ed__34(int _003C_003E1__state)
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CConnectWebSocket_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DyCloudMessageManager _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CTryReconnectOnce_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public float delay;

		public DyCloudMessageManager _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003CReconnectCoroutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DyCloudMessageManager _003C_003E4__this;

		private int _003CretryCount_003E5__2;

		private Task<bool> _003CreconnectTask_003E5__3;

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
		public _003CReconnectCoroutine_003Ed__39(int _003C_003E1__state)
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetUserInfo_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<UserInfoResponse> _003C_003Et__builder;

		public DyCloudMessageManager _003C_003E4__this;

		public string openId;

		private TaskAwaiter<IDyCloudHttpResponse> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetRoundRank_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<RoundRankResponse> _003C_003Et__builder;

		public DyCloudMessageManager _003C_003E4__this;

		public string roundId;

		public string roomId;

		private TaskAwaiter<IDyCloudHttpResponse> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public DouyinHelper douyinHelper;

	private static DyCloudMessageManager instance;

	[CompilerGenerated]
	private Action<bool> m_OnInitialized;

	private Dictionary<string, List<MessageHandler>> messageHandlers;

	private IDyCloudApi cloudApi;

	private IDyCloudWebSocket webSocket;

	private IMessageAckService ackService;

	[Tooltip("抖音云环境ID")]
	[SerializeField]
	private string envId;

	[Tooltip("服务ID")]
	[SerializeField]
	private string serviceId;

	[SerializeField]
	[Tooltip("是否为调试模式")]
	private bool isDebug;

	[Tooltip("调试模式下的IP地址")]
	[SerializeField]
	private string debugIpAddress;

	public List<UserRoundData> userResults;

	public Dictionary<string, UserData> userData;

	private bool isInitialized;

	private bool isConnected;

	public long CurRoundID;

	public long CurStartTime;

	public DateTime m_GameStartTime;

	public int GameDurationMinutes;

	public static DyCloudMessageManager Instance => null;

	public bool IsInitialized => false;

	public event Action<bool> OnInitialized
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

	private void FixedUpdate()
	{
	}

	public void OnEndGameButtonClicked()
	{
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__29))]
	public Task Initialize()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CStartGame_003Ed__30))]
	public Task<bool> StartGame()
	{
		return null;
	}

	public long GetCurrentRoundStartTime()
	{
		return 0L;
	}

	[AsyncStateMachine(typeof(_003CFinishGame_003Ed__32))]
	public Task<bool> FinishGame(long roundID, long startTime, List<UserRoundData> userResults, List<GroupResult> groupResults)
	{
		return null;
	}

	public void StartInitialize()
	{
	}

	[IteratorStateMachine(typeof(_003CInitializeCoroutine_003Ed__34))]
	private IEnumerator InitializeCoroutine()
	{
		return null;
	}

	private void SetupWebSocketHandlers()
	{
	}

	[AsyncStateMachine(typeof(_003CConnectWebSocket_003Ed__36))]
	private Task ConnectWebSocket()
	{
		return null;
	}

	private void OnWebSocketMessage(string data)
	{
	}

	[AsyncStateMachine(typeof(_003CTryReconnectOnce_003Ed__38))]
	private Task<bool> TryReconnectOnce(float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CReconnectCoroutine_003Ed__39))]
	private IEnumerator ReconnectCoroutine()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetUserInfo_003Ed__40))]
	public Task<UserInfoResponse> GetUserInfo(string openId)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetRoundRank_003Ed__41))]
	public Task<RoundRankResponse> GetRoundRank(string roundId, string roomId)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public void RegisterMessageHandler(string msgType, MessageHandler handler)
	{
	}

	private void InitializeMessageHandlers()
	{
	}

	private void HandleFans(DyCloudSocketMessage message)
	{
	}

	private void HandleLike(DyCloudSocketMessage message)
	{
	}

	private void HandleComment(DyCloudSocketMessage message)
	{
	}

	private void HandleGift(DyCloudSocketMessage message)
	{
	}

	public void ProcessGiftEffect(GiftData giftData)
	{
	}

	private void ProcessGameCommand(string command, string secOpenId, string nickname)
	{
	}
}
