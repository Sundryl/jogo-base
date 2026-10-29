using System;
using UnityEngine;

[Serializable]
public class SelectItemData
{
	[Tooltip("项目的唯一键")]
	public string Key;

	[Tooltip("本地化键（如果使用本地化）")]
	public string LocalizationKey;

	[Tooltip("自定义文本（如果不使用本地化）")]
	public string CustomText;

	public Color? ButtonColor;

	public string TooltipText;

	public bool IsTooltipLocalizationKey;

	public Func<string> TooltipGenerator;

	public bool IsTooltipGeneratorLocalizationKey;

	public SelectItemData(string key, string localizationKey = "", string customText = "", Color? buttonColor = null, string tooltipText = null, bool isTooltipLocalizationKey = false)
	{
	}
}
