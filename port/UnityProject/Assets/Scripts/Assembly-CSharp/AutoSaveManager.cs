public class AutoSaveManager
{
	public const int c_DefaultIntervalMinutes = 10;

	public const int c_MinIntervalMinutes = 5;

	public const int c_MaxIntervalMinutes = 60;

	private const int c_SaveCountdownSeconds = 5;

	private const float c_SavePromptLeadSeconds = 0.2f;

	private const string c_AutoSaveCountdownCancelableKey = "AutoSaveCountdownCancelable";

	private const string c_AutoSaveInProgressKey = "AutoSaveInProgress";

	private static AutoSaveManager s_Instance;

	private bool m_IsEnabled;

	private int m_IntervalMinutes;

	private float m_ElapsedSeconds;

	private bool m_IsSaving;

	private bool m_IsSaveScheduled;

	private float m_ScheduledSaveDelaySeconds;

	private bool m_IsBlockedByWallpaperMode;

	private bool m_IsInCancelableCountdown;

	private bool m_IsMouseInputLocked;

	private string m_LastCountdownPromptText;

	private string m_LastInProgressPromptText;

	private int m_LastAnnouncedCountdownSecond;

	public static AutoSaveManager Instance => null;

	public bool IsEnabled => false;

	public int IntervalMinutes => 0;

	public static bool IsMouseInputLocked => false;

	public bool TryCancelCountdownAutoSave()
	{
		return false;
	}

	public void Configure(bool _isEnabled, int _intervalMinutes, bool _resetTimer = true)
	{
	}

	public void SetEnabled(bool _isEnabled, bool _resetTimer = true)
	{
	}

	public int SetIntervalMinutes(int _intervalMinutes, bool _resetTimer = true)
	{
		return 0;
	}

	public void ResetTimer()
	{
	}

	public void Update(float _deltaTime)
	{
	}

	private void TryShowAutoSaveCountdown(float _intervalSeconds)
	{
	}

	private void ShowCountdownMajorEvent(int _remainingSeconds)
	{
	}

	private void ResetCountdownState()
	{
	}

	private void TriggerAutoSave()
	{
	}

	private void ExecuteScheduledAutoSave()
	{
	}

	private string GetCountdownPromptText(int _remainingSeconds)
	{
		return null;
	}

	private string GetInProgressPromptText()
	{
		return null;
	}

	private void SetMouseInputLocked(bool _isLocked)
	{
	}
}
