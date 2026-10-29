using Michsky.MUIP;
using UnityEngine;

[RequireComponent(typeof(ButtonManager))]
public class LocalizationButton : MonoBehaviour
{
	public string key;

	public float fontSizeCN;

	public float fontSizeEn;

	public int spacingEN;

	private int spacingCN;

	private ButtonManager button;

	public GameObject HoverTips;

	public string tooltipsKey;

	private TooltipTrigger m_TooltipTrigger;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnButtonHover()
	{
	}

	private void OnButtonExit()
	{
	}

	public void RefreshLocalization()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void EnsureTooltipTrigger()
	{
	}

	private void RefreshTooltipBinding()
	{
	}
}
