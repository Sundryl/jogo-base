using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BiomeSelection : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CInitializeBiomeSelectionDelayed_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CInitializeBiomeSelectionDelayed_003Ed__6(int _003C_003E1__state)
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

	public Image Border;

	public Image BiomeColor;

	public int biomeIndex;

	public bool isNull;

	public Button ButtonManager;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CInitializeBiomeSelectionDelayed_003Ed__6))]
	private IEnumerator InitializeBiomeSelectionDelayed()
	{
		return null;
	}

	public void SetEnabled(bool enabled)
	{
	}

	public void OnClick()
	{
	}

	public void UpdateDisplay()
	{
	}
}
