using System;

[Serializable]
public class WarParticipantV2
{
	public int StateId;

	public WarSideV2 Side;

	public WarRoleV2 Role;

	public double JoinedAt;

	public bool IsPrimary;
}
