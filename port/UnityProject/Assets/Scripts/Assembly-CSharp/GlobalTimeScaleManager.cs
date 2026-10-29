using System.Runtime.CompilerServices;
using UnityEngine;

public class GlobalTimeScaleManager : MonoBehaviour
{
	public delegate void TimeScaleChangeHandler(float speed, string desc);

	[CompilerGenerated]
	private static TimeScaleChangeHandler m_OnTimeScaleChange;

	[SerializeField]
	private float defaultTimeScale;

	private float[] speedSettings;

	private string[] speedDesc;

	private int currentSpeedIndex;

	private int defaultSpeedIndex;

	public static GlobalTimeScaleManager Instance { get; private set; }

	public static event TimeScaleChangeHandler OnTimeScaleChange
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetTimeScale(float scale)
	{
	}

	public void SpeedUp(float multiplier)
	{
	}

	public void SlowDown(float divider)
	{
	}

	public void ResetToDefault()
	{
	}

	public void AddGameSpeed()
	{
	}

	public void DelGameSpeed()
	{
	}

	public void ApplyGameSpeed(int Idx)
	{
	}

	public string GetCurrentSpeedDesc()
	{
		return null;
	}
}
