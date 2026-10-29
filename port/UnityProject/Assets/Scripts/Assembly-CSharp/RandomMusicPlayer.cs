using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RandomMusicPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayMusicWithIntervals_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RandomMusicPlayer _003C_003E4__this;

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
		public _003CPlayMusicWithIntervals_003Ed__18(int _003C_003E1__state)
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

	[SerializeField]
	private List<AudioClip> musicList;

	[SerializeField]
	private int recentTracksToAvoid;

	[SerializeField]
	private float minInterval;

	[SerializeField]
	private float maxInterval;

	[Range(0f, 1f)]
	[SerializeField]
	private float bgmVolume;

	[SerializeField]
	private AudioClip firstTrackToPlay;

	private AudioSource audioSource;

	private Queue<int> recentlyPlayedIndices;

	private List<int> availableIndices;

	private bool isWaitingForNextTrack;

	private Coroutine playbackCoroutine;

	private static RandomMusicPlayer _instance;

	public static RandomMusicPlayer Instance => null;

	private void Awake()
	{
	}

	private void SetupAudioSource()
	{
	}

	private void Start()
	{
	}

	private void RefreshAvailableIndices()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayMusicWithIntervals_003Ed__18))]
	private IEnumerator PlayMusicWithIntervals()
	{
		return null;
	}

	public void SetVolume(float volume)
	{
	}

	public float GetVolume()
	{
		return 0f;
	}

	public bool IsPlaying()
	{
		return false;
	}

	public void RestartPlayback()
	{
	}

	private void StartPlayback()
	{
	}
}
