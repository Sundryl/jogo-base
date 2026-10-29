using MPUIKIT;
using UnityEngine;

public class LocalizationTmpButtonWithImage : LocalizationTmpButton
{
	[SerializeField]
	[Tooltip("The MPImage component to control visibility based on selection state")]
	private MPImage m_ControlledImage;

	[Tooltip("Whether the image should be visible when selected")]
	[SerializeField]
	private bool m_ShowImageWhenSelected;

	[Tooltip("Whether the image should be visible when not selected")]
	[SerializeField]
	private bool m_ShowImageWhenNotSelected;

	public MPImage ControlledImage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void ApplySelectionState()
	{
	}

	private void UpdateImageVisibility()
	{
	}
}
