using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MPUIKIT;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class WarningWithAction : MonoBehaviour
{
	public class ButtonConfig
	{
		public string LocalizationKey;

		public UnityAction Action;

		public bool HideAfterAction;

		public ButtonConfig(string localizationKey, UnityAction action, bool hideAfterAction = true)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCheckTextAlignment_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TextMeshProUGUI _tmpText;

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
		public _003CCheckTextAlignment_003Ed__18(int _003C_003E1__state)
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

	private static WarningWithAction s_Instance;

	[Tooltip("用于显示警告标题/消息的 LocalizationText 组件。")]
	[SerializeField]
	[Header("UI 引用")]
	private LocalizationText m_TitleText;

	[Tooltip("按钮容器对象，所有动态生成的按钮都将放置在这里")]
	[SerializeField]
	private Transform m_ButtonContainer;

	[Tooltip("用于执行操作的按钮预制体。预制体上应有 Button 和 LocalizationTmpButton 组件。")]
	[SerializeField]
	private Button m_ActionButtonPrefab;

	[SerializeField]
	[Tooltip("按钮颜色列表，创建按钮时将循环使用这些颜色")]
	private List<Color> m_ButtonColors;

	private Coroutine m_Coroutine;

	private List<Button> m_CurrentButtons;

	private bool m_IsInitialized;

	private Button m_DefaultCloseButton;

	[SerializeField]
	private MPImage m_BorderImage;

	public static WarningWithAction Instance => null;

	private void Awake()
	{
	}

	private void Initialize()
	{
	}

	public void Show(string _titleKey, string _buttonKey, UnityAction _buttonAction, bool _hideAfterAction = true, bool _useCloseButton = true, float _borderAlpha = 177f / 255f)
	{
	}

	public void Show(string _titleContent, List<ButtonConfig> _buttonConfigs, bool _isCustomTitle = false, bool _useCloseButton = true, float _borderAlpha = 177f / 255f)
	{
	}

	private void CreateButton(string _localizationKey, UnityAction _action, Color _color, bool _hideAfterAction)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckTextAlignment_003Ed__18))]
	private IEnumerator CheckTextAlignment(TextMeshProUGUI _tmpText)
	{
		return null;
	}

	private void ClearButtons()
	{
	}

	public void Hide()
	{
	}

	private void RefreshLayOut()
	{
	}

	private void SetDefaultCloseButtonState(bool isEnabled)
	{
	}

	private void EnsureDefaultCloseButton()
	{
	}

	private void SetBorderAlpha(float alpha)
	{
	}

	private void EnsureBorderImage()
	{
	}
}
