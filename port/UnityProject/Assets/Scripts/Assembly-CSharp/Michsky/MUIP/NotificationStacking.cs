using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Michsky.MUIP
{
	[AddComponentMenu("Modern UI Pack/Notification/Notification Stacking")]
	public class NotificationStacking : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStartNotification_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NotificationStacking _003C_003E4__this;

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
			public _003CStartNotification_003Ed__6(int _003C_003E1__state)
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

		[Header("Settings")]
		public float delay;

		private List<NotificationManager> notifications;

		private int currentNotification;

		private bool enableUpdating;

		private void Update()
		{
		}

		public void AddToStack(NotificationManager notif)
		{
		}

		[IteratorStateMachine(typeof(_003CStartNotification_003Ed__6))]
		private IEnumerator StartNotification()
		{
			return null;
		}
	}
}
