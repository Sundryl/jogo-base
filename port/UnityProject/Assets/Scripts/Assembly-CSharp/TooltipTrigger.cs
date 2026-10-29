using System;
using UnityEngine;

[DisallowMultipleComponent]
public class TooltipTrigger : MonoBehaviour, ITooltipProvider
{
	[Tooltip("用于本地化的提示键")]
	[Header("Tooltip Settings")]
	[SerializeField]
	private string m_TooltipKey;

	[TextArea]
	[Tooltip("直接显示的自定义提示文本")]
	[SerializeField]
	private string m_CustomTooltipText;

	[SerializeField]
	[Tooltip("是否启用 Tooltip")]
	private bool m_IsEnabled;

	private TooltipContentProvider m_DynamicProvider;

	public string TooltipKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string CustomTooltipText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool TryGetTooltip(out TooltipContent content)
	{
		content = default;
		return false;
	}

	private string GetTooltipContent()
	{
		return null;
	}

	public void SetTooltip(string _key)
	{
	}

	public void SetCustomTooltip(string _text)
	{
	}

	public void SetDynamicGenerator(Func<string> generator, bool isLocalizationKey = false)
	{
	}

	public void SetDynamicProvider(TooltipContentProvider provider)
	{
	}

	public void ClearTooltip()
	{
	}

	public void SetEnabled(bool enabled)
	{
	}
}
