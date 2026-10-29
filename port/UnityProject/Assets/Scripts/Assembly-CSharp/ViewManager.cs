using System.Collections.Generic;
using FantasyWorld.CharacterSystem;
using Newtonsoft.Json;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
	private static ViewManager m_Instance;

	private Dictionary<ColorViewMode, string> m_ViewModeTranslation;

	[JsonIgnore]
	private ColorViewMode m_CurrentColorView;

	public static ViewManager Instance => null;

	[JsonIgnore]
	public ColorViewMode CurrentColorView => ColorViewMode.Normal;

	public bool IsViewMode(ColorViewMode mode)
	{
		return false;
	}

	public ColorViewMode GetCurrentColorView()
	{
		return ColorViewMode.Normal;
	}

	private void Update()
	{
	}

	private void UpdateFamilyLabelsIfNeeded()
	{
	}

	public void SetColorViewMode(ColorViewMode mode, bool showMessage = false)
	{
	}

	public void RefreshCurrentColorView()
	{
	}

	public void UpdateLabelAndBorderVisibility()
	{
	}

	private void UpdateCultureLabelsAndBorderVisibility()
	{
	}

	private void UpdateReligionLabelsAndBorderVisibility()
	{
	}

	private void UpdateStateLabelsAndBorderVisibility()
	{
	}

	private void UpdateDistrictLabelsAndBorderVisibility()
	{
	}

	private void UpdateFamilyLabelsAndBorderVisibility()
	{
	}

	private bool ShouldShowMixedViewFamilyLabel(Family family)
	{
		return false;
	}

	private void ApplyCurrentColorView()
	{
	}

	private void UpdateLabelsForCurrentView()
	{
	}

	private void UpdateAllianceLabelsAndBorderVisibility()
	{
	}
}
