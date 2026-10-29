using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DouyinCanvasInfo : MonoBehaviour
{
	private int currentStateIdx;

	private List<int> ShowStateIdxs;

	private float refreshStateInterval;

	private float lastRefreshTime;

	private float tickStateInterval;

	private float lastTickTime;

	public TextMeshProUGUI StateInfoText;

	public Image WorkShopEntry;

	public Image MapEditorEntry;

	private const int ShowMaxNum = 12;

	private void Start()
	{
	}

	private int FindNextValidState(int Index)
	{
		return 0;
	}

	private void FixedUpdate()
	{
	}

	private void ShowStatesRanking()
	{
	}

	private void ShowCurStateInfo()
	{
	}

	private void ShowStateStrength()
	{
	}
}
