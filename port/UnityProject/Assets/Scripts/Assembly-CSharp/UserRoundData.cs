using System;

[Serializable]
public class UserRoundData
{
	public string openId { get; set; }

	public long score { get; set; }

	public long winningPoints { get; set; }

	public long winningStreakCount { get; set; }

	public int roundResult { get; set; }

	public string groupId { get; set; }
}
