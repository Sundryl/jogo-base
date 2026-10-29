using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Michsky.MUIP;
using UnityEngine;

public class LoadSaveDataUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRestoreSavePanelCoroutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadSaveDataUI _003C_003E4__this;

		private UIManager _003CuiManager_003E5__2;

		private CanvasGroup _003CsavePanel_003E5__3;

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
		public _003CRestoreSavePanelCoroutine_003Ed__30(int _003C_003E1__state)
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

	private static LoadSaveDataUI _instance;

	public GameObject saveDataButtonPrefab;

	public RectTransform showSaveDataPanel;

	public ButtonManager closeButton;

	private bool isLoadMode;

	private bool m_ShouldRestoreSavePanelAfterWarning;

	private Coroutine m_RestoreSavePanelCoroutine;

	public string currentSelectSaveID;

	public static LoadSaveDataUI Instance => null;

	private void Start()
	{
	}

	public void OnOpen(bool loadMode, bool isLoadWorkshop)
	{
	}

	private void RefreshSaveList(bool isLoadWorkshop)
	{
	}

	private void CreateNewSaveButton()
	{
	}

	private void CreateSaveButton(SaveInfo save)
	{
	}

	private void OnSaveButtonClicked(string saveIdentifier)
	{
	}

	private void LoadOrUpLoadToWorkShop(string saveIdentifier)
	{
	}

	public void UploadToWorkShop()
	{
	}

	private void LoadSave(string saveIdentifier, SaveSystem.SaveFileLoadMode loadMode)
	{
	}

	public void LoadCurrentSave()
	{
	}

	private static bool IsSaveLargerThanLoadModeSelectionThreshold(string filePath)
	{
		return false;
	}

	private void CompleteSelectedSaveLoad(string saveIdentifier, SaveSystem.SaveFileLoadMode loadMode)
	{
	}

	public void DeleteCurrentSave()
	{
	}

	private void RequestOverwriteConfirmation(string saveIdentifier)
	{
	}

	private SaveInfo FindSaveById(string saveId)
	{
		return null;
	}

	private void OverwriteSave(SaveInfo save)
	{
	}

	private void CreateNewSave()
	{
	}

	public void OnClose()
	{
	}

	private void TemporarilyCloseSavePanel()
	{
	}

	private void RestoreSavePanelAfterWarning()
	{
	}

	[IteratorStateMachine(typeof(_003CRestoreSavePanelCoroutine_003Ed__30))]
	private IEnumerator RestoreSavePanelCoroutine()
	{
		return null;
	}

	private void StopRestoreSavePanelCoroutine()
	{
	}
}
