using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using UnityEngine.Networking;

public class TranslationService
{
	[CompilerGenerated]
	private sealed class _003CBatchTranslateTexts_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IEnumerable<string> _texts;

		public Action<Dictionary<string, string>> _onComplete;

		public TranslationService _003C_003E4__this;

		public string _targetLanguage;

		public string _sourceLanguage;

		public string _textType;

		public int _cacheHours;

		private Dictionary<string, string> _003CdistinctTextTranslations_003E5__2;

		private string _003CazureTargetLang_003E5__3;

		private string _003CazureSourceLang_003E5__4;

		private List<string> _003CtextsForApiCall_003E5__5;

		private int _003Ci_003E5__6;

		private List<string> _003CcurrentChunk_003E5__7;

		private string _003CrequestBodyJson_003E5__8;

		private string _003CproxyUrl_003E5__9;

		private int _003CretryCount_003E5__10;

		private bool _003CchunkSuccess_003E5__11;

		private float _003CcurrentRetryDelay_003E5__12;

		private UnityWebRequest _003Crequest_003E5__13;

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
		public _003CBatchTranslateTexts_003Ed__13(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public Dictionary<string, string> originalToReplacedLanguageMap;

		public Action<string, Dictionary<string, string>> _onLanguageComplete;
	}

	[CompilerGenerated]
	private sealed class _003CBatchTranslateToMultipleLanguages_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<string, Dictionary<string, string>> _onLanguageComplete;

		public IEnumerable<string> _texts;

		public Action _onAllComplete;

		public IEnumerable<string> _targetLanguages;

		public TranslationService _003C_003E4__this;

		public string _sourceLanguage;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		public int _cacheHours;

		public string textType;

		public float _delayBetweenLanguages;

		private string _003CactualSourceLanguage_003E5__2;

		private List<string>.Enumerator _003C_003E7__wrap2;

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
		public _003CBatchTranslateToMultipleLanguages_003Ed__14(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const string c_ProxyEndpoint = "https://fmstanslate-d5h6e0atf9fwa6h2.westus3-01.azurewebsites.net/api/translator/translate?code=eA2TUvyj4qDjGlnyn5P8rgjNK-lcInEXeVHgBoEV0zXIAzFuObCJVQ==";

	private Dictionary<string, Dictionary<string, string>> m_TranslationCache;

	private const int c_MaxRetries = 3;

	private const float c_RetryDelaySeconds = 1f;

	private const int c_MaxTextsPerBatch = 100;

	private const int c_MaxCharsPerBatch = 48000;

	private const int c_DefaultCacheHours = 720;

	private static TranslationService s_Instance;

	public static TranslationService Instance => null;

	public void Initialize()
	{
	}

	private string ReplaceLanguageForCostReduction(string _languageCode)
	{
		return null;
	}

	private string ConvertToAzureLanguageCode(string _languageCode)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBatchTranslateTexts_003Ed__13))]
	public IEnumerator BatchTranslateTexts(IEnumerable<string> _texts, string _targetLanguage, string _sourceLanguage, Action<Dictionary<string, string>> _onComplete, int _cacheHours = 720, string _textType = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBatchTranslateToMultipleLanguages_003Ed__14))]
	public IEnumerator BatchTranslateToMultipleLanguages(IEnumerable<string> _texts, IEnumerable<string> _targetLanguages, string _sourceLanguage = null, Action<string, Dictionary<string, string>> _onLanguageComplete = null, Action _onAllComplete = null, int _cacheHours = 720, float _delayBetweenLanguages = 0.1f, string textType = null)
	{
		return null;
	}

	private bool TryProcessObjectResponse(JObject _responseObject, List<string> _currentChunk, string _azureTargetLang, string _azureSourceLang, Dictionary<string, string> _distinctTextTranslations, string _textType)
	{
		return false;
	}

	private bool TryProcessTranslationArray(JArray _responseArray, List<string> _currentChunk, string _azureTargetLang, string _azureSourceLang, Dictionary<string, string> _distinctTextTranslations, string _textType)
	{
		return false;
	}

	private void EnsureChunkFallback(IEnumerable<string> _currentChunk, Dictionary<string, string> _distinctTextTranslations)
	{
	}

	private void LogCacheStats(JToken _statsToken, bool _isLegacyFormat)
	{
	}

	private double? TryParseDouble(JToken _token)
	{
		return null;
	}

	private int TryParseInt(JToken _token)
	{
		return 0;
	}
}
