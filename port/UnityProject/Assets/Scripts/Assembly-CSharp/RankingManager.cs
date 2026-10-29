using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class RankingManager : MonoBehaviour
{
	public delegate void RankingEventHandler(bool success, string message);

	private class UserGameStats
	{
		public int WinningPoints { get; set; }

		public int WinningStreakCount { get; set; }
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSetWorldRankVersion_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RankingManager _003C_003E4__this;

		public string version;

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
	private struct _003CUpdateWorldRank_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RankingManager _003C_003E4__this;

		public List<WorldRankPlayerData> playerData;

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
	private struct _003CStartWorldRankUpdateLoop_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RankingManager _003C_003E4__this;

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
	private struct _003CStartNewGame_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RankingManager _003C_003E4__this;

		public string roomId;

		public string anchorOpenId;

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
	private struct _003CEndCurrentGame_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RankingManager _003C_003E4__this;

		public string roomId;

		public string anchorOpenId;

		public List<GroupResult> groupResults;

		public List<RoundPlayerData> playerData;

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
	private struct _003CUpdateRankings_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public State[] winners;

		public RankingManager _003C_003E4__this;

		private List<RoundPlayerData> _003CroundPlayerData_003E5__2;

		private int _003Ci_003E5__3;

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
	private struct _003CUpdateMonthlyWorldRank_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RankingManager _003C_003E4__this;

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

	private static RankingManager instance;

	private DouyinAPIClient apiClient;

	private string currentWorldRankVersion;

	[SerializeField]
	private bool isOnlineVersion;

	[SerializeField]
	private float worldRankUpdateInterval;

	private long? currentRoundId;

	private bool isInitialized;

	[CompilerGenerated]
	private Action<bool> m_OnInitialized;

	[CompilerGenerated]
	private RankingEventHandler m_OnWorldRankUpdated;

	[CompilerGenerated]
	private RankingEventHandler m_OnRoundDataUploaded;

	private Dictionary<string, UserGameStats> userStats;

	public static RankingManager Instance => null;

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

	public event RankingEventHandler OnWorldRankUpdated
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

	public event RankingEventHandler OnRoundDataUploaded
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

	public void Initialize(string appId, string accessToken)
	{
	}

	[AsyncStateMachine(typeof(_003CSetWorldRankVersion_003Ed__23))]
	public Task SetWorldRankVersion(string version)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUpdateWorldRank_003Ed__24))]
	public Task UpdateWorldRank(List<WorldRankPlayerData> playerData)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CStartWorldRankUpdateLoop_003Ed__25))]
	private void StartWorldRankUpdateLoop()
	{
	}

	[AsyncStateMachine(typeof(_003CStartNewGame_003Ed__26))]
	public Task StartNewGame(string roomId, string anchorOpenId)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CEndCurrentGame_003Ed__27))]
	public Task EndCurrentGame(string roomId, string anchorOpenId, List<RoundPlayerData> playerData, List<GroupResult> groupResults)
	{
		return null;
	}

	private void CheckInitialization()
	{
	}

	private bool TryGetCurrentWorldRankData(out List<WorldRankPlayerData> playerData)
	{
		playerData = null;
		return false;
	}

	private UserGameStats GetUserStats(string openId)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUpdateRankings_003Ed__31))]
	public Task UpdateRankings(State[] winners)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUpdateMonthlyWorldRank_003Ed__32))]
	private Task UpdateMonthlyWorldRank()
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
