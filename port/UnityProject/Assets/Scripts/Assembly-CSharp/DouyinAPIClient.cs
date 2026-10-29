using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Networking;

public class DouyinAPIClient
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSendRequest_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string endpoint;

		public object data;

		public DouyinAPIClient _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

		private TaskAwaiter<UnityWebRequest> _003C_003Eu__1;

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
	private struct _003CSetWorldRankVersion_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string version;

		public bool isOnlineVersion;

		public DouyinAPIClient _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

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
	private struct _003CUploadWorldRankList_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string version;

		public bool isOnlineVersion;

		public DouyinAPIClient _003C_003E4__this;

		public List<WorldRankPlayerData> rankList;

		private TaskAwaiter<string> _003C_003Eu__1;

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
	private struct _003CUploadWorldRankUserResults_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<WorldRankPlayerData> userList;

		public string version;

		public bool isOnlineVersion;

		public DouyinAPIClient _003C_003E4__this;

		private IEnumerator<IEnumerable<WorldRankPlayerData>> _003C_003E7__wrap1;

		private TaskAwaiter<string> _003C_003Eu__1;

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
	private struct _003CCompleteWorldRankUpload_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string version;

		public bool isOnlineVersion;

		public DouyinAPIClient _003C_003E4__this;

		public long? completeTime;

		private TaskAwaiter<string> _003C_003Eu__1;

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
	private struct _003CSyncGameStatus_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public long roundId;

		public string roomId;

		public DouyinAPIClient _003C_003E4__this;

		public string anchorOpenId;

		public bool isStart;

		public List<GroupResult> groupResults;

		private TaskAwaiter<string> _003C_003Eu__1;

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
	private struct _003CUploadRoundRankList_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DouyinAPIClient _003C_003E4__this;

		public long roundId;

		public string anchorOpenId;

		public string roomId;

		public List<RoundPlayerData> rankList;

		private TaskAwaiter<string> _003C_003Eu__1;

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
	private struct _003CUploadRoundUserResults_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<RoundPlayerData> userList;

		public string anchorOpenId;

		public string roomId;

		public DouyinAPIClient _003C_003E4__this;

		public long roundId;

		private IEnumerator<IEnumerable<RoundPlayerData>> _003C_003E7__wrap1;

		private TaskAwaiter<string> _003C_003Eu__1;

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
	private struct _003CCompleteRoundUpload_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public long? completeTime;

		public DouyinAPIClient _003C_003E4__this;

		public long roundId;

		public string anchorOpenId;

		public string roomId;

		private TaskAwaiter<string> _003C_003Eu__1;

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

	private const string BASE_URL = "https://webcast.bytedance.com/api/gaming_con";

	private readonly string appId;

	private readonly string accessToken;

	private DyAvatarManager avatarMgr;

	public DouyinAPIClient(string appId, string accessToken)
	{
	}

	[AsyncStateMachine(typeof(_003CSendRequest_003Ed__5))]
	private Task<string> SendRequest(string endpoint, object data)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CSetWorldRankVersion_003Ed__6))]
	public Task SetWorldRankVersion(string version, bool isOnlineVersion = false)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUploadWorldRankList_003Ed__7))]
	public Task UploadWorldRankList(string version, List<WorldRankPlayerData> rankList, bool isOnlineVersion = false)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUploadWorldRankUserResults_003Ed__8))]
	public Task UploadWorldRankUserResults(string version, List<WorldRankPlayerData> userList, bool isOnlineVersion = false)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCompleteWorldRankUpload_003Ed__9))]
	public Task CompleteWorldRankUpload(string version, bool isOnlineVersion = false, long? completeTime = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CSyncGameStatus_003Ed__10))]
	public Task SyncGameStatus(long roundId, string roomId, string anchorOpenId, bool isStart, List<GroupResult> groupResults = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUploadRoundRankList_003Ed__11))]
	public Task UploadRoundRankList(long roundId, string roomId, string anchorOpenId, List<RoundPlayerData> rankList)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUploadRoundUserResults_003Ed__12))]
	public Task UploadRoundUserResults(long roundId, string roomId, string anchorOpenId, List<RoundPlayerData> userList)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCompleteRoundUpload_003Ed__13))]
	public Task CompleteRoundUpload(long roundId, string roomId, string anchorOpenId, long? completeTime = null)
	{
		return null;
	}
}
