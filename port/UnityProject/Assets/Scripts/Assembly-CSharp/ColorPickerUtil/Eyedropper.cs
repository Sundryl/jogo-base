using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace ColorPickerUtil
{
	public class Eyedropper : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoSampling_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Eyedropper _003C_003E4__this;

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
			public _003CDoSampling_003Ed__17(int _003C_003E1__state)
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
		private RectTransform blocker;

		public Image targetGraphic;

		public EyedropperPreview preview;

		[Tooltip("Keep/Discard preview image when sampling ends")]
		public bool keepPreview;

		public ColorPickerColorEvent onValueChanged;

		public ColorPickerColorEvent onEndSampling;

		[HideInInspector]
		public Color currentColor;

		[HideInInspector]
		public Color newColor;

		private Texture2D samplingTexture;

		private int resolution;

		private bool isSampling;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Initialize()
		{
		}

		private void Update()
		{
		}

		public void StartSampling()
		{
		}

		public void StopSampling(bool isCanceled = false)
		{
		}

		[IteratorStateMachine(typeof(_003CDoSampling_003Ed__17))]
		private IEnumerator DoSampling()
		{
			return null;
		}
	}
}
