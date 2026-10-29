using System.Collections.Generic;
using ByteDance.Live.Foundation.Logging;
using UnityEngine.UI;

namespace Douyin.LiveOpenSDK.Samples
{
	internal class LogConsole
	{
		private const int MaxCount = 15;

		private readonly Queue<string> _messageQueue;

		public Severity MinSeverity;

		public Text Text { get; set; }

		public void WriteLog(Severity severity, string richText)
		{
		}
	}
}
