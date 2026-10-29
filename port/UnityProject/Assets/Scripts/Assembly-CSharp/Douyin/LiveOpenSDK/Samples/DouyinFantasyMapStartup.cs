using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ByteDance.Live.Foundation.Logging;
using UnityEngine;
using UnityEngine.UI;

namespace Douyin.LiveOpenSDK.Samples
{
	public class DouyinFantasyMapStartup : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartDirectPushMode_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

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
		private struct _003CTestLinkmic_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

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

		public Button Button_Mode1;

		public Button Button_Mode2;

		public Transform waterFallEffect;

		private static DouyinFantasyMapStartup _instance;

		public Text LogText;

		private readonly LogConsole _logConsole;

		public static DouyinFantasyMapStartup Instance => null;

		private LogWriter Log { get; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void InitEvents()
		{
		}

		[AsyncStateMachine(typeof(_003CStartDirectPushMode_003Ed__15))]
		private void StartDirectPushMode()
		{
		}

		[AsyncStateMachine(typeof(_003CTestLinkmic_003Ed__16))]
		private void TestLinkmic()
		{
		}

		public void StartNewGame()
		{
		}
	}
}
