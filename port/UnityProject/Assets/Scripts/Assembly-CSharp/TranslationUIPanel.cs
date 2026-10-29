using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TranslationUIPanel : MonoBehaviour
{
	public enum TranslationObjectType
	{
		Country = 0,
		Alliance = 1,
		City = 2,
		Religion = 3,
		Custom = 4
	}

	[CompilerGenerated]
	private sealed class _003CTranslateToAllLanguages_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string _requestSourceText;

		public TranslationUIPanel _003C_003E4__this;

		public string _sourceText;

		public string _sourceLanguage;

		public string _requestTextType;

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
		public _003CTranslateToAllLanguages_003Ed__26(int _003C_003E1__state)
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

	[Header("UI组件")]
	[SerializeField]
	public GameObject m_TranslationContainer;

	[SerializeField]
	public GameObject m_TranslationPrefab;

	[SerializeField]
	public Button m_CloseButton;

	[SerializeField]
	public Button m_AutoTranslateButton;

	private string m_CurrentTranslatingKey;

	private TranslationObjectType m_CurrentObjectType;

	private Action<string, Dictionary<string, string>> m_OnTranslationCompleted;

	private TranslationPanelOptions m_CurrentOptions;

	private List<GameObject> m_TranslationItems;

	private Dictionary<string, string> m_TranslationCache;

	private bool m_IsAutoTranslating;

	private static TranslationUIPanel s_Instance;

	public static TranslationUIPanel Instance => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Initialize(string _key, TranslationObjectType _objectType, string _displayName, Dictionary<string, string> _initialTranslations = null, Action<string, Dictionary<string, string>> _onCompleted = null)
	{
	}

	public void Initialize(string _key, TranslationObjectType _objectType, string _displayName, Dictionary<string, string> _initialTranslations, Action<string, Dictionary<string, string>> _onCompleted, TranslationPanelOptions _options)
	{
	}

	private string GetObjectTypeText(TranslationObjectType _type)
	{
		return null;
	}

	private void CreateTranslationItems(Dictionary<string, string> _initialTranslations)
	{
	}

	private void OnTranslationChanged(string _language, string _newText)
	{
	}

	private void ClearTranslationItems()
	{
	}

	public void ClosePanel()
	{
	}

	private void RefreshLayout()
	{
	}

	public void AutoTranslateAll()
	{
	}

	[IteratorStateMachine(typeof(_003CTranslateToAllLanguages_003Ed__26))]
	private IEnumerator TranslateToAllLanguages(string _sourceText, string _requestSourceText, string _sourceLanguage, string _requestTextType)
	{
		return null;
	}

	private bool ShouldAutoDetectSourceLanguage(string _sourceLanguage, string _sourceText)
	{
		return false;
	}

	private void UpdateTranslationItemText(string _language, string _text)
	{
	}
}
