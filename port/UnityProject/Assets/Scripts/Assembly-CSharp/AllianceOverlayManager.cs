public class AllianceOverlayManager
{
	private static AllianceOverlayManager s_Instance;

	public static AllianceOverlayManager Instance => null;

	private AllianceOverlayManager()
	{
	}

	private static bool IsAllianceRenderable(Alliance alliance)
	{
		return false;
	}

	public void ClearAllAllianceVisuals()
	{
	}

	public void CreateAllAllianceLabels()
	{
	}

	public void ForceUpdateAllianceLabels()
	{
	}

	public void MarkAllianceDirty(Alliance alliance)
	{
	}

	public void UpdateAllianceLabels()
	{
	}

	public void SetAllianceLabelVisibility(bool isVisible)
	{
	}

	public void RemoveAllianceVisuals(Alliance alliance)
	{
	}

	public void RequestFullRefresh()
	{
	}

	private void CreateAllianceLabel(Alliance alliance)
	{
	}

	private void UpdateAllianceLabel(Alliance alliance)
	{
	}
}
