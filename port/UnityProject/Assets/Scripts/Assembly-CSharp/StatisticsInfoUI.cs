using System.Collections.Generic;
using System.Text;
using Michsky.MUIP;
using TMPro;
using UnityEngine;

internal class StatisticsInfoUI : MonoBehaviour
{
	public TextMeshProUGUI statisticText;

	public TextMeshProUGUI religionInfoText;

	private static StatisticsInfoUI _instance;

	private StatisticsCategory currentCategory;

	public ButtonManager statisticsCategoryButton;

	private float updateTimer;

	private const float UPDATE_INTERVAL = 1f;

	public static StatisticsInfoUI Instance => null;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void OnStatisticsCategoryButtonClicked()
	{
	}

	private void UpdateStatistics()
	{
	}

	private string GetCategoryTitle(StatisticsCategory category)
	{
		return null;
	}

	private void UpdatePowerRanking(StringBuilder sb)
	{
	}

	private void UpdatePopulationRanking(StringBuilder sb)
	{
	}

	private static long GetStateInternalPopulation(State state)
	{
		return 0L;
	}

	private void UpdateEconomicRanking(StringBuilder sb)
	{
	}

	private void UpdateWarStatistics(StringBuilder sb)
	{
	}

	private static void AppendV1WarStatistics(StringBuilder _sb, War _war)
	{
	}

	private static void AppendV2WarStatistics(StringBuilder _sb, WarV2 _war)
	{
	}

	private static float GetV2SideKills(WarV2 _war, IEnumerable<int> _stateIds)
	{
		return 0f;
	}

	private static string ResolveV2StateName(int _stateId)
	{
		return null;
	}

	private void UpdateDetailedReligionInfo(StringBuilder sb)
	{
	}

	private void UpdateReligionStatistics(StringBuilder sb)
	{
	}

	private int CalculateReligionFollowers(string religionId)
	{
		return 0;
	}

	public void OnStatisticsInfoPanelClosed()
	{
	}

	public void UpdateCorruptionInfo(StringBuilder sb)
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
}
