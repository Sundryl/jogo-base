using UnityEngine;

public sealed class ConquestFlagAnimationData
{
	public Province Province { get; }

	public Color PreviousOwnerColor { get; }

	public Color NewOwnerColor { get; }

	public ConquestFlagAnimationData(Province province, Color previousOwnerColor, Color newOwnerColor)
	{
	}
}
