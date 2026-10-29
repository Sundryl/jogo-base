using Michsky.MUIP;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class MannualUI : MonoBehaviour
{
	private static MannualUI s_Instance;

	[Header("UI 引用")]
	[Tooltip("用于显示手册内容的 LocalizationText 组件。")]
	[SerializeField]
	private LocalizationText m_ContentText;

	[Tooltip("关闭按钮（可选）")]
	[Header("可选设置")]
	[SerializeField]
	private ButtonManager m_CloseButton;

	private Coroutine m_Coroutine;

	private bool m_IsInitialized;

	public static MannualUI Instance => null;

	private void Start()
	{
	}

	private void Initialize()
	{
	}

	public void Show(string _localizationKey)
	{
	}

	public void Show(string _customText, bool _isCustom)
	{
	}

	public void Hide()
	{
	}

	private void RefreshLayout()
	{
	}

	private void OnDestroy()
	{
	}
}
